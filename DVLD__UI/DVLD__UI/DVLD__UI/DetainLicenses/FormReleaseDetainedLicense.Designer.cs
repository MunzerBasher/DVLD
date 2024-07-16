namespace DVLD__UI.LocalLicense
{
    partial class FormReleaseDetainedLicense
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
            this.btnRelease = new System.Windows.Forms.Button();
            this.userConDetainLicense1 = new DVLD__UI.LocalLicense.UserConDetainLicense();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRelease
            // 
            this.btnRelease.Location = new System.Drawing.Point(1132, 639);
            this.btnRelease.Name = "btnRelease";
            this.btnRelease.Size = new System.Drawing.Size(117, 39);
            this.btnRelease.TabIndex = 1;
            this.btnRelease.Text = "Release";
            this.btnRelease.UseVisualStyleBackColor = true;
            this.btnRelease.Click += new System.EventHandler(this.btnRelease_Click);
            // 
            // userConDetainLicense1
            // 
            this.userConDetainLicense1.Location = new System.Drawing.Point(1, 1);
            this.userConDetainLicense1.Name = "userConDetainLicense1";
            this.userConDetainLicense1.Size = new System.Drawing.Size(1540, 719);
            this.userConDetainLicense1.TabIndex = 0;
            this.userConDetainLicense1.OnPBSearch += new System.Action<bool>(this.userConDetainLicense1_OnPBSearch);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1000, 639);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(117, 39);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormReleaseDetainedLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1540, 721);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRelease);
            this.Controls.Add(this.userConDetainLicense1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormReleaseDetainedLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormReleaseDetainedLicense";
            this.Load += new System.EventHandler(this.FormReleaseDetainedLicense_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UserConDetainLicense userConDetainLicense1;
        private System.Windows.Forms.Button btnRelease;
        private System.Windows.Forms.Button btnClose;
    }
}