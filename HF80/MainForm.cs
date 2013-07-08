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
        String port_name;
        
        SerialPort sp;
        bool is_connected=false;
        float frequency;
        String mode;
        Thread updateThread;
       
        Help_Form form2;
      
        public MainForm()
        {
            InitializeComponent();
        }

        private void b_transmit_Click(object sender, EventArgs e)
        {
            
          // sp.Open();
            //sp.Write("HELLO");
          // label1.Text = sp.ReadLine();
           //sp.Close();
           /* Thread read_thread = new Thread(new ThreadStart(this.readSerial));
            if (read_thread.IsAlive)
            {
            }
            else {
                read_thread.Start();
            } */
           
          
          
           
           
        }

        public void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

       

        private void b_connect_Click(object sender, EventArgs e)
        {
            if (is_connected==false)
            {
                if (port_list.SelectedIndex != -1)
                {
                    port_name = port_list.SelectedItem.ToString();
                    label1.Text = port_name;
                    sp = new SerialPort(port_name, 9600);
                    sp.Open();
                    if (sp.IsOpen)
                    {
                        conn_ind.BackColor = Color.LimeGreen;
                    }
                    else
                    {
                        conn_ind.BackColor = Color.Red;
                    }
                    b_connect.Text = "Stop";
                    is_connected = true;
                }
            }
            else
            {
                sp.Close();
                b_connect.Text = "Connect";
                conn_ind.BackColor = Color.Red;
                is_connected = false;
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn_ind.BackColor = Color.White;
            String[] ports = SerialPort.GetPortNames();
            conn_ind.BackColor = Color.Red;
            //  WindowState = System.Windows.Forms.FormWindowState.Maximized;

            foreach (string port in ports)
            {
                port_list.Items.Add(port);
                SerialPort closer = new SerialPort(port);
                closer.Close();
            }
        }
        private void readSerial()
        {
            while (true)
            {
               this.textBox1.AppendText(sp.ReadLine() + "\n");
            }
        }
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                this.Close();

              
            }

            MessageBox.Show(e.KeyChar.ToString(), "Your input");

        }


        private void rb_am_CheckedChanged(object sender, EventArgs e)
        {
            mode = "AM";
            label1.Text = mode;
            if (sp.IsOpen)
            {
                sp.Write(set_mode_am, 0, 5);
            }
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void hF80HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
             form2 = new Help_Form();
            form2.Show();
        }

        private void rb_usb_CheckedChanged(object sender, EventArgs e)
        {
            mode = "USB";
            label1.Text = mode;
            if (sp.IsOpen)
            {
                sp.Write(set_mode_ssb, 0, 5);
            }
        }

        private void rb_lsb_CheckedChanged(object sender, EventArgs e)
        {
            mode = "LSB";
            label1.Text = mode;
            if (sp.IsOpen)
            {
                sp.Write(set_mode_ssb, 0, 5);
            }
        }

        private void rb_cw_CheckedChanged(object sender, EventArgs e)
        {
            mode = "CW";
            label1.Text = mode;
            if (sp.IsOpen)
            {
                sp.Write(set_mode_cw, 0, 5);
            }
        }

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
                if (is_connected == false)
                {

                    MessageBox.Show("No Serial Port Connected", "Serial Error");
                }
                if (is_connected == true)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        
    }
    

}


