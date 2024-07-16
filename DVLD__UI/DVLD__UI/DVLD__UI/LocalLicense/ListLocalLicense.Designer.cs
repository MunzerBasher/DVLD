namespace DVLD__UI
{
    partial class ListLocalLicense
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
            this.components = new System.ComponentModel.Container();
            this.listView1 = new System.Windows.Forms.ListView();
            this.coID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colClassName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNationaNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColFullName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colApplicationDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPassTestCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.applicationDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleViewTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleWrittenTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schedulePracticalTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonLicenseHistoryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.coID,
            this.colClassName,
            this.colNationaNo,
            this.ColFullName,
            this.colApplicationDate,
            this.colPassTestCount,
            this.colStatus});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(6, 150);
            this.listView1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1129, 390);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // coID
            // 
            this.coID.Text = "ID";
            // 
            // colClassName
            // 
            this.colClassName.Text = "ClassName";
            this.colClassName.Width = 240;
            // 
            // colNationaNo
            // 
            this.colNationaNo.Text = "NationaNo";
            this.colNationaNo.Width = 100;
            // 
            // ColFullName
            // 
            this.ColFullName.Text = "FullName";
            this.ColFullName.Width = 320;
            // 
            // colApplicationDate
            // 
            this.colApplicationDate.Text = "ApplicationDate";
            this.colApplicationDate.Width = 160;
            // 
            // colPassTestCount
            // 
            this.colPassTestCount.Text = "PassTestCount";
            this.colPassTestCount.Width = 140;
            // 
            // colStatus
            // 
            this.colStatus.Text = "Status";
            this.colStatus.Width = 100;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationDetailsToolStripMenuItem,
            this.editApplicationToolStripMenuItem,
            this.deleteApplicationToolStripMenuItem,
            this.cancelApplicationToolStripMenuItem,
            this.scheduleTestToolStripMenuItem,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.showPersonLicenseHistoryToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(318, 293);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // applicationDetailsToolStripMenuItem
            // 
            this.applicationDetailsToolStripMenuItem.Image = global::DVLD__UI.Properties.Resources.forbidden__2_;
            this.applicationDetailsToolStripMenuItem.Name = "applicationDetailsToolStripMenuItem";
            this.applicationDetailsToolStripMenuItem.Size = new System.Drawing.Size(317, 32);
            this.applicationDetailsToolStripMenuItem.Text = "Application Details";
            this.applicationDetailsToolStripMenuItem.Click += new System.EventHandler(this.applicationDetailsToolStripMenuItem_Click);
            // 
            // editApplicationToolStripMenuItem
            // 
            this.editApplicationToolStripMenuItem.Image = global::DVLD__UI.Properties.Resources.reload;
            this.editApplicationToolStripMenuItem.Name = "editApplicationToolStripMenuItem";
            this.editApplicationToolStripMenuItem.Size = new System.Drawing.Size(317, 32);
            this.editApplicationToolStripMenuItem.Text = "Edit Application";
            // 
            // deleteApplicationToolStripMenuItem
            // 
            this.deleteApplicationToolStripMenuItem.Image = global::DVLD__UI.Properties.Resources.forbidden__6_;
            this.deleteApplicationToolStripMenuItem.Name = "deleteApplicationToolStripMenuItem";
            this.deleteApplicationToolStripMenuItem.Size = new System.Drawing.Size(317, 32);
            this.deleteApplicationToolStripMenuItem.Text = "Delete Application";
            // 
            // cancelApplicationToolStripMenuItem
            // 
            this.cancelApplicationToolStripMenuItem.Image = global::DVLD__UI.Properties.Resources.cross1;
            this.cancelApplicationToolStripMenuItem.Name = "cancelApplicationToolStripMenuItem";
            this.cancelApplicationToolStripMenuItem.Size = new System.Drawing.Size(317, 32);
            this.cancelApplicationToolStripMenuItem.Text = "Cancel Application";
            this.cancelApplicationToolStripMenuItem.Click += new System.EventHandler(this.cancelApplicationToolStripMenuItem_Click);
            // 
            // scheduleTestToolStripMenuItem
            // 
            this.scheduleTestToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scheduleViewTestToolStripMenuItem,
            this.scheduleWrittenTestToolStripMenuItem,
            this.schedulePracticalTestToolStripMenuItem});
            this.scheduleTestToolStripMenuItem.Image = global::DVLD__UI.Properties.Resources.forbidden;
            this.scheduleTestToolStripMenuItem.Name = "scheduleTestToolStripMenuItem";
            this.scheduleTestToolStripMenuItem.Size = new System.Drawing.Size(317, 32);
            this.scheduleTestToolStripMenuItem.Text = "Schedule Test";
            this.scheduleTestToolStripMenuItem.MouseHover += new System.EventHandler(this.scheduleTestToolStripMenuItem_MouseHover);
            // 
            // scheduleViewTestToolStripMenuItem
            // 
            this.scheduleViewTestToolStripMenuItem.Image = global::DVLD__UI.Properties.Resources.eye;
            this.scheduleViewTestToolStripMenuItem.Name = "scheduleViewTestToolStripMenuItem";
            this.scheduleViewTestToolStripMenuItem.Size = new System.Drawing.Size(289, 34);
            this.scheduleViewTestToolStripMenuItem.Text = "Schedule Looking Test";
            this.scheduleViewTestToolStripMenuItem.Click += new System.EventHandler(this.scheduleViewTestToolStripMenuItem_Click);
            // 
            // scheduleWrittenTestToolStripMenuItem
            // 
            this.scheduleWrittenTestToolStripMenuItem.Enabled = false;
            this.scheduleWrittenTestToolStripMenuItem.Image = global::DVLD__UI.Properties.Resources.forbidden__5_;
            this.scheduleWrittenTestToolStripMenuItem.Name = "scheduleWrittenTestToolStripMenuItem";
            this.scheduleWrittenTestToolStripMenuItem.Size = new System.Drawing.Size(289, 34);
            this.scheduleWrittenTestToolStripMenuItem.Text = "Schedule Written Test";
            this.scheduleWrittenTestToolStripMenuItem.Click += new System.EventHandler(this.scheduleWrittenTestToolStripMenuItem_Click);
            // 
            // schedulePracticalTestToolStripMenuItem
            // 
            this.schedulePracticalTestToolStripMenuItem.Enabled = false;
            this.schedulePracticalTestToolStripMenuItem.Image = global::DVLD__UI.Properties.Resources.light_bulb;
            this.schedulePracticalTestToolStripMenuItem.Name = "schedulePracticalTestToolStripMenuItem";
            this.schedulePracticalTestToolStripMenuItem.Size = new System.Drawing.Size(289, 34);
            this.schedulePracticalTestToolStripMenuItem.Text = "Schedule Practical Test";
            this.schedulePracticalTestToolStripMenuItem.Click += new System.EventHandler(this.schedulePracticalTestToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Image = global::DVLD__UI.Properties.Resources.card;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(317, 32);
            this.toolStripMenuItem4.Text = "Issue Driving License";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Enabled = false;
            this.toolStripMenuItem5.Image = global::DVLD__UI.Properties.Resources.forbidden__3_;
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(317, 32);
            this.toolStripMenuItem5.Text = "Show License";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // showPersonLicenseHistoryToolStripMenuItem1
            // 
            this.showPersonLicenseHistoryToolStripMenuItem1.Image = global::DVLD__UI.Properties.Resources.list;
            this.showPersonLicenseHistoryToolStripMenuItem1.Name = "showPersonLicenseHistoryToolStripMenuItem1";
            this.showPersonLicenseHistoryToolStripMenuItem1.Size = new System.Drawing.Size(317, 32);
            this.showPersonLicenseHistoryToolStripMenuItem1.Text = "Show Person License History";
            this.showPersonLicenseHistoryToolStripMenuItem1.Click += new System.EventHandler(this.showPersonLicenseHistoryToolStripMenuItem1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD__UI.Properties.Resources.folder;
            this.pictureBox1.Location = new System.Drawing.Point(1048, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ListLocalLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 617);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListLocalLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListLocalLicense";
            this.Load += new System.EventHandler(this.ListLocalLicense_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader coID;
        private System.Windows.Forms.ColumnHeader colNationaNo;
        private System.Windows.Forms.ColumnHeader ColFullName;
        private System.Windows.Forms.ColumnHeader colApplicationDate;
        private System.Windows.Forms.ColumnHeader colClassName;
        private System.Windows.Forms.ColumnHeader colPassTestCount;
        private System.Windows.Forms.ColumnHeader colStatus;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem applicationDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleViewTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleWrittenTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schedulePracticalTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}