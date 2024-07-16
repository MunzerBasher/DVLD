namespace DVLD__UI
{
    partial class FormUserConLicensesHistory
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
            this.userConLicensesHistory1 = new DVLD__UI.UserConLicensesHistory();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userConLicensesHistory1
            // 
            this.userConLicensesHistory1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.userConLicensesHistory1.Location = new System.Drawing.Point(-1, 42);
            this.userConLicensesHistory1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userConLicensesHistory1.Name = "userConLicensesHistory1";
            this.userConLicensesHistory1.Size = new System.Drawing.Size(1287, 585);
            this.userConLicensesHistory1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Violet;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(322, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "License History";
            // 
            // FormUserConLicensesHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 590);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userConLicensesHistory1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormUserConLicensesHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormUserConLicensesHistory";
            this.Load += new System.EventHandler(this.FormUserConLicensesHistory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserConLicensesHistory userConLicensesHistory1;
        private System.Windows.Forms.Label label1;
    }
}