using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IATray
{
    public partial class BackupForm : Form
    {
        private DriveBackup currentDrive;

        public BackupForm(DriveBackup db)
        {
            InitializeComponent();
            currentDrive = db;
        }

        private void labelInfoOnNewDrive_Click(object sender, EventArgs e)
        {

        }
        public String DriveLabel
        {
            get { return textBoxDriveLabel.Text; }
            set { textBoxDriveLabel.Text = value; }
        }
        public bool DriveLabelReadOnly
        {
            get { return textBoxDriveLabel.ReadOnly; }
            set { textBoxDriveLabel.ReadOnly = value; }
        }

        private void BackupForm_Load(object sender, EventArgs e)
        {
            labelDriveID.Text = currentDrive.DriveID;
        }

        private void buttonFullBackup_Click(object sender, EventArgs e)
        {
           
            if (BackupManager.CurrentDB.DriveID == null)
            {
                NeedsDriveIDForm form = new NeedsDriveIDForm();

                if (form.ShowDialog() == DialogResult.OK)
                {
                    BackupManager.CurrentDB.DriveID = form.DriveID;
                }
                DriveBackup.WriteDriveID(BackupManager.CurrentDB.DriveLetter, BackupManager.CurrentDB.DriveID);
            }
            ProcessingBakupForm processingBakupForm = new ProcessingBakupForm(BackupManager.CurrentDB.DriveLetter, BackupManager.CurrentDB.DriveID);
            processingBakupForm.Closed += new EventHandler(child_Closed);
            processingBakupForm.Show();
            MainForm.ProcessList.Add(processingBakupForm);
            Close();
        }

        void child_Closed(object sender, EventArgs e)
        {
        }
    }
}