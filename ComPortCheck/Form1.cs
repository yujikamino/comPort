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
            int BaudRate = 9600;
            Parity Parity = Parity.None;
            int DataBits = 8;
            StopBits StopBits = StopBits.One;
            SerialPort myPort =
            new SerialPort(comboBox1.Text, BaudRate, Parity, DataBits, StopBits);
            SerialPort myPort2 =
            new SerialPort(comboBox2.Text, BaudRate, Parity, DataBits, StopBits);
            SerialPort myPort3 =
            new SerialPort(comboBox3.Text, BaudRate, Parity, DataBits, StopBits);
            SerialPort myPort4 =
            new SerialPort(comboBox4.Text, BaudRate, Parity, DataBits, StopBits);

            try
            {
                myPort.Open();
                myPort2.Open();
                myPort3.Open();
                myPort4.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
            //TRX1->TRX2 送信
            int result = 0;
            do
            {
                if (!dataSendTest(myPort, myPort2))
                {
                    break;
                }
                if (!dataSendTest(myPort2, myPort))
                {
                    break;
                }
                if (!dataSendTest(myPort3, myPort4))
                {
                    break;
                }
                if (!dataSendTest(myPort4, myPort3))
                {

                    break;
                }
                result = 1;
            } while (false);

            if (result == 1)
                Judgelabel.Text = "OK";
            else
                Judgelabel.Text = "NG";

            portCloseall(myPort,myPort2,myPort3,myPort4);

        }

        private Boolean dataSendTest(SerialPort myPort, SerialPort myPort2)
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
            string data = null;
            System.Threading.Thread.Sleep(100);
            try
            {
                data = myPort2.ReadExisting();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //string data = myPort2.ReadLine();

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

        private void portCloseall(SerialPort myPort, SerialPort myPort2, SerialPort myPort3, SerialPort myPort4)
        {
            myPort.Close();
            myPort.Dispose();
            myPort2.Close();
            myPort2.Dispose();
            myPort3.Close();
            myPort3.Dispose();
            myPort4.Close();
            myPort4.Dispose();
        }         
    }
}
