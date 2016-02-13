namespace IATray
{
    partial class BackupForm
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
            this.labelInfoOnNewDrive = new System.Windows.Forms.Label();
            this.labelInfoText = new System.Windows.Forms.Label();
            this.labelDriveLableText = new System.Windows.Forms.Label();
            this.textBoxDriveLabel = new System.Windows.Forms.TextBox();
            this.buttonFullBackup = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonIncrementalBackup = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelDriveID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelInfoOnNewDrive
            // 
            this.labelInfoOnNewDrive.AutoSize = true;
            this.labelInfoOnNewDrive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfoOnNewDrive.Location = new System.Drawing.Point(12, 25);
            this.labelInfoOnNewDrive.Name = "labelInfoOnNewDrive";
            this.labelInfoOnNewDrive.Size = new System.Drawing.Size(103, 16);
            this.labelInfoOnNewDrive.TabIndex = 0;
            this.labelInfoOnNewDrive.Text = "Backup drive ";
            this.labelInfoOnNewDrive.Click += new System.EventHandler(this.labelInfoOnNewDrive_Click);
            // 
            // labelInfoText
            // 
            this.labelInfoText.Location = new System.Drawing.Point(12, 142);
            this.labelInfoText.Name = "labelInfoText";
            this.labelInfoText.Size = new System.Drawing.Size(242, 26);
            this.labelInfoText.TabIndex = 1;
            this.labelInfoText.Text = "Please label the drive so that the system can indentify it later.";
            // 
            // labelDriveLableText
            // 
            this.labelDriveLableText.AutoSize = true;
            this.labelDriveLableText.Location = new System.Drawing.Point(7, 103);
            this.labelDriveLableText.Name = "labelDriveLableText";
            this.labelDriveLableText.Size = new System.Drawing.Size(99, 13);
            this.labelDriveLableText.TabIndex = 2;
            this.labelDriveLableText.Text = "Optional discription:";
            // 
            // textBoxDriveLabel
            // 
            this.textBoxDriveLabel.Location = new System.Drawing.Point(10, 119);
            this.textBoxDriveLabel.Name = "textBoxDriveLabel";
            this.textBoxDriveLabel.Size = new System.Drawing.Size(255, 20);
            this.textBoxDriveLabel.TabIndex = 3;
            // 
            // buttonFullBackup
            // 
            this.buttonFullBackup.Location = new System.Drawing.Point(135, 198);
            this.buttonFullBackup.Name = "buttonFullBackup";
            this.buttonFullBackup.Size = new System.Drawing.Size(130, 23);
            this.buttonFullBackup.TabIndex = 4;
            this.buttonFullBackup.Text = "Full Backup";
            this.buttonFullBackup.UseVisualStyleBackColor = true;
            this.buttonFullBackup.Click += new System.EventHandler(this.buttonFullBackup_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(182, 227);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(83, 23);
            this.buttonCancel.TabIndex = 36;
            this.buttonCancel.Text = "&Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonIncrementalBackup
            // 
            this.buttonIncrementalBackup.Location = new System.Drawing.Point(135, 169);
            this.buttonIncrementalBackup.Name = "buttonIncrementalBackup";
            this.buttonIncrementalBackup.Size = new System.Drawing.Size(130, 23);
            this.buttonIncrementalBackup.TabIndex = 37;
            this.buttonIncrementalBackup.Text = "Incremental Backup";
            this.buttonIncrementalBackup.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 31);
            this.label3.TabIndex = 38;
            this.label3.Text = "Use this form to backup the contents of the newly inserted Flash drive.";
            // 
            // labelDriveID
            // 
            this.labelDriveID.AutoSize = true;
            this.labelDriveID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDriveID.Location = new System.Drawing.Point(121, 25);
            this.labelDriveID.Name = "labelDriveID";
            this.labelDriveID.Size = new System.Drawing.Size(43, 16);
            this.labelDriveID.TabIndex = 39;
            this.labelDriveID.Text = "D006";
            // 
            // BackupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 260);
            this.Controls.Add(this.labelDriveID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonIncrementalBackup);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonFullBackup);
            this.Controls.Add(this.textBoxDriveLabel);
            this.Controls.Add(this.labelDriveLableText);
            this.Controls.Add(this.labelInfoText);
            this.Controls.Add(this.labelInfoOnNewDrive);
            this.Name = "BackupForm";
            this.Text = "Flash Memory Manager - Backup";
            this.Load += new System.EventHandler(this.BackupForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInfoOnNewDrive;
        private System.Windows.Forms.Label labelInfoText;
        private System.Windows.Forms.Label labelDriveLableText;
        private System.Windows.Forms.TextBox textBoxDriveLabel;
        private System.Windows.Forms.Button buttonFullBackup;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonIncrementalBackup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelDriveID;
    }
}