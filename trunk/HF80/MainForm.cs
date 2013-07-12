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
        /* Instance variables belonging to MainForm */
        private Radio radio;
        bool isConnected=false;
        bool isKeyed = false;
        int currentMode;
      

        /* Public constructor */
        public MainForm()
        {
            InitializeComponent();
        }


        private void connectButton_Click(object sender, EventArgs e)
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
                        connectButton.Text = "Disconnect";
                        radio.onPrint += this.Print;
                        isConnected = true;
                        controlGroup.Enabled = true;

                        /* Set the initial settings of the radio */
                        amModeButton.PerformClick();
                        frequencyEdit.Frequency = 14200000;
                        setFreqButton.PerformClick();
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
                if(radio != null)
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
        private void MainForm_Load(object sender, EventArgs e)
        {
            /* Add keypress event handlers */
            this.KeyPreview = true;
            this.KeyDown += KeyDownTX;
            this.KeyUp += KeyUpTX;

            byte[] d = Message.GetFrequencyMessage(14200000);
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
            txLabel.BackColor = Color.Green;
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
                SetMode(Radio.MODE_AM);
            }
        }

        private void usbModeButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radio != null && usbModeButton.Checked)
            {
                SetMode(Radio.MODE_USB);
            }
        }

        private void lsbModeButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radio != null && lsbModeButton.Checked)
            {
                SetMode(Radio.MODE_LSB);
            }
        }

        private void isbModeButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radio != null && isbModeButton.Checked)
            {
                SetMode(Radio.MODE_ISB);
            }
        }
        #endregion


        /* Set the mode of the radio object */
        public void SetMode(int mode)
        {
            if (radio != null)
            {
                bool success = radio.SetMode(mode);

                if (success)
                {
                    Print("Changed mode to " + mode);
                    this.currentMode = mode;
                }
                else
                {
                    Print("Failed to change mode to " + mode);
                }
            }
        }

        /* Transmit! */
        private void txButton_Click(object sender, EventArgs e)
        {
            if (radio != null)
            {
                bool success = radio.SetTX(true);

                if (success)
                    Print("TX turned ON");
                else
                    Print("TX turn ON failed!");
            }
        }


        /* Print to the output window */
        public void Print(String s)
        {
            printBox.AppendText(s + "\n");
        }

        private void setFreqButton_Click(object sender, EventArgs e)
        {
            int freq = (int)frequencyEdit.Frequency;

            if (radio != null)
            {
                bool success = radio.SetFrequency(freq);

                if (success)
                    Print("Frequency changed to " + freq);
                else
                    Print("Failed to changed frequency to " + freq);
            }
        }


        /* Called when a key is down */
        /* Key the transmitter based on the status of the space bar */
        void KeyDownTX(Object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.T && !isKeyed)
            {
                Print("TX down!");
                radio.SetTX(true);
                isKeyed = true;
                txLabel.Text = "TX";
                txLabel.BackColor = Color.Red;
            }
        }

        /* Called when a key is down */
        /* Key the transmitter based on the status of the space bar */
        void KeyUpTX(Object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.T && isKeyed)
            {
                Print("TX up!");
                radio.SetTX(false);
                isKeyed = false;
                txLabel.Text = "RX";
                txLabel.BackColor = Color.Green;
            }
        }
        
    }
    

}


