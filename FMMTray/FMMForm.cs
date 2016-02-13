using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IATray
{
    public partial class FMMForm : Form
    {
        public FMMForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonBackup_Click(object sender, EventArgs e)
        {
            BackupFavoritesForm from = new BackupFavoritesForm();
            from.ShowDialog();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddFavoritesForm form = new AddFavoritesForm(new Favorite());
            if (form.ShowDialog() == DialogResult.OK)
            {
                BackupManager.FavoritesList.Add(form.Favorite);
                ListViewItem lvi = new ListViewItem(form.Favorite.name);
                lvi.SubItems[0].Text = form.Favorite.folder;
                //lvi.SubItems[1].Text = form.Favorite.recursive.ToString();
                listViewFavorites.Items.Add(lvi);
            }
        }

        private void FMMForm_Load(object sender, EventArgs e)
        {
            foreach (Favorite f in BackupManager.FavoritesList)
            {
                ListViewItem lvi = new ListViewItem(f.name);
                lvi.SubItems[0].Text = f.folder;
                lvi.SubItems[1].Text = f.recursive.ToString();
                listViewFavorites.Items.Add(lvi);
            }
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            // Write all to registory
        }
    }
}