namespace DVLD__UI.LocalLicense
{
    partial class FormTakeScheduledTest
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
            this.userConAddScheduledTest1 = new DVLD__UI.LocalLicense.UserConTakeScheduledTest();
            this.SuspendLayout();
            // 
            // userConAddScheduledTest1
            // 
            this.userConAddScheduledTest1.ApplicationID = "???";
            this.userConAddScheduledTest1.AppointmentID = 0;
            this.userConAddScheduledTest1.ClassName = "???";
            this.userConAddScheduledTest1.Date = "???";
            this.userConAddScheduledTest1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userConAddScheduledTest1.Fees = "???";
            this.userConAddScheduledTest1.Location = new System.Drawing.Point(0, 0);
            this.userConAddScheduledTest1.Name = "userConAddScheduledTest1";
            this.userConAddScheduledTest1.NodeText = "";
            this.userConAddScheduledTest1.PersonName = "???";
            this.userConAddScheduledTest1.Size = new System.Drawing.Size(693, 788);
            this.userConAddScheduledTest1.TabIndex = 0;
            this.userConAddScheduledTest1.OnClose += new System.Action<bool>(this.userConAddScheduledTest1_OnClose);
            this.userConAddScheduledTest1.Load += new System.EventHandler(this.userConAddScheduledTest1_Load);
            // 
            // FormTakeScheduledTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 788);
            this.Controls.Add(this.userConAddScheduledTest1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTakeScheduledTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAddScheduledTest";
            this.Load += new System.EventHandler(this.FormAddScheduledTest_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UserConTakeScheduledTest userConAddScheduledTest1;
    }
}