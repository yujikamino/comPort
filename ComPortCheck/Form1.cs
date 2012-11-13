using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace ComPortCheck
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] PortList = SerialPort.GetPortNames();
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            comboBox4.Items.Clear();
            foreach (string PortName in PortList)
            {
                comboBox1.Items.Add(PortName);
            }
            if (comboBox1.Items.Count > 0)
            {
                comboBox1.SelectedIndex = 0;
            }
            foreach (string PortName in PortList)
            {
                comboBox2.Items.Add(PortName);
            }
            if (comboBox2.Items.Count > 0)
            {
                comboBox2.SelectedIndex = 0;
            }
            foreach (string PortName in PortList)
            {
                comboBox3.Items.Add(PortName);
            }
            if (comboBox3.Items.Count > 0)
            {
                comboBox3.SelectedIndex = 0;
            }
            foreach (string PortName in PortList)
            {
                comboBox4.Items.Add(PortName);
            }
            if (comboBox4.Items.Count > 0)
            {
                comboBox4.SelectedIndex = 0;
            }

        }


        private void testStartButton_Click(object sender, EventArgs e)
        {
            Judgelabel.Text = "-";
            TRX1judge.Text = "-";
            TRX2judge.Text = "-";
            EXT1judge.Text = "-";
            EXT2judge.Text = "-";




            string[] ComPortnum = new string[2];
            string[] ComPortnumEXT = new string[2];

            ComPortnum[0] = comboBox1.Text;
            ComPortnum[1] = comboBox2.Text;
            
            ComPortnumEXT[0] = comboBox3.Text;
            ComPortnumEXT[1] = comboBox4.Text;



            const int N = 4;
            Thread[] threads = new Thread[N];

            for (int i = 0; i < N/2; i++)
            {
                threads[i] = new Thread(new ParameterizedThreadStart(comPortOpen));
                threads[i].Start(ComPortnum[i]);
            }

            for (int i = 0; i < N / 2; i++)
            {
                threads[i] = new Thread(new ParameterizedThreadStart(comPortOpen));
                threads[i].Start(ComPortnumEXT[i]);
            }

            for (int i = 0; i < N; ++i)
            {
                threads[i].Join();
            }
        }

        private void comPortOpen(object o)
        {
            string comPortName = (string)o;
            //ポートセッティング
            int BaudRate = 9600;
            Parity Parity = Parity.None;
            int DataBits = 8;
            StopBits StopBits = StopBits.One;
            SerialPort myPort =
            new SerialPort(comPortName, BaudRate, Parity, DataBits, StopBits);
            
            try
            {
                myPort.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }


            //TRX1->TRX2 送信
            int result = 0;
            do
            {
                if (!dataSendTest(myPort))
                {
                    TRX1judge.Text = "NG";
                    break;
                }
                result = 1;

            } while (false);

            do
            {

                if (!dataGetTest(myPort))
                {
                    TRX1judge.Text = "NG";
                    break;
                }
            } while (false);

            if (result == 1)
                Judgelabel.Text = "OK";
            else
                Judgelabel.Text = "NG";


            portCloseall(myPort);


        }

        private Boolean dataSendTest(SerialPort myPort)
        {
            if (myPort.IsOpen == false)
            {
                return false;
            }
            try
            {
                myPort.WriteLine("ABCDEF");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return true;

        }

        private Boolean dataGetTest(SerialPort myPort)
        {
            System.Threading.Thread.Sleep(200);
            string data = null;
            
            if (myPort.IsOpen == false)
            {
                return false;
            }
            try
            {
                myPort.ReadExisting();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            int iCompare = data.CompareTo("ABCDEF\n");
            if (iCompare == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void portCloseall(SerialPort myPort)
        {
            myPort.Close();
            myPort.Dispose();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
