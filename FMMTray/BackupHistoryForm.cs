using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IATray
{
    public partial class BackupHistoryForm : Form
    {
        DriveBackup driveBackup = null;
        public BackupHistoryForm(DriveBackup db)
        {
            driveBackup = db;
            InitializeComponent();
        }

        private void BackupHistoryForm_Load(object sender, EventArgs e)
        {
            driveBackup.ReadBackups();
            List<BackupItem> blist = driveBackup.BackupList;
            listView.Items.Clear();
            foreach (BackupItem bi in blist)
            {
                ListViewItem lvi = new ListViewItem(bi.timeStamp.ToString());
                lvi.SubItems.Add(bi.type.ToString());
                lvi.SubItems.Add(bi.Description);
                lvi.Tag = bi;
                listView.Items.Add(lvi);
            }
        }

        private void listView_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem lvi = listView.SelectedItems[0];
            BackupItem bi = (BackupItem)lvi.Tag;
            
            String fullFolderPath = BackupManager.LibraryLocationPath + "\\" + bi.DriveID
                                + "\\" + bi.FolderName + "\\data";
            try
            {
                System.Diagnostics.Process.Start(fullFolderPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening explorer: " + ex.Message, "Flash Memory Manager 1.0");
            }
        }
    }
}