namespace HF80
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.b_transmit = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hF80HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.connection_box = new System.Windows.Forms.GroupBox();
            this.port_list = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.conn_ind = new System.Windows.Forms.MaskedTextBox();
            this.b_connect = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.c_freq = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rb_am = new System.Windows.Forms.RadioButton();
            this.rb_cw = new System.Windows.Forms.RadioButton();
            this.rb_lsb = new System.Windows.Forms.RadioButton();
            this.rb_usb = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.d_freq = new System.Windows.Forms.Label();
            this.requests = new System.Windows.Forms.ListBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.connection_box.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // b_transmit
            // 
            this.b_transmit.Cursor = System.Windows.Forms.Cursors.Default;
            this.b_transmit.Location = new System.Drawing.Point(445, 575);
            this.b_transmit.Name = "b_transmit";
            this.b_transmit.Size = new System.Drawing.Size(143, 47);
            this.b_transmit.TabIndex = 0;
            this.b_transmit.Text = "Transmit";
            this.b_transmit.UseVisualStyleBackColor = true;
            this.b_transmit.Click += new System.EventHandler(this.b_transmit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1243, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(171, 24);
            this.settingsToolStripMenuItem.Text = "Settings...";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(171, 24);
            this.closeToolStripMenuItem.Text = "Close ";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hF80HelpToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // hF80HelpToolStripMenuItem
            // 
            this.hF80HelpToolStripMenuItem.Name = "hF80HelpToolStripMenuItem";
            this.hF80HelpToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.hF80HelpToolStripMenuItem.Size = new System.Drawing.Size(178, 24);
            this.hF80HelpToolStripMenuItem.Text = "HF-80 Help";
            this.hF80HelpToolStripMenuItem.Click += new System.EventHandler(this.hF80HelpToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(474, 516);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "(Mode)";
            // 
            // connection_box
            // 
            this.connection_box.BackColor = System.Drawing.SystemColors.Control;
            this.connection_box.Controls.Add(this.port_list);
            this.connection_box.Controls.Add(this.label2);
            this.connection_box.Controls.Add(this.conn_ind);
            this.connection_box.Controls.Add(this.b_connect);
            this.connection_box.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.connection_box.Location = new System.Drawing.Point(12, 31);
            this.connection_box.Name = "connection_box";
            this.connection_box.Size = new System.Drawing.Size(190, 216);
            this.connection_box.TabIndex = 4;
            this.connection_box.TabStop = false;
            this.connection_box.Text = "Connection";
            // 
            // port_list
            // 
            this.port_list.FormattingEnabled = true;
            this.port_list.ItemHeight = 16;
            this.port_list.Location = new System.Drawing.Point(36, 49);
            this.port_list.Name = "port_list";
            this.port_list.Size = new System.Drawing.Size(117, 100);
            this.port_list.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Port Name:";
            // 
            // conn_ind
            // 
            this.conn_ind.Location = new System.Drawing.Point(36, 188);
            this.conn_ind.Name = "conn_ind";
            this.conn_ind.ReadOnly = true;
            this.conn_ind.Size = new System.Drawing.Size(110, 22);
            this.conn_ind.TabIndex = 5;
            // 
            // b_connect
            // 
            this.b_connect.Location = new System.Drawing.Point(46, 155);
            this.b_connect.Name = "b_connect";
            this.b_connect.Size = new System.Drawing.Size(89, 27);
            this.b_connect.TabIndex = 4;
            this.b_connect.Text = "Connect";
            this.b_connect.UseVisualStyleBackColor = true;
            this.b_connect.Click += new System.EventHandler(this.b_connect_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(489, 629);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "(Space)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1066, 494);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox1.Size = new System.Drawing.Size(122, 98);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(219, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "MHz";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.c_freq);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.rb_am);
            this.groupBox1.Controls.Add(this.rb_cw);
            this.groupBox1.Controls.Add(this.rb_lsb);
            this.groupBox1.Controls.Add(this.rb_usb);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(221, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(642, 216);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Radio Options";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(158, 181);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(37, 23);
            this.button5.TabIndex = 21;
            this.button5.Text = "v";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(158, 106);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(37, 23);
            this.button6.TabIndex = 20;
            this.button6.Text = "^";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(86, 181);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(37, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "v";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(86, 106);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(37, 23);
            this.button4.TabIndex = 18;
            this.button4.Text = "^";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(23, 181);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(37, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "v";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "^";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // c_freq
            // 
            this.c_freq.AutoSize = true;
            this.c_freq.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_freq.Location = new System.Drawing.Point(6, 132);
            this.c_freq.Name = "c_freq";
            this.c_freq.Size = new System.Drawing.Size(218, 46);
            this.c_freq.TabIndex = 15;
            this.c_freq.Text = "14.200.000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(399, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Mode:";
            // 
            // rb_am
            // 
            this.rb_am.AutoSize = true;
            this.rb_am.Location = new System.Drawing.Point(286, 55);
            this.rb_am.Name = "rb_am";
            this.rb_am.Size = new System.Drawing.Size(49, 21);
            this.rb_am.TabIndex = 13;
            this.rb_am.TabStop = true;
            this.rb_am.Text = "AM";
            this.rb_am.UseVisualStyleBackColor = true;
            this.rb_am.CheckedChanged += new System.EventHandler(this.rb_am_CheckedChanged);
            // 
            // rb_cw
            // 
            this.rb_cw.AutoSize = true;
            this.rb_cw.Location = new System.Drawing.Point(520, 55);
            this.rb_cw.Name = "rb_cw";
            this.rb_cw.Size = new System.Drawing.Size(51, 21);
            this.rb_cw.TabIndex = 12;
            this.rb_cw.TabStop = true;
            this.rb_cw.Text = "CW";
            this.rb_cw.UseVisualStyleBackColor = true;
            this.rb_cw.CheckedChanged += new System.EventHandler(this.rb_cw_CheckedChanged);
            // 
            // rb_lsb
            // 
            this.rb_lsb.AutoSize = true;
            this.rb_lsb.Location = new System.Drawing.Point(443, 55);
            this.rb_lsb.Name = "rb_lsb";
            this.rb_lsb.Size = new System.Drawing.Size(55, 21);
            this.rb_lsb.TabIndex = 11;
            this.rb_lsb.TabStop = true;
            this.rb_lsb.Text = "LSB";
            this.rb_lsb.UseVisualStyleBackColor = true;
            this.rb_lsb.CheckedChanged += new System.EventHandler(this.rb_lsb_CheckedChanged);
            // 
            // rb_usb
            // 
            this.rb_usb.AutoSize = true;
            this.rb_usb.Location = new System.Drawing.Point(364, 55);
            this.rb_usb.Name = "rb_usb";
            this.rb_usb.Size = new System.Drawing.Size(57, 21);
            this.rb_usb.TabIndex = 10;
            this.rb_usb.TabStop = true;
            this.rb_usb.Text = "USB";
            this.rb_usb.UseVisualStyleBackColor = true;
            this.rb_usb.CheckedChanged += new System.EventHandler(this.rb_usb_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Frequency:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1077, 474);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Debug Monitor";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1080, 598);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(91, 22);
            this.textBox2.TabIndex = 11;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(1071, 626);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(107, 23);
            this.button7.TabIndex = 12;
            this.button7.Text = "Start Debug";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // d_freq
            // 
            this.d_freq.AutoSize = true;
            this.d_freq.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d_freq.Location = new System.Drawing.Point(284, 413);
            this.d_freq.Name = "d_freq";
            this.d_freq.Size = new System.Drawing.Size(435, 91);
            this.d_freq.TabIndex = 13;
            this.d_freq.Text = "14.200.000";
            // 
            // requests
            // 
            this.requests.FormattingEnabled = true;
            this.requests.ItemHeight = 16;
            this.requests.Items.AddRange(new object[] {
            "Get Frequency",
            "Get Mode",
            "Get Faults"});
            this.requests.Location = new System.Drawing.Point(928, 494);
            this.requests.Name = "requests";
            this.requests.Size = new System.Drawing.Size(120, 100);
            this.requests.TabIndex = 14;
            this.requests.SelectedIndexChanged += new System.EventHandler(this.requests_SelectedIndexChanged);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(928, 623);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(120, 26);
            this.button8.TabIndex = 15;
            this.button8.Text = "Get Requests";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(1001, 310);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(170, 23);
            this.button9.TabIndex = 16;
            this.button9.Text = "Set to 14.200 Mz";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 675);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.requests);
            this.Controls.Add(this.d_freq);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.connection_box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b_transmit);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HF-80 Interface Software";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.connection_box.ResumeLayout(false);
            this.connection_box.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_transmit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hF80HelpToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox connection_box;
        private System.Windows.Forms.Button b_connect;
        private System.Windows.Forms.MaskedTextBox conn_ind;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox port_list;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rb_am;
        private System.Windows.Forms.RadioButton rb_cw;
        private System.Windows.Forms.RadioButton rb_lsb;
        private System.Windows.Forms.RadioButton rb_usb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label c_freq;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label d_freq;
        private System.Windows.Forms.ListBox requests;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
    }
}

