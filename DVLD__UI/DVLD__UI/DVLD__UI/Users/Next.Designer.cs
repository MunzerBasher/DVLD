namespace DVLD__UI.Users
{
    partial class Next
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
            this.userNext1 = new DVLD__UI.Users.UserNext();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // userNext1
            // 
            this.userNext1.ConFirmPassword = "";
            this.userNext1.Description = "label2";
            this.userNext1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.userNext1.Location = new System.Drawing.Point(-4, 4);
            this.userNext1.Margin = new System.Windows.Forms.Padding(4);
            this.userNext1.Name = "userNext1";
            this.userNext1.Size = new System.Drawing.Size(782, 577);
            this.userNext1.TabIndex = 0;
            this.userNext1.Title = "label1";
            this.userNext1.UserName = "";
            this.userNext1.UserPassword = "";
            this.userNext1.OnSave += new System.Action<bool>(this.userNext1_OnSave);
            this.userNext1.OnClose += new System.Action<bool>(this.userNext1_OnClose);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Next
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 575);
            this.Controls.Add(this.userNext1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Next";
            this.Text = "Next";
            this.Load += new System.EventHandler(this.Next_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UserNext userNext1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}