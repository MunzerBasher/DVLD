namespace DVLD__UI.LocalLicense
{
    partial class FormApplicationDetails
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
            this.userApplicationDetails1 = new DVLD__UI.LocalLicense.UserApplicationDetails();
            this.SuspendLayout();
            // 
            // userApplicationDetails1
            // 
            this.userApplicationDetails1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userApplicationDetails1.Location = new System.Drawing.Point(0, 0);
            this.userApplicationDetails1.Name = "userApplicationDetails1";
            this.userApplicationDetails1.Size = new System.Drawing.Size(1354, 697);
            this.userApplicationDetails1.TabIndex = 0;
            this.userApplicationDetails1.OnClose += new System.Action<bool>(this.userApplicationDetails1_OnClose);
            // 
            // FormApplicationDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 697);
            this.Controls.Add(this.userApplicationDetails1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormApplicationDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormApplicationDetails";
            this.Load += new System.EventHandler(this.FormApplicationDetails_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UserApplicationDetails userApplicationDetails1;
    }
}