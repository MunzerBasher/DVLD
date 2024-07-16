namespace DVLD__UI.LocalLicense
{
    partial class FormDetainLicenseDetails
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
            this.userConDetainLicense1 = new DVLD__UI.LocalLicense.UserConDetainLicense();
            this.SuspendLayout();
            // 
            // userConDetainLicense1
            // 
            this.userConDetainLicense1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userConDetainLicense1.Location = new System.Drawing.Point(0, 0);
            this.userConDetainLicense1.Name = "userConDetainLicense1";
            this.userConDetainLicense1.Size = new System.Drawing.Size(1540, 721);
            this.userConDetainLicense1.TabIndex = 1;
            // 
            // FormDetainLicenseDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1540, 721);
            this.Controls.Add(this.userConDetainLicense1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDetainLicenseDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDetainLicenseDetails";
            this.Load += new System.EventHandler(this.FormDetainLicenseDetails_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UserConDetainLicense userConDetainLicense1;
    }
}