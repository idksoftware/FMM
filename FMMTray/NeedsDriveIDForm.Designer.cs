namespace IATray
{
    partial class NeedsDriveIDForm
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxDriveLabel = new System.Windows.Forms.TextBox();
            this.labelDriveLableText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonCancel.Location = new System.Drawing.Point(231, 75);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(83, 23);
            this.buttonCancel.TabIndex = 37;
            this.buttonCancel.Text = "&Ok";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(133, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 23);
            this.button1.TabIndex = 38;
            this.button1.Text = "&Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBoxDriveLabel
            // 
            this.textBoxDriveLabel.Location = new System.Drawing.Point(15, 40);
            this.textBoxDriveLabel.Name = "textBoxDriveLabel";
            this.textBoxDriveLabel.Size = new System.Drawing.Size(255, 20);
            this.textBoxDriveLabel.TabIndex = 40;
            // 
            // labelDriveLableText
            // 
            this.labelDriveLableText.AutoSize = true;
            this.labelDriveLableText.Location = new System.Drawing.Point(12, 24);
            this.labelDriveLableText.Name = "labelDriveLableText";
            this.labelDriveLableText.Size = new System.Drawing.Size(64, 13);
            this.labelDriveLableText.TabIndex = 39;
            this.labelDriveLableText.Text = "Drive Label:";
            // 
            // NeedsDriveIDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 110);
            this.Controls.Add(this.textBoxDriveLabel);
            this.Controls.Add(this.labelDriveLableText);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonCancel);
            this.Name = "NeedsDriveIDForm";
            this.Text = "Flash Memory Manager -  - Add Drive ID";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxDriveLabel;
        private System.Windows.Forms.Label labelDriveLableText;
    }
}