namespace DVLD__UI.Users
{
    partial class FormUserDetails
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
            this.userDetails1 = new DVLD__UI.Users.UserDetails();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userDetails1
            // 
            this.userDetails1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.userDetails1.IsActive = false;
            this.userDetails1.Location = new System.Drawing.Point(0, 114);
            this.userDetails1.Name = "userDetails1";
            this.userDetails1.Size = new System.Drawing.Size(1068, 575);
            this.userDetails1.TabIndex = 0;
            this.userDetails1.UserID = "UserID";
            this.userDetails1.UserName = "UserName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkMagenta;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(451, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Details";
            // 
            // FormUserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 689);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userDetails1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormUserDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormUserDetails";
            this.Load += new System.EventHandler(this.FormUserDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserDetails userDetails1;
        private System.Windows.Forms.Label label1;
    }
}