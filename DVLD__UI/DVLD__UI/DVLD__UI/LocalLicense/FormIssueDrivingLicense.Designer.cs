﻿namespace DVLD__UI.LocalLicense
{
    partial class FormShowDriverLicense
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
            this.userConLicenseDetails1 = new DVLD__UI.UserConLicenseDetails();
            this.SuspendLayout();
            // 
            // userConLicenseDetails1
            // 
            this.userConLicenseDetails1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.userConLicenseDetails1.Location = new System.Drawing.Point(0, 0);
            this.userConLicenseDetails1.Name = "userConLicenseDetails1";
            this.userConLicenseDetails1.Size = new System.Drawing.Size(1312, 662);
            this.userConLicenseDetails1.TabIndex = 0;
            // 
            // FormShowDriverLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 437);
            this.Controls.Add(this.userConLicenseDetails1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormShowDriverLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormShowDriverLicense";
            this.Load += new System.EventHandler(this.FormShowDriverLicense_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UserConLicenseDetails userConLicenseDetails1;
    }
}