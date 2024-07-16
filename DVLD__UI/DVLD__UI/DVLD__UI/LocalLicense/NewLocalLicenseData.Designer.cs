namespace DVLD__UI
{
    partial class NewLocalLicenseData
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
            this.newLocalLicense1 = new DVLD__UI.NewLocalLicense();
            this.SuspendLayout();
            // 
            // newLocalLicense1
            // 
            this.newLocalLicense1.ApplicationID = 0;
            this.newLocalLicense1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newLocalLicense1.Location = new System.Drawing.Point(0, 0);
            this.newLocalLicense1.Margin = new System.Windows.Forms.Padding(2);
            this.newLocalLicense1.Name = "newLocalLicense1";
            this.newLocalLicense1.Size = new System.Drawing.Size(800, 449);
            this.newLocalLicense1.TabIndex = 0;
            this.newLocalLicense1.OnSave += new System.Action<bool>(this.newLocalLicense1_OnSave);
            this.newLocalLicense1.OnClose += new System.Action<bool>(this.newLocalLicense1_OnClose);
            // 
            // NewLocalLicenseData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.newLocalLicense1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewLocalLicenseData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewLocalLicenseData";
            this.ResumeLayout(false);

        }

        #endregion

        private NewLocalLicense newLocalLicense1;
    }
}