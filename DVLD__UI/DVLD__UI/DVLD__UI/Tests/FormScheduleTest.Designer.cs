namespace DVLD__UI.LocalLicense
{
    partial class FormScheduleTest
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
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.userConScheduleTest1 = new DVLD__UI.LocalLicense.UserConScheduleTest();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnClose.Location = new System.Drawing.Point(976, 597);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(122, 34);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(408, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "ScheduleTest";
            // 
            // userConScheduleTest1
            // 
            this.userConScheduleTest1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.userConScheduleTest1.Location = new System.Drawing.Point(0, 35);
            this.userConScheduleTest1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userConScheduleTest1.Name = "userConScheduleTest1";
            this.userConScheduleTest1.Size = new System.Drawing.Size(1098, 557);
            this.userConScheduleTest1.TabIndex = 0;
            // 
            // FormScheduleTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 642);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.userConScheduleTest1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormScheduleTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormScheduleTest";
            this.Load += new System.EventHandler(this.FormScheduleTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserConScheduleTest userConScheduleTest1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
    }
}