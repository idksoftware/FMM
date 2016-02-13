namespace IATray
{
    partial class DriveForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DriveForm));
            this.label1 = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.ListView();
            this.chDriveLetter = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDriveID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chScanned = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageLstT = new System.Windows.Forms.ImageList(this.components);
            this.labelLastBackedUp = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonBackup = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelDateLastBackedUp = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelVolumeLabel = new System.Windows.Forms.Label();
            this.labelTotalAvailableSpace = new System.Windows.Forms.Label();
            this.labelTotalSizeOfDrive = new System.Windows.Forms.Label();
            this.labelNeedsBackingUp = new System.Windows.Forms.Label();
            this.buttonDriveID = new System.Windows.Forms.Button();
            this.groupBoxDriveID = new System.Windows.Forms.GroupBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.groupBoxDriveID.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Available Drives:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chDriveLetter,
            this.chDriveID,
            this.chScanned});
            this.listView.FullRowSelect = true;
            this.listView.Location = new System.Drawing.Point(15, 36);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(420, 124);
            this.listView.StateImageList = this.imageLstT;
            this.listView.TabIndex = 2;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            this.listView.DoubleClick += new System.EventHandler(this.listView_DoubleClick);
            // 
            // chDriveLetter
            // 
            this.chDriveLetter.Text = "Drive";
            this.chDriveLetter.Width = 42;
            // 
            // chDriveID
            // 
            this.chDriveID.Text = "Drive ID";
            this.chDriveID.Width = 108;
            // 
            // chScanned
            // 
            this.chScanned.Text = "Needs scanning";
            this.chScanned.Width = 104;
            // 
            // imageLstT
            // 
            this.imageLstT.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageLstT.ImageStream")));
            this.imageLstT.TransparentColor = System.Drawing.Color.Transparent;
            this.imageLstT.Images.SetKeyName(0, "Backedup.bmp");
            this.imageLstT.Images.SetKeyName(1, "NeedsBackup.bmp");
            // 
            // labelLastBackedUp
            // 
            this.labelLastBackedUp.AutoSize = true;
            this.labelLastBackedUp.Location = new System.Drawing.Point(12, 21);
            this.labelLastBackedUp.Name = "labelLastBackedUp";
            this.labelLastBackedUp.Size = new System.Drawing.Size(111, 13);
            this.labelLastBackedUp.TabIndex = 3;
            this.labelLastBackedUp.Text = "Date Last Backed up:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Volume Label:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Total available space:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Total size of drive::";
            // 
            // buttonBackup
            // 
            this.buttonBackup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBackup.Location = new System.Drawing.Point(352, 184);
            this.buttonBackup.Name = "buttonBackup";
            this.buttonBackup.Size = new System.Drawing.Size(83, 23);
            this.buttonBackup.TabIndex = 41;
            this.buttonBackup.Text = "&Backup";
            this.buttonBackup.UseVisualStyleBackColor = true;
            this.buttonBackup.Click += new System.EventHandler(this.buttonBackup_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(352, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 23);
            this.button1.TabIndex = 42;
            this.button1.Text = "&Close";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // labelDateLastBackedUp
            // 
            this.labelDateLastBackedUp.AutoSize = true;
            this.labelDateLastBackedUp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelDateLastBackedUp.Location = new System.Drawing.Point(129, 21);
            this.labelDateLastBackedUp.Name = "labelDateLastBackedUp";
            this.labelDateLastBackedUp.Size = new System.Drawing.Size(95, 13);
            this.labelDateLastBackedUp.TabIndex = 43;
            this.labelDateLastBackedUp.Text = "2010/03/10 12:23";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Needs Backing Up:";
            // 
            // labelVolumeLabel
            // 
            this.labelVolumeLabel.AutoSize = true;
            this.labelVolumeLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelVolumeLabel.Location = new System.Drawing.Point(129, 34);
            this.labelVolumeLabel.Name = "labelVolumeLabel";
            this.labelVolumeLabel.Size = new System.Drawing.Size(56, 13);
            this.labelVolumeLabel.TabIndex = 45;
            this.labelVolumeLabel.Text = "Nikon80-1";
            // 
            // labelTotalAvailableSpace
            // 
            this.labelTotalAvailableSpace.AutoSize = true;
            this.labelTotalAvailableSpace.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelTotalAvailableSpace.Location = new System.Drawing.Point(129, 47);
            this.labelTotalAvailableSpace.Name = "labelTotalAvailableSpace";
            this.labelTotalAvailableSpace.Size = new System.Drawing.Size(21, 13);
            this.labelTotalAvailableSpace.TabIndex = 46;
            this.labelTotalAvailableSpace.Text = "8G";
            // 
            // labelTotalSizeOfDrive
            // 
            this.labelTotalSizeOfDrive.AutoSize = true;
            this.labelTotalSizeOfDrive.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelTotalSizeOfDrive.Location = new System.Drawing.Point(129, 60);
            this.labelTotalSizeOfDrive.Name = "labelTotalSizeOfDrive";
            this.labelTotalSizeOfDrive.Size = new System.Drawing.Size(21, 13);
            this.labelTotalSizeOfDrive.TabIndex = 47;
            this.labelTotalSizeOfDrive.Text = "8G";
            // 
            // labelNeedsBackingUp
            // 
            this.labelNeedsBackingUp.AutoSize = true;
            this.labelNeedsBackingUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNeedsBackingUp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelNeedsBackingUp.Location = new System.Drawing.Point(129, 73);
            this.labelNeedsBackingUp.Name = "labelNeedsBackingUp";
            this.labelNeedsBackingUp.Size = new System.Drawing.Size(41, 13);
            this.labelNeedsBackingUp.TabIndex = 48;
            this.labelNeedsBackingUp.Text = "TRUE";
            // 
            // buttonDriveID
            // 
            this.buttonDriveID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDriveID.Location = new System.Drawing.Point(352, 252);
            this.buttonDriveID.Name = "buttonDriveID";
            this.buttonDriveID.Size = new System.Drawing.Size(83, 23);
            this.buttonDriveID.TabIndex = 49;
            this.buttonDriveID.Text = "Edit Drive ID ";
            this.buttonDriveID.UseVisualStyleBackColor = true;
            this.buttonDriveID.Click += new System.EventHandler(this.buttonDriveID_Click);
            // 
            // groupBoxDriveID
            // 
            this.groupBoxDriveID.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBoxDriveID.Controls.Add(this.labelNeedsBackingUp);
            this.groupBoxDriveID.Controls.Add(this.labelTotalSizeOfDrive);
            this.groupBoxDriveID.Controls.Add(this.labelTotalAvailableSpace);
            this.groupBoxDriveID.Controls.Add(this.labelVolumeLabel);
            this.groupBoxDriveID.Controls.Add(this.label3);
            this.groupBoxDriveID.Controls.Add(this.labelDateLastBackedUp);
            this.groupBoxDriveID.Controls.Add(this.label6);
            this.groupBoxDriveID.Controls.Add(this.label5);
            this.groupBoxDriveID.Controls.Add(this.label4);
            this.groupBoxDriveID.Controls.Add(this.labelLastBackedUp);
            this.groupBoxDriveID.Location = new System.Drawing.Point(15, 184);
            this.groupBoxDriveID.Name = "groupBoxDriveID";
            this.groupBoxDriveID.Size = new System.Drawing.Size(315, 124);
            this.groupBoxDriveID.TabIndex = 50;
            this.groupBoxDriveID.TabStop = false;
            this.groupBoxDriveID.Text = "Drive ID: Sony-1";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRefresh.Location = new System.Drawing.Point(352, 218);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(83, 23);
            this.buttonRefresh.TabIndex = 54;
            this.buttonRefresh.Text = "&Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            // 
            // DriveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 320);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.groupBoxDriveID);
            this.Controls.Add(this.buttonDriveID);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonBackup);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DriveForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Flash Memory Manager - Available Drives";
            this.groupBoxDriveID.ResumeLayout(false);
            this.groupBoxDriveID.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Label labelLastBackedUp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ColumnHeader chDriveLetter;
        private System.Windows.Forms.ColumnHeader chDriveID;
        private System.Windows.Forms.Button buttonBackup;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList imageLstT;
        private System.Windows.Forms.Label labelDateLastBackedUp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelVolumeLabel;
        private System.Windows.Forms.Label labelTotalAvailableSpace;
        private System.Windows.Forms.Label labelTotalSizeOfDrive;
        private System.Windows.Forms.Label labelNeedsBackingUp;
        private System.Windows.Forms.Button buttonDriveID;
        private System.Windows.Forms.GroupBox groupBoxDriveID;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.ColumnHeader chScanned;
        private System.Windows.Forms.Timer timer;
    }
}