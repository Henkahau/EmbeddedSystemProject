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

namespace EmbeddedSystemProject
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //connect to MySql database
            string connectionString = "server='192.168.137.76'; database=weatherLog; user=user; password = pass;";

            MySqlConnection myConnection = new MySqlConnection(connectionString);

            myConnection.Open();

            if (myConnection.State != ConnectionState.Open)
                MessageBox.Show("Cannot connect to database");

            MySqlDataReader dataReader = null;

            MySqlCommand myCommand = new MySqlCommand("SELECT * FROM dataLog ORDER BY id DESC LIMIT 1", myConnection);

            while(myConnection.State == ConnectionState.Open)
            {
                //read data from db to console
                dataReader = myCommand.ExecuteReader();
                dataReader.Read();
                Console.WriteLine(dataReader.GetFloat(2));
                dataReader.Close();
                Thread.Sleep(1000);

            }
        }
    }
}
