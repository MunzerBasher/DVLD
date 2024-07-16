namespace DVLD__UI.Users
{
    partial class UserDetails
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.peopleData1 = new DVLD__UI.People.PeopleData();
            this.label1 = new System.Windows.Forms.Label();
            this.lbUserID = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.lbUserName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chIsActive = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // peopleData1
            // 
            this.peopleData1.Address = "";
            this.peopleData1.BirthDay = new System.DateTime(2024, 2, 5, 11, 15, 44, 780);
            this.peopleData1.Country = 0;
            this.peopleData1.Email = "";
            this.peopleData1.First = "";
            this.peopleData1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.peopleData1.Gender = 0;
            this.peopleData1.ID = 0;
            this.peopleData1.ImagePath = "";
            this.peopleData1.Last = "";
            this.peopleData1.Location = new System.Drawing.Point(6, 5);
            this.peopleData1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.peopleData1.Name = "peopleData1";
            this.peopleData1.National = "";
            this.peopleData1.Phone = "";
            this.peopleData1.Second = "";
            this.peopleData1.Size = new System.Drawing.Size(1116, 515);
            this.peopleData1.TabIndex = 0;
            this.peopleData1.Third = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 525);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "UserID :";
            // 
            // lbUserID
            // 
            this.lbUserID.AutoSize = true;
            this.lbUserID.Location = new System.Drawing.Point(112, 525);
            this.lbUserID.Name = "lbUserID";
            this.lbUserID.Size = new System.Drawing.Size(60, 20);
            this.lbUserID.TabIndex = 2;
            this.lbUserID.Text = "UserID";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(320, 529);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(93, 20);
            this.Label3.TabIndex = 3;
            this.Label3.Text = "UserName :";
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Location = new System.Drawing.Point(419, 529);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(85, 20);
            this.lbUserName.TabIndex = 4;
            this.lbUserName.Text = "UserName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(647, 532);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(731, 532);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "???";
            // 
            // chIsActive
            // 
            this.chIsActive.AutoSize = true;
            this.chIsActive.Location = new System.Drawing.Point(878, 528);
            this.chIsActive.Name = "chIsActive";
            this.chIsActive.Size = new System.Drawing.Size(95, 24);
            this.chIsActive.TabIndex = 7;
            this.chIsActive.Text = "Is Active";
            this.chIsActive.UseVisualStyleBackColor = true;
            // 
            // UserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chIsActive);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbUserName);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.lbUserID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.peopleData1);
            this.Name = "UserDetails";
            this.Size = new System.Drawing.Size(1126, 580);
            this.Load += new System.EventHandler(this.UserDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbUserID;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chIsActive;
        public People.PeopleData peopleData1;
    }
}
