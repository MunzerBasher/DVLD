namespace DVLD__UI
{
    partial class UserConLicensesHistory
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listViewLocalLicenses = new System.Windows.Forms.ListView();
            this.ColLicID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAppID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colClassName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colIssueDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colExpirationDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colIsActive = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listViewInternationalLicenses = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.userConLicenseDetails1 = new DVLD__UI.UserConLicenseDetails();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.tabControl1.Location = new System.Drawing.Point(18, 418);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(814, 122);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.TabIndexChanged += new System.EventHandler(this.tabControl1_TabIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listViewLocalLicenses);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(806, 89);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Local Licenses";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listViewLocalLicenses
            // 
            this.listViewLocalLicenses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColLicID,
            this.colAppID,
            this.colClassName,
            this.colIssueDate,
            this.colExpirationDate,
            this.colIsActive});
            this.listViewLocalLicenses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewLocalLicenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.listViewLocalLicenses.FullRowSelect = true;
            this.listViewLocalLicenses.HideSelection = false;
            this.listViewLocalLicenses.Location = new System.Drawing.Point(2, 2);
            this.listViewLocalLicenses.Margin = new System.Windows.Forms.Padding(2);
            this.listViewLocalLicenses.Name = "listViewLocalLicenses";
            this.listViewLocalLicenses.Size = new System.Drawing.Size(802, 85);
            this.listViewLocalLicenses.TabIndex = 0;
            this.listViewLocalLicenses.UseCompatibleStateImageBehavior = false;
            this.listViewLocalLicenses.View = System.Windows.Forms.View.Details;
            // 
            // ColLicID
            // 
            this.ColLicID.Text = "Lic ID";
            // 
            // colAppID
            // 
            this.colAppID.Text = "App ID";
            // 
            // colClassName
            // 
            this.colClassName.Text = "Class Name";
            this.colClassName.Width = 180;
            // 
            // colIssueDate
            // 
            this.colIssueDate.Text = "IssueDate";
            this.colIssueDate.Width = 180;
            // 
            // colExpirationDate
            // 
            this.colExpirationDate.Text = "ExpirationDate";
            this.colExpirationDate.Width = 180;
            // 
            // colIsActive
            // 
            this.colIsActive.Text = "IsActive";
            this.colIsActive.Width = 100;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listViewInternationalLicenses);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(806, 89);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "InternationalLicenses";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listViewInternationalLicenses
            // 
            this.listViewInternationalLicenses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewInternationalLicenses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewInternationalLicenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.listViewInternationalLicenses.FullRowSelect = true;
            this.listViewInternationalLicenses.HideSelection = false;
            this.listViewInternationalLicenses.Location = new System.Drawing.Point(0, 0);
            this.listViewInternationalLicenses.Margin = new System.Windows.Forms.Padding(2);
            this.listViewInternationalLicenses.Name = "listViewInternationalLicenses";
            this.listViewInternationalLicenses.Size = new System.Drawing.Size(806, 89);
            this.listViewInternationalLicenses.TabIndex = 1;
            this.listViewInternationalLicenses.UseCompatibleStateImageBehavior = false;
            this.listViewInternationalLicenses.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Lic ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "App ID";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Class Name";
            this.columnHeader3.Width = 180;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "IssueDate";
            this.columnHeader4.Width = 180;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "ExpirationDate";
            this.columnHeader5.Width = 180;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "IsActive";
            this.columnHeader6.Width = 100;
            // 
            // userConLicenseDetails1
            // 
            this.userConLicenseDetails1.Dock = System.Windows.Forms.DockStyle.Top;
            this.userConLicenseDetails1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.userConLicenseDetails1.Location = new System.Drawing.Point(0, 0);
            this.userConLicenseDetails1.Margin = new System.Windows.Forms.Padding(2);
            this.userConLicenseDetails1.Name = "userConLicenseDetails1";
            this.userConLicenseDetails1.Size = new System.Drawing.Size(1261, 429);
            this.userConLicenseDetails1.TabIndex = 0;
            // 
            // UserConLicensesHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.userConLicenseDetails1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserConLicensesHistory";
            this.Size = new System.Drawing.Size(1261, 542);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UserConLicenseDetails userConLicenseDetails1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView listViewLocalLicenses;
        private System.Windows.Forms.ColumnHeader ColLicID;
        private System.Windows.Forms.ColumnHeader colAppID;
        private System.Windows.Forms.ColumnHeader colClassName;
        private System.Windows.Forms.ColumnHeader colIssueDate;
        private System.Windows.Forms.ColumnHeader colExpirationDate;
        private System.Windows.Forms.ColumnHeader colIsActive;
        private System.Windows.Forms.ListView listViewInternationalLicenses;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}
