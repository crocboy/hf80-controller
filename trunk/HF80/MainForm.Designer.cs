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
            this.txButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hF80HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.connectionGroup = new System.Windows.Forms.GroupBox();
            this.portList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.connIndicator = new System.Windows.Forms.MaskedTextBox();
            this.connectButton = new System.Windows.Forms.Button();
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
            this.amModeButton = new System.Windows.Forms.RadioButton();
            this.isbModeButton = new System.Windows.Forms.RadioButton();
            this.lsbModeButton = new System.Windows.Forms.RadioButton();
            this.usbModeButton = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.requests = new System.Windows.Forms.ListBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.controlGroup = new System.Windows.Forms.GroupBox();
            this.frequencyEdit1 = new SDRSharp.FrequencyEdit.FrequencyEdit();
            this.menuStrip1.SuspendLayout();
            this.connectionGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.controlGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // txButton
            // 
            this.txButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.txButton.Location = new System.Drawing.Point(233, 443);
            this.txButton.Margin = new System.Windows.Forms.Padding(2);
            this.txButton.Name = "txButton";
            this.txButton.Size = new System.Drawing.Size(107, 38);
            this.txButton.TabIndex = 0;
            this.txButton.Text = "Transmit";
            this.txButton.UseVisualStyleBackColor = true;
            this.txButton.Click += new System.EventHandler(this.txButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(932, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.settingsToolStripMenuItem.Text = "Settings...";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.closeToolStripMenuItem.Text = "Close ";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hF80HelpToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // hF80HelpToolStripMenuItem
            // 
            this.hF80HelpToolStripMenuItem.Name = "hF80HelpToolStripMenuItem";
            this.hF80HelpToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.hF80HelpToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.hF80HelpToolStripMenuItem.Text = "HF-80 Help";
            this.hF80HelpToolStripMenuItem.Click += new System.EventHandler(this.hF80HelpToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(254, 421);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "(Mode)";
            // 
            // connectionGroup
            // 
            this.connectionGroup.BackColor = System.Drawing.SystemColors.Control;
            this.connectionGroup.Controls.Add(this.portList);
            this.connectionGroup.Controls.Add(this.label2);
            this.connectionGroup.Controls.Add(this.connIndicator);
            this.connectionGroup.Controls.Add(this.connectButton);
            this.connectionGroup.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.connectionGroup.Location = new System.Drawing.Point(9, 25);
            this.connectionGroup.Margin = new System.Windows.Forms.Padding(2);
            this.connectionGroup.Name = "connectionGroup";
            this.connectionGroup.Padding = new System.Windows.Forms.Padding(2);
            this.connectionGroup.Size = new System.Drawing.Size(142, 176);
            this.connectionGroup.TabIndex = 4;
            this.connectionGroup.TabStop = false;
            this.connectionGroup.Text = "Connection";
            // 
            // portList
            // 
            this.portList.FormattingEnabled = true;
            this.portList.Location = new System.Drawing.Point(27, 40);
            this.portList.Margin = new System.Windows.Forms.Padding(2);
            this.portList.Name = "portList";
            this.portList.Size = new System.Drawing.Size(89, 82);
            this.portList.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Port Name:";
            // 
            // connIndicator
            // 
            this.connIndicator.Location = new System.Drawing.Point(27, 153);
            this.connIndicator.Margin = new System.Windows.Forms.Padding(2);
            this.connIndicator.Name = "connIndicator";
            this.connIndicator.ReadOnly = true;
            this.connIndicator.Size = new System.Drawing.Size(84, 20);
            this.connIndicator.TabIndex = 5;
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(34, 126);
            this.connectButton.Margin = new System.Windows.Forms.Padding(2);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(67, 22);
            this.connectButton.TabIndex = 4;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.b_connect_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 487);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "(Space)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(662, 376);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox1.Size = new System.Drawing.Size(92, 80);
            this.textBox1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(164, 121);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
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
            this.groupBox1.Controls.Add(this.amModeButton);
            this.groupBox1.Controls.Add(this.isbModeButton);
            this.groupBox1.Controls.Add(this.lsbModeButton);
            this.groupBox1.Controls.Add(this.usbModeButton);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(20, 28);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(482, 176);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Radio Options";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(118, 147);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(28, 19);
            this.button5.TabIndex = 21;
            this.button5.Text = "v";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(118, 86);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(28, 19);
            this.button6.TabIndex = 20;
            this.button6.Text = "^";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(64, 147);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(28, 19);
            this.button3.TabIndex = 19;
            this.button3.Text = "v";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(64, 86);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(28, 19);
            this.button4.TabIndex = 18;
            this.button4.Text = "^";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(17, 147);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 19);
            this.button2.TabIndex = 17;
            this.button2.Text = "v";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 86);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 19);
            this.button1.TabIndex = 16;
            this.button1.Text = "^";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // c_freq
            // 
            this.c_freq.AutoSize = true;
            this.c_freq.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_freq.Location = new System.Drawing.Point(4, 107);
            this.c_freq.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.c_freq.Name = "c_freq";
            this.c_freq.Size = new System.Drawing.Size(177, 37);
            this.c_freq.TabIndex = 15;
            this.c_freq.Text = "14.200.000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(299, 24);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Mode:";
            // 
            // amModeButton
            // 
            this.amModeButton.AutoSize = true;
            this.amModeButton.Location = new System.Drawing.Point(214, 45);
            this.amModeButton.Margin = new System.Windows.Forms.Padding(2);
            this.amModeButton.Name = "amModeButton";
            this.amModeButton.Size = new System.Drawing.Size(41, 17);
            this.amModeButton.TabIndex = 13;
            this.amModeButton.TabStop = true;
            this.amModeButton.Text = "AM";
            this.amModeButton.UseVisualStyleBackColor = true;
            this.amModeButton.CheckedChanged += new System.EventHandler(this.amModeButton_CheckedChanged);
            // 
            // isbModeButton
            // 
            this.isbModeButton.AutoSize = true;
            this.isbModeButton.Location = new System.Drawing.Point(324, 45);
            this.isbModeButton.Margin = new System.Windows.Forms.Padding(2);
            this.isbModeButton.Name = "isbModeButton";
            this.isbModeButton.Size = new System.Drawing.Size(42, 17);
            this.isbModeButton.TabIndex = 12;
            this.isbModeButton.TabStop = true;
            this.isbModeButton.Text = "ISB";
            this.isbModeButton.UseVisualStyleBackColor = true;
            this.isbModeButton.CheckedChanged += new System.EventHandler(this.isbModeButton_CheckedChanged);
            // 
            // lsbModeButton
            // 
            this.lsbModeButton.AutoSize = true;
            this.lsbModeButton.Location = new System.Drawing.Point(370, 45);
            this.lsbModeButton.Margin = new System.Windows.Forms.Padding(2);
            this.lsbModeButton.Name = "lsbModeButton";
            this.lsbModeButton.Size = new System.Drawing.Size(45, 17);
            this.lsbModeButton.TabIndex = 11;
            this.lsbModeButton.TabStop = true;
            this.lsbModeButton.Text = "LSB";
            this.lsbModeButton.UseVisualStyleBackColor = true;
            this.lsbModeButton.CheckedChanged += new System.EventHandler(this.lsbModeButton_CheckedChanged);
            // 
            // usbModeButton
            // 
            this.usbModeButton.AutoSize = true;
            this.usbModeButton.Location = new System.Drawing.Point(273, 45);
            this.usbModeButton.Margin = new System.Windows.Forms.Padding(2);
            this.usbModeButton.Name = "usbModeButton";
            this.usbModeButton.Size = new System.Drawing.Size(47, 17);
            this.usbModeButton.TabIndex = 10;
            this.usbModeButton.TabStop = true;
            this.usbModeButton.Text = "USB";
            this.usbModeButton.UseVisualStyleBackColor = true;
            this.usbModeButton.CheckedChanged += new System.EventHandler(this.usbModeButton_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 57);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Frequency:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(670, 360);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Debug Monitor";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(672, 461);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(69, 20);
            this.textBox2.TabIndex = 11;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(665, 484);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(80, 19);
            this.button7.TabIndex = 12;
            this.button7.Text = "Start Debug";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // requests
            // 
            this.requests.FormattingEnabled = true;
            this.requests.Items.AddRange(new object[] {
            "Get Frequency",
            "Get Mode",
            "Get Faults"});
            this.requests.Location = new System.Drawing.Point(558, 376);
            this.requests.Margin = new System.Windows.Forms.Padding(2);
            this.requests.Name = "requests";
            this.requests.Size = new System.Drawing.Size(91, 82);
            this.requests.TabIndex = 14;
            this.requests.SelectedIndexChanged += new System.EventHandler(this.requests_SelectedIndexChanged);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(558, 481);
            this.button8.Margin = new System.Windows.Forms.Padding(2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(90, 21);
            this.button8.TabIndex = 15;
            this.button8.Text = "Get Requests";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(589, 323);
            this.button9.Margin = new System.Windows.Forms.Padding(2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(128, 19);
            this.button9.TabIndex = 16;
            this.button9.Text = "Set to 14.200 Mz";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // controlGroup
            // 
            this.controlGroup.Controls.Add(this.frequencyEdit1);
            this.controlGroup.Controls.Add(this.groupBox1);
            this.controlGroup.Controls.Add(this.button8);
            this.controlGroup.Controls.Add(this.button9);
            this.controlGroup.Controls.Add(this.requests);
            this.controlGroup.Controls.Add(this.button7);
            this.controlGroup.Controls.Add(this.textBox2);
            this.controlGroup.Controls.Add(this.label1);
            this.controlGroup.Controls.Add(this.label7);
            this.controlGroup.Controls.Add(this.txButton);
            this.controlGroup.Controls.Add(this.textBox1);
            this.controlGroup.Controls.Add(this.label3);
            this.controlGroup.Location = new System.Drawing.Point(156, 27);
            this.controlGroup.Name = "controlGroup";
            this.controlGroup.Size = new System.Drawing.Size(764, 509);
            this.controlGroup.TabIndex = 17;
            this.controlGroup.TabStop = false;
            this.controlGroup.Text = "Control";
            // 
            // frequencyEdit1
            // 
            this.frequencyEdit1.AutoSize = true;
            this.frequencyEdit1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.frequencyEdit1.BackColor = System.Drawing.Color.Transparent;
            this.frequencyEdit1.Frequency = ((long)(0));
            this.frequencyEdit1.Location = new System.Drawing.Point(179, 323);
            this.frequencyEdit1.Name = "frequencyEdit1";
            this.frequencyEdit1.Size = new System.Drawing.Size(234, 25);
            this.frequencyEdit1.StepSize = 0;
            this.frequencyEdit1.TabIndex = 17;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 548);
            this.Controls.Add(this.controlGroup);
            this.Controls.Add(this.connectionGroup);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HF-80 Interface Software";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.connectionGroup.ResumeLayout(false);
            this.connectionGroup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.controlGroup.ResumeLayout(false);
            this.controlGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button txButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hF80HelpToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox connectionGroup;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.MaskedTextBox connIndicator;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox portList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton amModeButton;
        private System.Windows.Forms.RadioButton isbModeButton;
        private System.Windows.Forms.RadioButton lsbModeButton;
        private System.Windows.Forms.RadioButton usbModeButton;
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
        private System.Windows.Forms.ListBox requests;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.GroupBox controlGroup;
        private SDRSharp.FrequencyEdit.FrequencyEdit frequencyEdit1;
    }
}

