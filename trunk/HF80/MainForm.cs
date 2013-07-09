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
        String mode;
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
                        isConnected = true;
                        controlGroup.Enabled = true;
                    }

                    else
                    {
                        MessageBox.Show("Could not connect to " + port + "!", "Serial Port Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                radio.Close();
                connectButton.Text = "Connect";
                connIndicator.BackColor = Color.Red;
                isConnected = false;
                controlGroup.Enabled = false;
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


        private void readSerial()
        {
            while (true)
            {
               this.textBox1.AppendText(sp.ReadLine() + "\n");
            }
        }


        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void hF80HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Help_Form().Show();
        }

        #region RadioButton handlers
        private void amModeButton_CheckedChanged(object sender, EventArgs e)
        {
            mode = "AM";
            label1.Text = mode;
            if (sp.IsOpen)
            {
                sp.Write(set_mode_am, 0, 5);
            }
        }

        private void usbModeButton_CheckedChanged(object sender, EventArgs e)
        {
            mode = "USB";
            label1.Text = mode;
            if (sp.IsOpen)
            {
                sp.Write(set_mode_ssb, 0, 5);
            }
        }

        private void lsbModeButton_CheckedChanged(object sender, EventArgs e)
        {
            mode = "LSB";
            label1.Text = mode;
            if (sp.IsOpen)
            {
                sp.Write(set_mode_ssb, 0, 5);
            }
        }

        private void isbModeButton_CheckedChanged(object sender, EventArgs e)
        {
            mode = "CW";
            label1.Text = mode;
            if (sp.IsOpen)
            {
                sp.Write(set_mode_cw, 0, 5);
            }
        }
        #endregion

        private void button7_Click(object sender, EventArgs e)
        {
            //sp.Write(textBox2.Text.ToString());
            String name = button7.Text.ToString();
            if (name == "Start Debug")
            {
                button7.Text = "Stop Debug";
                Form tf = new MainForm();
                
                updateThread = new Thread(new ThreadStart(this.updateDebug));
                updateThread.Start();
            }
            else if (name == "Stop Debug")
            {
                button7.Text = "Start Debug";
                updateThread.Abort();
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            incfreq(c_freq.Text, 0,1);
        }

        private void incfreq(String s, int inc, int amt)
        {
            if (inc == 0)
            {
                String[] spl = s.Split('.');
                String sf = spl[0];
                int f = Convert.ToInt32(sf);
                f = f + amt;
                sf = f.ToString() + "." + spl[1] + "." + spl[2];
                c_freq.Text = sf;
            }
            else if (inc == 1)
            {
                String[] spl = s.Split('.');
                String sf = spl[1];
                int f = Convert.ToInt32(sf);
                f = f + amt;
                sf = spl[0] + "." + f.ToString() + "." + spl[2];
                c_freq.Text = sf;
            }
            else if (inc == 2)
            {
                String[] spl = s.Split('.');
                String sf = spl[2];
                int f = Convert.ToInt32(sf);
                f = f + amt;
                sf = spl[0] + "." + spl[1] + "." + f.ToString();
                c_freq.Text = sf;
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            incfreq(c_freq.Text, 1,100);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            incfreq(c_freq.Text, 2,100);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            incfreq(c_freq.Text, 0, -1); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            incfreq(c_freq.Text, 1, -100); 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            incfreq(c_freq.Text, 2, -100); 
        }

        private void requests_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void updateDebug()
        {
            while (1==1)
            {
                if (isConnected == false)
                {

                    MessageBox.Show("No Serial Port Connected", "Serial Error");
                }
                if (isConnected == true)
                {
                    if (sp.ReadLine() != null)
                    {
                        this.Invoke((MethodInvoker)delegate
                        {
                            textBox1.AppendText(sp.ReadLine() + "\n");
                        });
                    }
                    else { }
                }
                Thread.Sleep(100);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
                String s = requests.SelectedItem.ToString();
            if(!s.Equals(null)) {
                if (s == "Get Frequency")
                {
                    if (sp.IsOpen)
                    {
                        sp.Write(freq_req, 0, 2);
                        textBox1.Text = sp.ReadLine();
                    }

                }
                else if (s == "Get Mode")
                {
                    if (sp.IsOpen)
                    {
                        sp.Write(mode_req, 0, 2);
                        textBox1.Text = sp.ReadLine();
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
        
    }
    

}


