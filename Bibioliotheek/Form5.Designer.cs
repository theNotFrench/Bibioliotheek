namespace Bibioliotheek
{
    partial class frmLogin
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
            this.txtwachtwoord = new System.Windows.Forms.TextBox();
            this.lblWUsername = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.lblusername = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtwachtwoord
            // 
            this.txtwachtwoord.Location = new System.Drawing.Point(103, 49);
            this.txtwachtwoord.Name = "txtwachtwoord";
            this.txtwachtwoord.Size = new System.Drawing.Size(158, 20);
            this.txtwachtwoord.TabIndex = 21;
            // 
            // lblWUsername
            // 
            this.lblWUsername.AutoSize = true;
            this.lblWUsername.Location = new System.Drawing.Point(9, 52);
            this.lblWUsername.Name = "lblWUsername";
            this.lblWUsername.Size = new System.Drawing.Size(71, 13);
            this.lblWUsername.TabIndex = 20;
            this.lblWUsername.Text = "Wachtwoord:";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(12, 99);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(249, 47);
            this.btnLogin.TabIndex = 19;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(103, 23);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(158, 20);
            this.txtusername.TabIndex = 17;
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Location = new System.Drawing.Point(9, 26);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(87, 13);
            this.lblusername.TabIndex = 15;
            this.lblusername.Text = "Gebruikersnaam:";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(273, 166);
            this.Controls.Add(this.txtwachtwoord);
            this.Controls.Add(this.lblWUsername);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.lblusername);
            this.Name = "frmLogin";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtwachtwoord;
        private System.Windows.Forms.Label lblWUsername;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label lblusername;
    }
}