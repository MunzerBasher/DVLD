namespace DVLD__UI
{
    partial class SearchForPerson
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
            this.lbFind = new System.Windows.Forms.Label();
            this.Options = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.SearchBox1 = new System.Windows.Forms.PictureBox();
            this.AddBox2 = new System.Windows.Forms.PictureBox();
            this.userControl11 = new DVLD__UI.People.PeopleData();
            ((System.ComponentModel.ISupportInitialize)(this.SearchBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbFind
            // 
            this.lbFind.AutoSize = true;
            this.lbFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lbFind.Location = new System.Drawing.Point(31, 138);
            this.lbFind.Name = "lbFind";
            this.lbFind.Size = new System.Drawing.Size(70, 20);
            this.lbFind.TabIndex = 1;
            this.lbFind.Text = "Find By :";
            // 
            // Options
            // 
            this.Options.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Options.FormattingEnabled = true;
            this.Options.Location = new System.Drawing.Point(122, 138);
            this.Options.Name = "Options";
            this.Options.Size = new System.Drawing.Size(228, 28);
            this.Options.TabIndex = 2;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtSearch.Location = new System.Drawing.Point(356, 140);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(333, 26);
            this.txtSearch.TabIndex = 3;
            // 
            // SearchBox1
            // 
            this.SearchBox1.Image = global::DVLD__UI.Properties.Resources.forbidden__7_;
            this.SearchBox1.Location = new System.Drawing.Point(715, 125);
            this.SearchBox1.Name = "SearchBox1";
            this.SearchBox1.Size = new System.Drawing.Size(67, 55);
            this.SearchBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SearchBox1.TabIndex = 4;
            this.SearchBox1.TabStop = false;
            this.SearchBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // AddBox2
            // 
            this.AddBox2.Image = global::DVLD__UI.Properties.Resources.user_add;
            this.AddBox2.Location = new System.Drawing.Point(788, 125);
            this.AddBox2.Name = "AddBox2";
            this.AddBox2.Size = new System.Drawing.Size(62, 55);
            this.AddBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AddBox2.TabIndex = 5;
            this.AddBox2.TabStop = false;
            this.AddBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // userControl11
            // 
            this.userControl11.Address = "";
            this.userControl11.BirthDay = new System.DateTime(2024, 2, 3, 6, 40, 42, 834);
            this.userControl11.Country = 0;
            this.userControl11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.userControl11.Email = "";
            this.userControl11.First = "";
            this.userControl11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.userControl11.Gender = 0;
            this.userControl11.ID = 0;
            this.userControl11.ImagePath = "";
            this.userControl11.Last = "";
            this.userControl11.Location = new System.Drawing.Point(0, 141);
            this.userControl11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userControl11.Name = "userControl11";
            this.userControl11.National = "";
            this.userControl11.Phone = "";
            this.userControl11.Second = "";
            this.userControl11.Size = new System.Drawing.Size(885, 598);
            this.userControl11.TabIndex = 0;
            this.userControl11.Third = "";
            this.userControl11.OnSave += new System.Action<bool>(this.userControl11_OnCalculationComplete);
            this.userControl11.OnClose += new System.Action<bool>(this.userControl11_OnClose);
            // 
            // SearchForPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AddBox2);
            this.Controls.Add(this.SearchBox1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.Options);
            this.Controls.Add(this.lbFind);
            this.Controls.Add(this.userControl11);
            this.Name = "SearchForPerson";
            this.Size = new System.Drawing.Size(885, 739);
            this.Load += new System.EventHandler(this.UserData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SearchBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbFind;
        private System.Windows.Forms.ComboBox Options;
        private System.Windows.Forms.PictureBox SearchBox1;
        private System.Windows.Forms.PictureBox AddBox2;
        public System.Windows.Forms.TextBox txtSearch;
        public People.PeopleData userControl11;
    }
}
