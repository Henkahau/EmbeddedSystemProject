using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Threading;
using System.Timers;

namespace EmbeddedSystemProject
{
    public partial class Form1 : Form
    { 
        private float fTemp = 0;
        private float fHumid = 0;
        private DateTime time = new DateTime();
              
        private System.Timers.Timer timer;
        MySqlConnection myConnection;
        MySqlCommand myCommand;
        MySqlDataReader dataReader;
        private delegate void DELEGATE();

        public Form1()
        {
            InitializeComponent();     
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //connect to MySql-database
            string connectionString = "server='192.168.137.54'; database=weatherLog; user=user; password = pass;";

            myConnection = new MySqlConnection(connectionString);

            try
            {
                //yrittää yhdistää tietokantaan
                myConnection.Open();
            }
            catch(MySqlException)
            {
                //Jos yhteyttä tietokantaan ei ole näytetään messagebox
                MessageBox.Show("Cannot connect to database. Check your network"+Environment.NewLine+"Program will be closed");
                
            }
            finally
            {
                //Jos yhteyttä ei saada ohjelma sammuu
                if (!(myConnection.State == ConnectionState.Open))
                    Application.Exit();
            }
            
            if (myConnection.State != ConnectionState.Open)
                MessageBox.Show("Cannot open database");
            else
                Console.WriteLine("Database opened");
            
            //tehdään timer 
            timer = new System.Timers.Timer(1000);
            timer.Start();
            timer.Elapsed += readDataFromDb;

        }


        private void readDataFromDb(object source, ElapsedEventArgs e)
        {
            // Tämä suoritetaan kun timer on päässyt loppuun
            // Luotiin try-catch välttämään satunnainen (harvinainen) virhe datareaderin sulkemisessa
            try
            {
                dataReader = null;
                myCommand = new MySqlCommand("SELECT * FROM dataLog ORDER BY id DESC LIMIT 1", myConnection);

                //read data from db to console
                dataReader = myCommand.ExecuteReader();
                dataReader.Read();
     
                Console.WriteLine(dataReader.GetFloat(2).ToString());
                fTemp = dataReader.GetFloat(2);
                fHumid = dataReader.GetFloat(3);

                Delegate del = new DELEGATE(WriteData);
                this.Invoke(del);

                dataReader.Close();

                myCommand.Dispose();
            }
            catch (MySqlException)
            {
                Console.WriteLine("DataReader was not closed properly the first time");
            }
            finally
            {
                if (!dataReader.IsClosed) dataReader.Close();
            }
        }

        private void WriteData()
        {
            //valtterin mittareihin välitettävät datat:
            //fHumid ja fTemp
            aGaugeTemp.Value = fTemp;
            labelTempValue.Text = fTemp.ToString()+" "+ "°C";
            time = DateTime.Now;
            
            
            aGaugeHumid.Value =  fHumid;
            labelHumidValue.Text = fHumid.ToString()+" "+"%";
            
            //kaavio
            chartHistory.Series["Temperature"].Points.AddXY(time, fTemp);

        }

      
    }
}
