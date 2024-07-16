namespace DVLD__UI
{
    partial class CurrentUserInfo
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
            this.usCoChangePassword1 = new DVLD__UI.UsCoChangePassword();
            this.SuspendLayout();
            // 
            // usCoChangePassword1
            // 
            this.usCoChangePassword1.ConFirmPassword = "";
            this.usCoChangePassword1.Description = "label2";
            this.usCoChangePassword1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usCoChangePassword1.Location = new System.Drawing.Point(0, 0);
            this.usCoChangePassword1.Name = "usCoChangePassword1";
            this.usCoChangePassword1.NewPassword = "";
            this.usCoChangePassword1.Size = new System.Drawing.Size(818, 402);
            this.usCoChangePassword1.TabIndex = 0;
            this.usCoChangePassword1.Title = "label1";
            this.usCoChangePassword1.UserPassword = "";
            this.usCoChangePassword1.OnSave += new System.Action<bool>(this.usCoChangePassword1_OnSave);
            // 
            // CurrentUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 402);
            this.Controls.Add(this.usCoChangePassword1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CurrentUserInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CurrentUserInfo";
            this.Load += new System.EventHandler(this.CurrentUserInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UsCoChangePassword usCoChangePassword1;
    }
}