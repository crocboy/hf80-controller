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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hF80HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionGroup = new System.Windows.Forms.GroupBox();
            this.portList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.connIndicator = new System.Windows.Forms.MaskedTextBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.amModeButton = new System.Windows.Forms.RadioButton();
            this.isbModeButton = new System.Windows.Forms.RadioButton();
            this.lsbModeButton = new System.Windows.Forms.RadioButton();
            this.usbModeButton = new System.Windows.Forms.RadioButton();
            this.controlGroup = new System.Windows.Forms.GroupBox();
            this.txLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.printBox = new System.Windows.Forms.TextBox();
            this.setFreqButton = new System.Windows.Forms.Button();
            this.frequencyEdit = new SDRSharp.FrequencyEdit.FrequencyEdit();
            this.menuStrip1.SuspendLayout();
            this.connectionGroup.SuspendLayout();
            this.controlGroup.SuspendLayout();
            this.SuspendLayout();
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
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.closeToolStripMenuItem.Text = "Close ";
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
            this.connectionGroup.Size = new System.Drawing.Size(142, 182);
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
            this.connIndicator.Size = new System.Drawing.Size(89, 20);
            this.connIndicator.TabIndex = 5;
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(27, 126);
            this.connectButton.Margin = new System.Windows.Forms.Padding(2);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(89, 22);
            this.connectButton.TabIndex = 4;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(266, 38);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Mode:";
            // 
            // amModeButton
            // 
            this.amModeButton.AutoSize = true;
            this.amModeButton.Location = new System.Drawing.Point(195, 59);
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
            this.isbModeButton.Location = new System.Drawing.Point(291, 59);
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
            this.lsbModeButton.Location = new System.Drawing.Point(337, 59);
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
            this.usbModeButton.Location = new System.Drawing.Point(240, 59);
            this.usbModeButton.Margin = new System.Windows.Forms.Padding(2);
            this.usbModeButton.Name = "usbModeButton";
            this.usbModeButton.Size = new System.Drawing.Size(47, 17);
            this.usbModeButton.TabIndex = 10;
            this.usbModeButton.TabStop = true;
            this.usbModeButton.Text = "USB";
            this.usbModeButton.UseVisualStyleBackColor = true;
            this.usbModeButton.CheckedChanged += new System.EventHandler(this.usbModeButton_CheckedChanged);
            // 
            // controlGroup
            // 
            this.controlGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.controlGroup.Controls.Add(this.txLabel);
            this.controlGroup.Controls.Add(this.label1);
            this.controlGroup.Controls.Add(this.label5);
            this.controlGroup.Controls.Add(this.label4);
            this.controlGroup.Controls.Add(this.printBox);
            this.controlGroup.Controls.Add(this.label6);
            this.controlGroup.Controls.Add(this.setFreqButton);
            this.controlGroup.Controls.Add(this.amModeButton);
            this.controlGroup.Controls.Add(this.frequencyEdit);
            this.controlGroup.Controls.Add(this.isbModeButton);
            this.controlGroup.Controls.Add(this.lsbModeButton);
            this.controlGroup.Controls.Add(this.usbModeButton);
            this.controlGroup.Location = new System.Drawing.Point(156, 27);
            this.controlGroup.Name = "controlGroup";
            this.controlGroup.Size = new System.Drawing.Size(764, 509);
            this.controlGroup.TabIndex = 17;
            this.controlGroup.TabStop = false;
            this.controlGroup.Text = "Control";
            // 
            // txLabel
            // 
            this.txLabel.AutoSize = true;
            this.txLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txLabel.Location = new System.Drawing.Point(261, 244);
            this.txLabel.Name = "txLabel";
            this.txLabel.Size = new System.Drawing.Size(47, 29);
            this.txLabel.TabIndex = 23;
            this.txLabel.Text = "RX";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Press \'T\' to Transmit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(359, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "MHz";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(605, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Debug Monitor";
            // 
            // printBox
            // 
            this.printBox.Location = new System.Drawing.Point(532, 265);
            this.printBox.Multiline = true;
            this.printBox.Name = "printBox";
            this.printBox.ReadOnly = true;
            this.printBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.printBox.Size = new System.Drawing.Size(226, 238);
            this.printBox.TabIndex = 19;
            // 
            // setFreqButton
            // 
            this.setFreqButton.Location = new System.Drawing.Point(227, 124);
            this.setFreqButton.Name = "setFreqButton";
            this.setFreqButton.Size = new System.Drawing.Size(106, 23);
            this.setFreqButton.TabIndex = 18;
            this.setFreqButton.Text = "Set Frequency";
            this.setFreqButton.UseVisualStyleBackColor = true;
            this.setFreqButton.Click += new System.EventHandler(this.setFreqButton_Click);
            // 
            // frequencyEdit
            // 
            this.frequencyEdit.AutoSize = true;
            this.frequencyEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.frequencyEdit.BackColor = System.Drawing.Color.Transparent;
            this.frequencyEdit.Frequency = ((long)(0));
            this.frequencyEdit.Location = new System.Drawing.Point(170, 153);
            this.frequencyEdit.Name = "frequencyEdit";
            this.frequencyEdit.Size = new System.Drawing.Size(183, 25);
            this.frequencyEdit.StepSize = 0;
            this.frequencyEdit.TabIndex = 17;
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
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.connectionGroup.ResumeLayout(false);
            this.connectionGroup.PerformLayout();
            this.controlGroup.ResumeLayout(false);
            this.controlGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hF80HelpToolStripMenuItem;
        private System.Windows.Forms.GroupBox connectionGroup;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.MaskedTextBox connIndicator;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox portList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton amModeButton;
        private System.Windows.Forms.RadioButton isbModeButton;
        private System.Windows.Forms.RadioButton lsbModeButton;
        private System.Windows.Forms.RadioButton usbModeButton;
        private System.Windows.Forms.GroupBox controlGroup;
        private SDRSharp.FrequencyEdit.FrequencyEdit frequencyEdit;
        private System.Windows.Forms.Button setFreqButton;
        private System.Windows.Forms.TextBox printBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txLabel;
    }
}

