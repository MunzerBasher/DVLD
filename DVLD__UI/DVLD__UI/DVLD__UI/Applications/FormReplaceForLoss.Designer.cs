namespace DVLD__UI.People
{
    partial class FormReplacement
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
            this.userConReNewLicense1 = new DVLD__UI.People.UserConRePlacementLicense();
            this.SuspendLayout();
            // 
            // userConReNewLicense1
            // 
            this.userConReNewLicense1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userConReNewLicense1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.userConReNewLicense1.Location = new System.Drawing.Point(0, 0);
            this.userConReNewLicense1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.userConReNewLicense1.Name = "userConReNewLicense1";
            this.userConReNewLicense1.Size = new System.Drawing.Size(1044, 630);
            this.userConReNewLicense1.TabIndex = 0;
            this.userConReNewLicense1.OnClose += new System.Action<bool>(this.userConReNewLicense1_OnClose);
            // 
            // FormReplacement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 630);
            this.Controls.Add(this.userConReNewLicense1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormReplacement";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormReplacement";
            this.ResumeLayout(false);

        }

        #endregion

        private UserConRePlacementLicense userConReNewLicense1;
    }
}