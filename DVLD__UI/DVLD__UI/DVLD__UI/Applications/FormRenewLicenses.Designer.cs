namespace DVLD__UI.People
{
    partial class FormRenewLicenses
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
            this.userConReNewLicenses1 = new DVLD__UI.People.UserConReNewLicenses();
            this.SuspendLayout();
            // 
            // userConReNewLicenses1
            // 
            this.userConReNewLicenses1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userConReNewLicenses1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.userConReNewLicenses1.Location = new System.Drawing.Point(0, 0);
            this.userConReNewLicenses1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.userConReNewLicenses1.Name = "userConReNewLicenses1";
            this.userConReNewLicenses1.Size = new System.Drawing.Size(1044, 673);
            this.userConReNewLicenses1.TabIndex = 0;
            this.userConReNewLicenses1.OnClose += new System.Action<bool>(this.userConReNewLicenses1_OnClose);
            // 
            // FormRenewLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 673);
            this.Controls.Add(this.userConReNewLicenses1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRenewLicenses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRenewLicenses";
            this.ResumeLayout(false);

        }

        #endregion

        private UserConReNewLicenses userConReNewLicenses1;
    }
}