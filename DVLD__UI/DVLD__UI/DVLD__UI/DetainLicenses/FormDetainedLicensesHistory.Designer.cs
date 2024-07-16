namespace DVLD__UI.LocalLicense
{
    partial class FormDetainedLicensesHistory
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.coID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColClassName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colIssueDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colExpirationDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colIsActive = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDetainDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colIsReleased = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colReleasedDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.coID,
            this.ColClassName,
            this.colIssueDate,
            this.colExpirationDate,
            this.colIsActive,
            this.colDetainDate,
            this.colIsReleased,
            this.colReleasedDate});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 142);
            this.listView1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1743, 530);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            
            // coID
            // 
            this.coID.Text = "ID";
            this.coID.Width = 40;
            // 
            // ColClassName
            // 
            this.ColClassName.Text = "ClassName";
            this.ColClassName.Width = 165;
            // 
            // colIssueDate
            // 
            this.colIssueDate.Text = "IssueDate";
            this.colIssueDate.Width = 130;
            // 
            // colExpirationDate
            // 
            this.colExpirationDate.Text = "ExpirationDate";
            this.colExpirationDate.Width = 130;
            // 
            // colIsActive
            // 
            this.colIsActive.Text = "IsActive";
            // 
            // colDetainDate
            // 
            this.colDetainDate.Text = "DetainDate";
            this.colDetainDate.Width = 130;
            // 
            // colIsReleased
            // 
            this.colIsReleased.Text = "IsReleased";
            this.colIsReleased.Width = 65;
            // 
            // colReleasedDate
            // 
            this.colReleasedDate.Text = "ReleasedDate";
            this.colReleasedDate.Width = 130;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Maroon;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(390, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Detained Licenses Histroy";
            // 
            // FormDetainedLicensesHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1744, 672);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDetainedLicensesHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDetainedLicensesHistory";
            this.Load += new System.EventHandler(this.FormDetainedLicensesHistory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader coID;
        private System.Windows.Forms.ColumnHeader ColClassName;
        private System.Windows.Forms.ColumnHeader colIssueDate;
        private System.Windows.Forms.ColumnHeader colExpirationDate;
        private System.Windows.Forms.ColumnHeader colIsActive;
        private System.Windows.Forms.ColumnHeader colDetainDate;
        private System.Windows.Forms.ColumnHeader colIsReleased;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader colReleasedDate;
    }
}