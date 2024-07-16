namespace DVLD__UI.LocalLicense
{
    partial class FormAddScheduleTestAppointment
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
            this.userConAddScheduleTestAppointment1 = new DVLD__UI.LocalLicense.UserConAddScheduleTestAppointment();
            this.SuspendLayout();
            // 
            // userConAddScheduleTestAppointment1
            // 
            this.userConAddScheduleTestAppointment1.ApplicationID = "???";
            this.userConAddScheduleTestAppointment1.Date = new System.DateTime(2024, 2, 19, 13, 0, 35, 474);
            this.userConAddScheduleTestAppointment1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userConAddScheduleTestAppointment1.Fees = "???";
            this.userConAddScheduleTestAppointment1.Location = new System.Drawing.Point(0, 0);
            this.userConAddScheduleTestAppointment1.Name = "userConAddScheduleTestAppointment1";
            this.userConAddScheduleTestAppointment1.PersonName = "???";
            this.userConAddScheduleTestAppointment1.Size = new System.Drawing.Size(650, 556);
            this.userConAddScheduleTestAppointment1.TabIndex = 0;
            this.userConAddScheduleTestAppointment1.TestID = 0;
            this.userConAddScheduleTestAppointment1.OnClose += new System.Action<bool>(this.userConAddScheduleTestAppointment1_OnClose);
            // 
            // FormAddScheduleTestAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 556);
            this.Controls.Add(this.userConAddScheduleTestAppointment1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddScheduleTestAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAddScheduleTest";
            this.Load += new System.EventHandler(this.FormAddScheduleTestAppointment_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UserConAddScheduleTestAppointment userConAddScheduleTestAppointment1;
    }
}