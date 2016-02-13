using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IATray
{
    public partial class AddFavoritesForm : Form
    {
        private Favorite favorite = null;

        public AddFavoritesForm(Favorite f)
        {
            InitializeComponent();
            favorite = f;
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = textBoxFolder.Text;
            DialogResult res = folderBrowserDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                textBoxFolder.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        public Favorite Favorite { get { return favorite; } }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            favorite.name = textBoxName.Text;
            favorite.folder = textBoxFolder.Text;
            favorite.recursive = radioButtonRecursive.Checked;
        }
    }
}