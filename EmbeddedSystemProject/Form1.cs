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
        private string dataStr;
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
            string connectionString = "server='192.168.137.76'; database=weatherLog; user=user; password = pass;";

            myConnection = new MySqlConnection(connectionString);

            myConnection.Open();

            if (myConnection.State != ConnectionState.Open)
                MessageBox.Show("Cannot connect to database");
            else
                Console.WriteLine("Connection ok");
            
            //tehdään timer 
            timer = new System.Timers.Timer(1000);
            timer.Start();
            timer.Elapsed += readDataFromDb;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxData.Text = dataStr;
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
                dataStr = dataReader.GetFloat(2).ToString();
                Console.WriteLine(dataStr);
                //textBoxData.Text = dataStr;

                Delegate del = new DELEGATE(WriteData);
                this.Invoke(del);

                dataReader.Close();
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
            textBoxData.Text = dataStr;
        }
    }
}
