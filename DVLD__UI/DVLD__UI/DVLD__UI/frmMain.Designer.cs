namespace DVLD__UI
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.applicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drivingLicenseServicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internationalLicenseToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reNewDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replacementForLossOrDamagedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.releaseDetainedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.remakeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localDrivingLicenseApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internationalLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageDetainLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detainLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.releaseDetainLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageApplicationTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageTestTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peopleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.driversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentUserInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationToolStripMenuItem,
            this.peopleToolStripMenuItem,
            this.driversToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.userInformationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1924, 58);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::DVLD__UI.Properties.Resources.forbidden__8_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 58);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1924, 992);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // applicationToolStripMenuItem
            // 
            this.applicationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drivingLicenseServicesToolStripMenuItem,
            this.manaToolStripMenuItem,
            this.detailesToolStripMenuItem,
            this.manageApplicationTypesToolStripMenuItem,
            this.manageTestTypesToolStripMenuItem});
            this.applicationToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.applicationToolStripMenuItem.Image = global::DVLD__UI.Properties.Resources.menu_bars;
            this.applicationToolStripMenuItem.Name = "applicationToolStripMenuItem";
            this.applicationToolStripMenuItem.Size = new System.Drawing.Size(269, 52);
            this.applicationToolStripMenuItem.Text = "&Applications";
            // 
            // drivingLicenseServicesToolStripMenuItem
            // 
            this.drivingLicenseServicesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.reNewDrivingLicenseToolStripMenuItem,
            this.replacementForLossOrDamagedToolStripMenuItem,
            this.releaseDetainedToolStripMenuItem,
            this.remakeTestToolStripMenuItem});
            this.drivingLicenseServicesToolStripMenuItem.Image = global::DVLD__UI.Properties.Resources.computer;
            this.drivingLicenseServicesToolStripMenuItem.Name = "drivingLicenseServicesToolStripMenuItem";
            this.drivingLicenseServicesToolStripMenuItem.Size = new System.Drawing.Size(573, 56);
            this.drivingLicenseServicesToolStripMenuItem.Text = "Driving License  Services";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localLicenseToolStripMenuItem,
            this.internationalLicenseToolStripMenuItem1});
            this.newToolStripMenuItem.Image = global::DVLD__UI.Properties.Resources.add__1_;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(716, 56);
            this.newToolStripMenuItem.Text = "New  Driving License";
            // 
            // localLicenseToolStripMenuItem
            // 
            this.localLicenseToolStripMenuItem.Image = global::DVLD__UI.Properties.Resources.driver;
            this.localLicenseToolStripMenuItem.Name = "localLicenseToolStripMenuItem";
            this.localLicenseToolStripMenuItem.Size = new System.Drawing.Size(489, 56);
            this.localLicenseToolStripMenuItem.Text = "Local  License ";
            this.localLicenseToolStripMenuItem.Click += new System.EventHandler(this.localLicenseToolStripMenuItem_Click);
            // 
            // internationalLicenseToolStripMenuItem1
            // 
            this.internationalLicenseToolStripMenuItem1.Image = global::DVLD__UI.Properties.Resources.computer;
            this.internationalLicenseToolStripMenuItem1.Name = "internationalLicenseToolStripMenuItem1";
            this.internationalLicenseToolStripMenuItem1.Size = new System.Drawing.Size(489, 56);
            this.internationalLicenseToolStripMenuItem1.Text = "International License ";
            this.internationalLicenseToolStripMenuItem1.Click += new System.EventHandler(this.internationalLicenseToolStripMenuItem1_Click);
            // 
            // reNewDrivingLicenseToolStripMenuItem
            // 
            this.reNewDrivingLicenseToolStripMenuItem.Image = global::DVLD__UI.Properties.Resources.reload;
            this.reNewDrivingLicenseToolStripMenuItem.Name = "reNewDrivingLicenseToolStripMenuItem";
            this.reNewDrivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(716, 56);
            this.reNewDrivingLicenseToolStripMenuItem.Text = "ReNew  Driving License";
            this.reNewDrivingLicenseToolStripMenuItem.Click += new System.EventHandler(this.reNewDrivingLicenseToolStripMenuItem_Click);
            // 
            // replacementForLossOrDamagedToolStripMenuItem
            // 
            this.replacementForLossOrDamagedToolStripMenuItem.Image = global::DVLD__UI.Properties.Resources.folder;
            this.replacementForLossOrDamagedToolStripMenuItem.Name = "replacementForLossOrDamagedToolStripMenuItem";
            this.replacementForLossOrDamagedToolStripMenuItem.Size = new System.Drawing.Size(716, 56);
            this.replacementForLossOrDamagedToolStripMenuItem.Text = "Replacement For Loss Or Damaged";
            this.replacementForLossOrDamagedToolStripMenuItem.Click += new System.EventHandler(this.replacementForLossOrDamagedToolStripMenuItem_Click);
            // 
            // releaseDetainedToolStripMenuItem
            // 
            this.releaseDetainedToolStripMenuItem.Image = global::DVLD__UI.Properties.Resources.forbidden;
            this.releaseDetainedToolStripMenuItem.Name = "releaseDetainedToolStripMenuItem";
            this.releaseDetainedToolStripMenuItem.Size = new System.Drawing.Size(716, 56);
            this.releaseDetainedToolStripMenuItem.Text = "Release Detained Driving License";
            // 
            // remakeTestToolStripMenuItem
            // 
            this.remakeTestToolStripMenuItem.Image = global::DVLD__UI.Properties.Resources.forbidden__1_;
            this.remakeTestToolStripMenuItem.Name = "remakeTestToolStripMenuItem";
            this.remakeTestToolStripMenuItem.Size = new System.Drawing.Size(716, 56);
            this.remakeTestToolStripMenuItem.Text = "Retake Test";
            this.remakeTestToolStripMenuItem.Click += new System.EventHandler(this.remakeTestToolStripMenuItem_Click);
            // 
            // manaToolStripMenuItem
            // 
            this.manaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localDrivingLicenseApplicationsToolStripMenuItem,
            this.internationalLicenseToolStripMenuItem});
            this.manaToolStripMenuItem.Image = global::DVLD__UI.Properties.Resources.gear;
            this.manaToolStripMenuItem.Name = "manaToolStripMenuItem";
            this.manaToolStripMenuItem.Size = new System.Drawing.Size(573, 56);
            this.manaToolStripMenuItem.Text = "Manage Applications";
            // 
            // localDrivingLicenseApplicationsToolStripMenuItem
            // 
            this.localDrivingLicenseApplicationsToolStripMenuItem.Image = global::DVLD__UI.Properties.Resources.driver;
            this.localDrivingLicenseApplicationsToolStripMenuItem.Name = "localDrivingLicenseApplicationsToolStripMenuItem";
            this.localDrivingLicenseApplicationsToolStripMenuItem.Size = new System.Drawing.Size(833, 56);
            this.localDrivingLicenseApplicationsToolStripMenuItem.Text = "Local Driving License Applications";
            this.localDrivingLicenseApplicationsToolStripMenuItem.Click += new System.EventHandler(this.localDrivingLicenseApplicationsToolStripMenuItem_Click);
            // 
            // internationalLicenseToolStripMenuItem
            // 
            this.internationalLicenseToolStripMenuItem.Image = global::DVLD__UI.Properties.Resources.computer;
            this.internationalLicenseToolStripMenuItem.Name = "internationalLicenseToolStripMenuItem";
            this.internationalLicenseToolStripMenuItem.Size = new System.Drawing.Size(833, 56);
            this.internationalLicenseToolStripMenuItem.Text = "International Driving License Applications";
            // 
            // detailesToolStripMenuItem
            // 
            this.detailesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageDetainLicenseToolStripMenuItem,
            this.detainLicenseToolStripMenuItem,
            this.releaseDetainLicenseToolStripMenuItem});
            this.detailesToolStripMenuItem.Image = global::DVLD__UI.Properties.Resources.info;
            this.detailesToolStripMenuItem.Name = "detailesToolStripMenuItem";
            this.detailesToolStripMenuItem.Size = new System.Drawing.Size(573, 56);
            this.detailesToolStripMenuItem.Text = "Detain  Licenses";
            // 
            // manageDetainLicenseToolStripMenuItem
            // 
            this.manageDetainLicenseToolStripMenuItem.Image = global::DVLD__UI.Properties.Resources.gear;
            this.manageDetainLicenseToolStripMenuItem.Name = "manageDetainLicenseToolStripMenuItem";
            this.manageDetainLicenseToolStripMenuItem.Size = new System.Drawing.Size(553, 56);
            this.manageDetainLicenseToolStripMenuItem.Text = "Manage Detain  Licenses ";
            this.manageDetainLicenseToolStripMenuItem.Click += new System.EventHandler(this.manageDetainLicenseToolStripMenuItem_Click);
            // 
            // detainLicenseToolStripMenuItem
            // 
            this.detainLicenseToolStripMenuItem.Image = global::DVLD__UI.Properties.Resources.cross1;
            this.detainLicenseToolStripMenuItem.Name = "detainLicenseToolStripMenuItem";
            this.detainLicenseToolStripMenuItem.Size = new System.Drawing.Size(553, 56);
            this.detainLicenseToolStripMenuItem.Text = "Detain  License ";
            this.detainLicenseToolStripMenuItem.Click += new System.EventHandler(this.detainLicenseToolStripMenuItem_Click);
            // 
            // releaseDetainLicenseToolStripMenuItem
            // 
            this.releaseDetainLicenseToolStripMenuItem.Image = global::DVLD__UI.Properties.Resources.forbidden;
            this.releaseDetainLicenseToolStripMenuItem.Name = "releaseDetainLicenseToolStripMenuItem";
            this.releaseDetainLicenseToolStripMenuItem.Size = new System.Drawing.Size(553, 56);
            this.releaseDetainLicenseToolStripMenuItem.Text = "Release Detain  License ";
            this.releaseDetainLicenseToolStripMenuItem.Click += new System.EventHandler(this.releaseDetainLicenseToolStripMenuItem_Click);
            // 
            // manageApplicationTypesToolStripMenuItem
            // 
            this.manageApplicationTypesToolStripMenuItem.Image = global::DVLD__UI.Properties.Resources.gear;
            this.manageApplicationTypesToolStripMenuItem.Name = "manageApplicationTypesToolStripMenuItem";
            this.manageApplicationTypesToolStripMenuItem.Size = new System.Drawing.Size(573, 56);
            this.manageApplicationTypesToolStripMenuItem.Text = "Manage Application Types";
            this.manageApplicationTypesToolStripMenuItem.Click += new System.EventHandler(this.manageApplicationTypesToolStripMenuItem_Click);
            // 
            // manageTestTypesToolStripMenuItem
            // 
            this.manageTestTypesToolStripMenuItem.Image = global::DVLD__UI.Properties.Resources.gear__1_;
            this.manageTestTypesToolStripMenuItem.Name = "manageTestTypesToolStripMenuItem";
            this.manageTestTypesToolStripMenuItem.Size = new System.Drawing.Size(573, 56);
            this.manageTestTypesToolStripMenuItem.Text = "Manage Test Types";
            this.manageTestTypesToolStripMenuItem.Click += new System.EventHandler(this.manageTestTypesToolStripMenuItem_Click);
            // 
            // peopleToolStripMenuItem
            // 
            this.peopleToolStripMenuItem.Image = global::DVLD__UI.Properties.Resources.classmate__1_;
            this.peopleToolStripMenuItem.Name = "peopleToolStripMenuItem";
            this.peopleToolStripMenuItem.Size = new System.Drawing.Size(173, 52);
            this.peopleToolStripMenuItem.Text = "&People";
            this.peopleToolStripMenuItem.Click += new System.EventHandler(this.peopleToolStripMenuItem_Click);
            // 
            // driversToolStripMenuItem
            // 
            this.driversToolStripMenuItem.Image = global::DVLD__UI.Properties.Resources.bus_driver;
            this.driversToolStripMenuItem.Name = "driversToolStripMenuItem";
            this.driversToolStripMenuItem.Size = new System.Drawing.Size(180, 52);
            this.driversToolStripMenuItem.Text = "&Drivers";
            this.driversToolStripMenuItem.Click += new System.EventHandler(this.driversToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Image = global::DVLD__UI.Properties.Resources.classmate;
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(151, 52);
            this.usersToolStripMenuItem.Text = "&Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // userInformationToolStripMenuItem
            // 
            this.userInformationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentUserInfoToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.userInformationToolStripMenuItem.Image = global::DVLD__UI.Properties.Resources.card;
            this.userInformationToolStripMenuItem.Name = "userInformationToolStripMenuItem";
            this.userInformationToolStripMenuItem.Size = new System.Drawing.Size(348, 52);
            this.userInformationToolStripMenuItem.Text = "User In&formation";
            // 
            // currentUserInfoToolStripMenuItem
            // 
            this.currentUserInfoToolStripMenuItem.Image = global::DVLD__UI.Properties.Resources.forbidden__2_;
            this.currentUserInfoToolStripMenuItem.Name = "currentUserInfoToolStripMenuItem";
            this.currentUserInfoToolStripMenuItem.Size = new System.Drawing.Size(425, 56);
            this.currentUserInfoToolStripMenuItem.Text = "&Current User Info";
            this.currentUserInfoToolStripMenuItem.Click += new System.EventHandler(this.currentUserInfoToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Image = global::DVLD__UI.Properties.Resources.reload;
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(425, 56);
            this.changePasswordToolStripMenuItem.Text = "Chan&ge Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::DVLD__UI.Properties.Resources.forbidden__3_;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(425, 56);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Move += new System.EventHandler(this.Form1_Move);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem applicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peopleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem driversToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drivingLicenseServicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageApplicationTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageTestTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internationalLicenseToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reNewDrivingLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currentUserInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localDrivingLicenseApplicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internationalLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replacementForLossOrDamagedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem releaseDetainedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem remakeTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageDetainLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detainLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem releaseDetainLicenseToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

