namespace DVLD__UI.People
{
    partial class FormInternationalLicenses
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
            this.userConInternationalLicenses1 = new DVLD__UI.People.UserConInternationalLicenses();
            this.SuspendLayout();
            // 
            // userConInternationalLicenses1
            // 
            this.userConInternationalLicenses1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userConInternationalLicenses1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.userConInternationalLicenses1.Location = new System.Drawing.Point(0, 0);
            this.userConInternationalLicenses1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.userConInternationalLicenses1.Name = "userConInternationalLicenses1";
            this.userConInternationalLicenses1.Size = new System.Drawing.Size(1044, 630);
            this.userConInternationalLicenses1.TabIndex = 0;
            this.userConInternationalLicenses1.OnClose += new System.Action<bool>(this.userConInternationalLicenses1_OnClose);
            // 
            // FormInternationalLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 630);
            this.Controls.Add(this.userConInternationalLicenses1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormInternationalLicenses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInternationalLicenses";
            this.Load += new System.EventHandler(this.FormInternationalLicenses_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UserConInternationalLicenses userConInternationalLicenses1;
    }
}