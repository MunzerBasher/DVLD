namespace DVLD__UI.Users
{
    partial class UpdateUser
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
            this.updateUserControl11 = new DVLD__UI.Users.UpdateUserControl1();
            this.userChange1 = new DVLD__UI.Users.UserChange();
            this.SuspendLayout();
            // 
            // updateUserControl11
            // 
            this.updateUserControl11.Location = new System.Drawing.Point(14, 71);
            this.updateUserControl11.Name = "updateUserControl11";
            this.updateUserControl11.Size = new System.Drawing.Size(1116, 606);
            this.updateUserControl11.TabIndex = 0;
            this.updateUserControl11.OnEnd += new System.Action<bool>(this.updateUserControl11_OnEnd);
            this.updateUserControl11.OnLinkClicked += new System.Action<bool>(this.updateUserControl11_OnLinkClicked);
            // 
            // userChange1
            // 
            this.userChange1.ConFirmPassword = "";
            this.userChange1.Description = "label2";
            this.userChange1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.userChange1.IsActive = false;
            this.userChange1.Location = new System.Drawing.Point(0, 82);
            this.userChange1.Name = "userChange1";
            this.userChange1.NewPassword = "";
            this.userChange1.Size = new System.Drawing.Size(1142, 607);
            this.userChange1.TabIndex = 1;
            this.userChange1.Title = "label1";
            this.userChange1.UserID = "???";
            this.userChange1.UserName = "";
            this.userChange1.UserPassword = "";
            this.userChange1.OnSave += new System.Action<bool>(this.userChange1_OnSave);
            this.userChange1.OnClose += new System.Action<bool>(this.userChange1_OnClose);
            // 
            // UpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 689);
            this.Controls.Add(this.updateUserControl11);
            this.Controls.Add(this.userChange1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateUser";
            this.Load += new System.EventHandler(this.UpdateUser_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UpdateUserControl1 updateUserControl11;
        private UserChange userChange1;
    }
}