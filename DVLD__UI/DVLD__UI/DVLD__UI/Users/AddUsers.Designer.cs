namespace DVLD__UI
{
    partial class AddUsers
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.userData1 = new DVLD__UI.SearchForPerson();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.userData1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(764, 549);
            this.panel1.TabIndex = 1;
            // 
            // userData1
            // 
            this.userData1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.userData1.Location = new System.Drawing.Point(2, 5);
            this.userData1.Margin = new System.Windows.Forms.Padding(2);
            this.userData1.Name = "userData1";
            this.userData1.Size = new System.Drawing.Size(764, 542);
            this.userData1.TabIndex = 0;
            this.userData1.GoNext += new System.Action<bool>(this.userData1_GoNext);
            this.userData1.OnClose += new System.Action<bool>(this.userData1_OnClose);
            this.userData1.Load += new System.EventHandler(this.userData1_Load);
            // 
            // AddUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 548);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddUsers";
            this.Load += new System.EventHandler(this.AddUsers_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SearchForPerson userData1;
        private System.Windows.Forms.Panel panel1;
    }
}