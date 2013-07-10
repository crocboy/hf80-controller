using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Windows.Forms;
using System.Threading;
namespace HF80
{
    public partial class MainForm : Form
    {
        #region //byte[] of messages

       // byte[] freq_req = {
        byte[] mode_req = { 0xD0, 0x80 };
        byte[] freq_req = { 0xC0, 0x80 };
        byte[] set_freq = { 0xC0, 0x54, 0x20, 0x00, 0x00 };
        byte[] set_mode_ssb = { 0xD0, 0x40, 0x00, 0x00, 0x20 };
        //byte[] set_mode_lsb = { 0xD0, 0x40, 0x00, 0x00, };
        byte[] set_mode_cw = { 0xD0, 0x40, 0x00, 0x00, 0x10 };
        byte[] set_mode_am = { 0xD0, 0x40, 0x00, 0x00, 0x40 };
        //byte[] fault_req = { 0xD0, 0x80 };

        #endregion
        

        /* Instance variables belonging to MainForm */
        private Radio radio;
        SerialPort sp;
        bool isConnected=false;
        float frequency;
        int currentMode;
        Thread updateThread;
      
        public MainForm()
        {
            InitializeComponent();
        }

        public void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

       

        private void b_connect_Click(object sender, EventArgs e)
        {
            String port;

            /* We're not connected, attempt to connect */
            if (!isConnected)
            {
                if (portList.SelectedIndex != -1)
                {
                    port = portList.SelectedItem.ToString();
                    radio = new Radio(port);

                    bool connected = radio.Connect();

                    if (connected)
                    {
                        connIndicator.BackColor = Color.LimeGreen;
                        label1.Text = port;
                        connectButton.Text = "Disconnect";
                        radio.onPrint += this.Print;
                        isConnected = true;
                        controlGroup.Enabled = true;
                    }

                    else
                    {
                        MessageBox.Show("Could not connect to " + port + "!", "Serial Port Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            /* We're already connected; so disconnect */
            else
            {
                radio.Close();
                connectButton.Text = "Connect";
                connIndicator.BackColor = Color.Red;
                isConnected = false;
                controlGroup.Enabled = false;
                printBox.Clear();
                radio = null;
            }
        }

        /* Called when the form first loads */
        private void Form1_Load(object sender, EventArgs e)
        {
            connIndicator.BackColor = Color.White;
            String[] ports = SerialPort.GetPortNames();
            connIndicator.BackColor = Color.Red;
            //  WindowState = System.Windows.Forms.FormWindowState.Maximized;

            foreach (string port in ports)
            {
                portList.Items.Add(port);
                SerialPort closer = new SerialPort(port);
                closer.Close();
            }

            controlGroup.Enabled = false;
        }

        private void hF80HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Help_Form().Show();
        }

        #region RadioButton handlers
        private void amModeButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radio != null && amModeButton.Checked)
            {
                radio.SetMode(Radio.MODE_AM);
                currentMode = Radio.MODE_AM;
            }
        }

        private void usbModeButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radio != null && usbModeButton.Checked)
            {
                radio.SetMode(Radio.MODE_USB);
                currentMode = Radio.MODE_USB;
            }
        }

        private void lsbModeButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radio != null && lsbModeButton.Checked)
            {
                radio.SetMode(Radio.MODE_LSB);
                currentMode = Radio.MODE_LSB;
            }
        }

        private void isbModeButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radio != null && isbModeButton.Checked)
            {
                radio.SetMode(Radio.MODE_ISB);
                currentMode = Radio.MODE_ISB;
            }
        }
        #endregion

        private void button8_Click(object sender, EventArgs e)
        {
            
                String s = requests.SelectedItem.ToString();
            if(!s.Equals(null)) {
                if (s == "Get Frequency")
                {
                    if (sp.IsOpen)
                    {
                        sp.Write(freq_req, 0, 2);
                    }

                }
                else if (s == "Get Mode")
                {
                    if (sp.IsOpen)
                    {
                        sp.Write(mode_req, 0, 2);
                    }
                }
                else if (s == "Get Faults")
                {
                    if (sp.IsOpen)
                    {
                        //sp.Write(fault_req, 0, 2);
                    }

                }
            
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (sp.IsOpen)
            {
                sp.Write(set_freq, 0, 5);
            }
        }

        /* Transmit! */
        private void txButton_Click(object sender, EventArgs e)
        {

        }


        /* Print to the output window */
        public void Print(String s)
        {
            printBox.AppendText(s + "\n");
        }

        private void setFreqButton_Click(object sender, EventArgs e)
        {
            byte[] response = radio.GetStatus(2);
            int i = 4;
        }
        
    }
    

}


