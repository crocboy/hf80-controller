using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HF80
{
    public partial class Help_Form : Form
    {
        public Help_Form()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Help_Form_Load(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            String[] s = e.Node.ToString().Split(':');
            if (s[1].Trim().Equals("Credits"))
            {
                label2.Text = "CREEEEEDDDDIIIITTTTSSSSS!";
            }
            else
            {
                label2.Text = s[1];
            }

        }
    }
}
