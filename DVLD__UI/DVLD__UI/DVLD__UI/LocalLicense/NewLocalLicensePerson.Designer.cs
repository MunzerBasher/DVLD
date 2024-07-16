namespace DVLD__UI.Users
{
    partial class NewLocalLicensePerson
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
            this.searchForPerson1 = new DVLD__UI.SearchForPerson();
            this.SuspendLayout();
            // 
            // searchForPerson1
            // 
            this.searchForPerson1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.searchForPerson1.Location = new System.Drawing.Point(1, -1);
            this.searchForPerson1.Margin = new System.Windows.Forms.Padding(2);
            this.searchForPerson1.Name = "searchForPerson1";
            this.searchForPerson1.Size = new System.Drawing.Size(764, 542);
            this.searchForPerson1.TabIndex = 0;
            this.searchForPerson1.GoNext += new System.Action<bool>(this.searchForPerson1_GoNext);
            this.searchForPerson1.OnClose += new System.Action<bool>(this.searchForPerson1_OnClose);
            // 
            // NewLocalLicensePerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 548);
            this.Controls.Add(this.searchForPerson1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewLocalLicensePerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewLocalLicense";
            this.ResumeLayout(false);

        }

        #endregion

        private SearchForPerson searchForPerson1;
    }
}