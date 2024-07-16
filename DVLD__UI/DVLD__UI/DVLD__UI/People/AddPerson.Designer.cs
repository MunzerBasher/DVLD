namespace DVLD__UI
{
    partial class AddOrEditPerson
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PersonID = new System.Windows.Forms.Label();
            this.userControl11 = new DVLD__UI.People.PeopleData();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(306, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "PersonID :";
            // 
            // PersonID
            // 
            this.PersonID.AutoSize = true;
            this.PersonID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PersonID.Location = new System.Drawing.Point(157, 70);
            this.PersonID.Name = "PersonID";
            this.PersonID.Size = new System.Drawing.Size(55, 29);
            this.PersonID.TabIndex = 3;
            this.PersonID.Text = "N/D";
            // 
            // userControl11
            // 
            this.userControl11.Address = "";
            this.userControl11.BirthDay = new System.DateTime(2024, 1, 31, 23, 3, 19, 13);
            
            this.userControl11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.userControl11.Email = "";
            this.userControl11.First = "";
            this.userControl11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.userControl11.Gender = 0;
            this.userControl11.ID = 0;
            this.userControl11.ImagePath = "";
            this.userControl11.Last = "";
            this.userControl11.Location = new System.Drawing.Point(0, 107);
            this.userControl11.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.userControl11.Name = "userControl11";
            this.userControl11.National = "";
            this.userControl11.Phone = "";
            this.userControl11.Second = "";
            this.userControl11.Size = new System.Drawing.Size(702, 376);
            this.userControl11.TabIndex = 0;
            this.userControl11.Third = "";
            this.userControl11.OnSave += new System.Action<bool>(this.userControl11_OnCalculationComplete);
            this.userControl11.OnClose += new System.Action<bool>(this.userControl11_OnClose);
            // 
            // AddOrEditPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 483);
            this.ControlBox = false;
            this.Controls.Add(this.PersonID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userControl11);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddOrEditPerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add/Edit Person info";
            this.Load += new System.EventHandler(this.AddOrEditPerson_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private People.PeopleData userControl11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label PersonID;
    }
}