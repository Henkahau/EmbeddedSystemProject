﻿using System;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace EmbeddedSystemProject
{
    public partial class Form1 : Form
    { 
        private float fTemp = 0;
        private float fHumid = 0;

        private int historyCounter = 0;
        private int oldHistoryCounter = 0;

        AxisScrollBar scrollBar = new AxisScrollBar();

        List<float> minHumidList = new List<float>();
        List<float> maxHumidList = new List<float>();
        List<float> minTempList = new List<float>();
        List<float> maxTempList = new List<float>();

        private ConnectDb oConnectDb = new ConnectDb("server='192.168.137.54'; database=weatherLog; user=user; password = pass;");

        private System.Timers.Timer timer;

        private delegate void DELEGATE();

        public Form1()
        {
            InitializeComponent();     
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //connect to MySql-database
            oConnectDb.createDbConnection();

            //tehdään timer 
            timer = new System.Timers.Timer(1000);
            timer.Start();
            timer.Elapsed += readDataFromDb;

        }


        private void readDataFromDb(object source, ElapsedEventArgs e)
        {
            
            oConnectDb.getLiveDataFromDb();

            historyCounter = oConnectDb.getHistoryDataCounter();

            if (historyCounter > oldHistoryCounter)
            {
                //minimi kosteusarvot
                for (int i = 1; i < historyCounter+1; i++)
                {
                    minHumidList.Add(oConnectDb.getHumidityHistoryMin(i));
                }

                //maksimi kosteusarvot
                for (int i = 1; i < historyCounter + 1; i++)
                {
                    maxHumidList.Add(oConnectDb.getHumidityHistoryMax(i));
                }

                //minimi lämpötila-arvot
                for (int i = 1; i < historyCounter + 1; i++)
                {
                    minTempList.Add(oConnectDb.getTemperatureHistoryMin(i));
                }

                //maksimi lämpötila-arvot
                for (int i = 1; i < historyCounter + 1; i++)
                {
                    maxTempList.Add(oConnectDb.getTemperatureHistoryMax(i));
                }

                oldHistoryCounter = historyCounter;
            }

            Delegate del = new DELEGATE(WriteData);
            this.Invoke(del);

        }

        private void WriteData()
        {            
            //valtterin mittareihin välitettävät datat:
            //fHumid ja fTemp
            fTemp = oConnectDb.getTemperature();
            fHumid = oConnectDb.getHumidity();

            aGaugeTemp.Value = fTemp;
            labelTempValue.Text = fTemp.ToString()+" "+ "°C";
           
            aGaugeHumid.Value = fHumid;
            labelHumidValue.Text = fHumid.ToString()+" "+"%";
            

            //live data kaavio
            //määritellään scrollbarit
            double maxX = chartLiveData.ChartAreas["ChartArea1"].AxisX.Maximum;
            chartLiveData.ChartAreas["ChartArea1"].AxisX.ScrollBar.Size = 10;
            chartLiveData.ChartAreas["ChartArea1"].AxisX.ScrollBar.Enabled = true;
            chartLiveData.ChartAreas["ChartArea1"].AxisX.ScrollBar.IsPositionedInside = true;
            
            //kaavion pisteet
            chartLiveData.Series["Temperature"].Points.AddY(fTemp);
            chartLiveData.Series["Humidity"].Points.AddY(fHumid);
            chartLiveData.ChartAreas["ChartArea1"].AxisX.ScaleView.Zoom(maxX -15, maxX);


        }


    }

    public class ConnectDb
    {
        private float mMinHumidity = 0;
        private float mMaxHumidity = 0;
        private float mMinTemp = 0;
        private float mMaxTemp = 0;
        private float mHumid = 0;
        private float mTemp = 0;

        private int mCounter = 0;
 
        private string mconnectionString;

        private MySqlConnection myConnection;
        private MySqlDataReader dataReader;

        public ConnectDb(string givenConnection)
        {
            mconnectionString = givenConnection;
        }

        public void createDbConnection()
        {
            myConnection = new MySqlConnection(mconnectionString);

            try
            {
                //yrittää yhdistää tietokantaan
                myConnection.Open();
            }
            catch (MySqlException)
            {
                //Jos yhteyttä tietokantaan ei ole näytetään messagebox
                MessageBox.Show("Cannot connect to database. Check your network" + Environment.NewLine + "Program will be closed");

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
        }

        public void getLiveDataFromDb()
        {
            try
            {
                dataReader = null;

                MySqlCommand mySqlCommandGetValues = new MySqlCommand("SELECT * FROM dataLog ORDER BY id DESC LIMIT 1", myConnection);

                dataReader = mySqlCommandGetValues.ExecuteReader();

                dataReader.Read();

                Console.WriteLine(dataReader.GetFloat(2).ToString());
                mTemp = dataReader.GetFloat(2);
                mHumid = dataReader.GetFloat(3);

                dataReader.Close();

                mySqlCommandGetValues.Dispose();


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

        public float getHumidity()
        {
            return mHumid;
        }

        public float getTemperature()
        {
            return mTemp;
        }

        public int getHistoryDataCounter()
        {
            try
            {
                dataReader = null;

                MySqlCommand mySqlCommandGetValues = new MySqlCommand("SELECT MAX(id) FROM historyLog", myConnection);

                dataReader = mySqlCommandGetValues.ExecuteReader();

                dataReader.Read();

                mCounter = dataReader.GetInt16(0);

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

            return mCounter;

        }

        public float getHumidityHistoryMin(int givenIndex)
        {
            try
            {
                dataReader = null;

                MySqlCommand mySqlCommandGetValues = new MySqlCommand("SELECT humidity_min FROM historyLog WHERE id = @id", myConnection);
                mySqlCommandGetValues.Parameters.AddWithValue("@id", givenIndex);

                dataReader = mySqlCommandGetValues.ExecuteReader();

                dataReader.Read();

                mMinHumidity = dataReader.GetFloat(0);

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

            return mMinHumidity;

        }

        public float getHumidityHistoryMax(int givenIndex)
        {
            try
            {
                dataReader = null;

                MySqlCommand mySqlCommandGetValues = new MySqlCommand("SELECT humidity_max FROM historyLog WHERE id = @id", myConnection);
                mySqlCommandGetValues.Parameters.AddWithValue("@id", givenIndex);

                dataReader = mySqlCommandGetValues.ExecuteReader();

                dataReader.Read();

                mMaxHumidity = dataReader.GetFloat(0);

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

            return mMaxHumidity;

        }

        public float getTemperatureHistoryMin(int givenIndex)
        {
            try
            {
                dataReader = null;

                MySqlCommand mySqlCommandGetValues = new MySqlCommand("SELECT temperature_min FROM historyLog WHERE id = @id", myConnection);
                mySqlCommandGetValues.Parameters.AddWithValue("@id", givenIndex);

                dataReader = mySqlCommandGetValues.ExecuteReader();

                dataReader.Read();

                mMinTemp = dataReader.GetFloat(0);

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

            return mMinTemp;

        }

        public float getTemperatureHistoryMax(int givenIndex)
        {
            try
            {
                dataReader = null;

                MySqlCommand mySqlCommandGetValues = new MySqlCommand("SELECT temperature_max FROM historyLog WHERE id = @id", myConnection);
                mySqlCommandGetValues.Parameters.AddWithValue("@id", givenIndex);

                dataReader = mySqlCommandGetValues.ExecuteReader();

                dataReader.Read();

                mMaxTemp = dataReader.GetFloat(0);

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

            return mMaxTemp;

        }
    }

}
