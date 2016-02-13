using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IATray
{
    public partial class NeedsDriveIDForm : Form
    {
        

        public NeedsDriveIDForm()
        {
            InitializeComponent();
            
        }

        public String DriveID
        {
            get { return textBoxDriveLabel.Text; }
            set { textBoxDriveLabel.Text = value; }
        }
    }
}