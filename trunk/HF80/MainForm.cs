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

        /* "Connect" button was clicked */
        private void connectButton_Click(object sender, EventArgs e)
        {
            String port;

            /* We're not connected, attempt to connect */
            if (!isConnected)
            {
                if (portList.SelectedIndex != -1)
                {
                    port = portList.SelectedItem.ToString();
                    Connect(port);
                }
            }

            /* We're already connected; so disconnect */
            else
            {
                Disconnect();
            }
        }

        /* Called when the form first loads */
        private void MainForm_Load(object sender, EventArgs e)
        {
            /* Add keypress event handlers */
            this.KeyPreview = true;
            this.KeyDown += KeyDownTX;
            this.KeyUp += KeyUpTX;

            connIndicator.BackColor = Color.White;
            String[] ports = SerialPort.GetPortNames();
            connIndicator.BackColor = Color.Red;

            foreach (string port in ports)
                portList.Items.Add(port);

            controlGroup.Enabled = false;
            txLabel.BackColor = Color.Green;
        }


        #region RadioButton handlers

        /* AM radio button pressed */
        private void amModeButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radio != null && amModeButton.Checked)
            {
                SetMode(Radio.MODE_AM);
            }
        }

        /* USB radio button pressed */
        private void usbModeButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radio != null && usbModeButton.Checked)
            {
                SetMode(Radio.MODE_USB);
            }
        }

        /* LSB radio button pressed */
        private void lsbModeButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radio != null && lsbModeButton.Checked)
            {
                SetMode(Radio.MODE_LSB);
            }
        }

        /* ISB radio button pressed */
        private void isbModeButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radio != null && isbModeButton.Checked)
            {
                SetMode(Radio.MODE_ISB);
            }
        }

        /* CW radio button pressed */
        private void cwModeButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radio != null && cwModeButton.Checked)
            {
                SetMode(Radio.MODE_CW);
            }
        }

        #endregion


        /* Set the transmission mode of the radio */
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


        /* Called when the local/remote state of the radio changes */
        private void OnLocalChanged(bool isLocal)
        {
            if (isLocal) // Local mode was enabled at the radio!
            {
                radio.ForceTX(false); // Force a key down in case the TX was keyed 
                Disconnect();
                MessageBox.Show("Radio was switched to local mode!  Disconnecting...");
            }
        }


        /* Connect to the radio and set up the GUI */
        private void Connect(String port)
        {
            radio = new Radio(port);

            bool connected = radio.Connect();

            if (connected)
            {
                connIndicator.BackColor = Color.LimeGreen;
                connectButton.Text = "Disconnect";
                radio.onPrint += this.Print;
                radio.onLocalChanged += this.OnLocalChanged;
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


        /* Disconnect and re-configure the GUI */
        private void Disconnect()
        {
            if (radio != null)
                radio.Disconnect();

            connectButton.Text = "Connect";
            connIndicator.BackColor = Color.Red;
            isConnected = false;
            controlGroup.Enabled = false;
            printBox.Clear();
            radio = null;
        }


        /* Clear button pressed */
        private void clearLogButton_Click(object sender, EventArgs e)
        {
            printBox.Clear();
        }

        /* Print to the debug output window */
        public void Print(String s)
        {
            printBox.AppendText(s + "\n");
        }

        /* Called when Set Frequency button is clicked */
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
                Print("TX  key down!");
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
                Print("TX key up!");
                radio.SetTX(false);
                isKeyed = false;
                txLabel.Text = "RX";
                txLabel.BackColor = Color.Green;
            }
        }

        /* LSB AGC box was clicked */
        private void lsbAgcBox_CheckedChanged(object sender, EventArgs e)
        {
            bool success = radio.SetLsbAgc(lsbAgcBox.Checked);
        }

        /* USB AGC box was clicked */
        private void usbAgcBox_CheckedChanged(object sender, EventArgs e)
        {
            bool success = radio.SetUsbAgc(usbAgcBox.Checked);
        }

        #region Menu Toolstrip Click Handlers

        /* "Help" option pressed */
        private void hF80HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Help_Form().Show();
        }

        /* File -> Disconnect pressed */
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(radio != null)
                radio.Disconnect();

            Application.Exit();
        }

        /* File -> Restart was clicked */
        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        #endregion
    }
}