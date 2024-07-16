namespace DVLD__UI.Users
{
    partial class UpdateUserControl1
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
            this.lbUserID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
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
            this.peopleData1.Location = new System.Drawing.Point(0, 39);
            this.peopleData1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.peopleData1.Name = "peopleData1";
            this.peopleData1.National = "";
            this.peopleData1.Phone = "";
            this.peopleData1.Second = "";
            this.peopleData1.Size = new System.Drawing.Size(1116, 515);
            this.peopleData1.TabIndex = 1;
            this.peopleData1.Third = "";
            // 
            // lbUserID
            // 
            this.lbUserID.AutoSize = true;
            this.lbUserID.Location = new System.Drawing.Point(91, 14);
            this.lbUserID.Name = "lbUserID";
            this.lbUserID.Size = new System.Drawing.Size(60, 20);
            this.lbUserID.TabIndex = 4;
            this.lbUserID.Text = "UserID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "UserID :";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(891, 577);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(222, 20);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Change UserName /Password";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1024, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 31);
            this.button1.TabIndex = 10;
            this.button1.Text = "End";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UpdateUserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lbUserID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.peopleData1);
            this.Name = "UpdateUserControl1";
            this.Size = new System.Drawing.Size(1116, 606);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public People.PeopleData peopleData1;
        private System.Windows.Forms.Label lbUserID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button1;
    }
}
