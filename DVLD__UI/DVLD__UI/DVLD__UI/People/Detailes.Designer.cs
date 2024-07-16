namespace DVLD__UI.People
{
    partial class Details
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
            this.userControl11 = new DVLD__UI.People.PeopleData();
            this.PersonID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userControl11
            // 
            this.userControl11.Address = "";
            this.userControl11.BirthDay = new System.DateTime(2024, 2, 2, 21, 49, 41, 73);
            this.userControl11.Country = 1;
            this.userControl11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.userControl11.Email = "";
            this.userControl11.First = "";
            this.userControl11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.userControl11.Gender = 0;
            this.userControl11.ID = 0;
            this.userControl11.ImagePath = "";
            this.userControl11.Last = "";
            this.userControl11.Location = new System.Drawing.Point(0, 63);
            this.userControl11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userControl11.Name = "userControl11";
            this.userControl11.National = "";
            this.userControl11.Phone = "";
            this.userControl11.Second = "";
            this.userControl11.Size = new System.Drawing.Size(1068, 626);
            this.userControl11.TabIndex = 0;
            this.userControl11.Third = "";
          
            // PersonID
            // 
            this.PersonID.AutoSize = true;
            this.PersonID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PersonID.Location = new System.Drawing.Point(167, 29);
            this.PersonID.Name = "PersonID";
            this.PersonID.Size = new System.Drawing.Size(55, 29);
            this.PersonID.TabIndex = 6;
            this.PersonID.Text = "N/D";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(22, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "PersonID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(479, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 689);
            this.Controls.Add(this.PersonID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userControl11);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Details";
            this.Load += new System.EventHandler(this.Details_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PeopleData userControl11;
        private System.Windows.Forms.Label PersonID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}