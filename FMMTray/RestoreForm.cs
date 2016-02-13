using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace IATray
{
    public partial class RestoreForm : Form
    {
        
        public RestoreForm()
        {
            InitializeComponent();
        }

        private void RestoreForm_Load(object sender, EventArgs e)
        {

            
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            listView.Items.Clear();
            foreach (DriveInfo d in allDrives)
            {
                if (d.DriveType == DriveType.Removable)
                {
                    if (d.IsReady == true)
                    {

                        DriveBackup db = new DriveBackup(d.Name);
                        BackupManager.DriveList.Add(db);
                        BackupManager.CurrentDB = db;
                        db.Init();
                        db.VolumeLabel = d.VolumeLabel;
                        db.TotalSize = d.TotalSize;
                        db.TotalFreeSpace = d.TotalFreeSpace;

                        db.ReadBackups();
                        List<BackupItem> blist = db.BackupList;
                        foreach (BackupItem bi in blist)
                        {
                            ListViewItem lvi = new ListViewItem(bi.DriveID);
                            lvi.SubItems.Add(bi.timeStamp.ToString());
                            lvi.SubItems.Add(bi.type.ToString());
                            lvi.SubItems.Add(bi.Description);
                            lvi.Tag = bi;
                            listView.Items.Add(lvi);
                        }
                    }
                }
            }
         
        }

        private void listView_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = listView.SelectedItems[0];

            JounalContentsForm form = new JounalContentsForm("C:\\");
            form.ShowDialog();
        }
    }
}