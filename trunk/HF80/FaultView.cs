using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace HF80
{
    /// <summary>
    /// A custom view for viewing all of the HF80 Faults.
    /// </summary>
    public partial class FaultView : UserControl
    {
        /// <summary>
        /// Empty constructor required by WinForms.
        /// </summary>
        public FaultView()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Refresh the fault views.
        /// </summary>
        /// <param name="data">Raw fault-status message from the HF80.</param>
        public void SetFaults(byte[] data)
        {
            BitArray three = new BitArray(new byte[] { data[2] });
            BitArray four = new BitArray(new byte[] { data[3] });
            BitArray five = new BitArray(new byte[] { data[4] });
        }
    }
}
