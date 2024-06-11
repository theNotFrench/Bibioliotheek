namespace Bibioliotheek
{
    partial class frmRegister
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
            this.txtGebruikersnaam = new System.Windows.Forms.TextBox();
            this.lblWUsername = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtWachtwoord = new System.Windows.Forms.TextBox();
            this.txtnaam = new System.Windows.Forms.TextBox();
            this.lblWachtwoord = new System.Windows.Forms.Label();
            this.lblnaam = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtGebruikersnaam
            // 
            this.txtGebruikersnaam.Location = new System.Drawing.Point(103, 49);
            this.txtGebruikersnaam.Name = "txtGebruikersnaam";
            this.txtGebruikersnaam.Size = new System.Drawing.Size(158, 20);
            this.txtGebruikersnaam.TabIndex = 14;
            // 
            // lblWUsername
            // 
            this.lblWUsername.AutoSize = true;
            this.lblWUsername.Location = new System.Drawing.Point(9, 52);
            this.lblWUsername.Name = "lblWUsername";
            this.lblWUsername.Size = new System.Drawing.Size(87, 13);
            this.lblWUsername.TabIndex = 13;
            this.lblWUsername.Text = "Gebruikersnaam:";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(12, 122);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(249, 47);
            this.btnRegister.TabIndex = 12;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtWachtwoord
            // 
            this.txtWachtwoord.Location = new System.Drawing.Point(103, 75);
            this.txtWachtwoord.Name = "txtWachtwoord";
            this.txtWachtwoord.Size = new System.Drawing.Size(158, 20);
            this.txtWachtwoord.TabIndex = 11;
            this.txtWachtwoord.UseSystemPasswordChar = true;
            // 
            // txtnaam
            // 
            this.txtnaam.Location = new System.Drawing.Point(103, 23);
            this.txtnaam.Name = "txtnaam";
            this.txtnaam.Size = new System.Drawing.Size(158, 20);
            this.txtnaam.TabIndex = 10;
            // 
            // lblWachtwoord
            // 
            this.lblWachtwoord.AutoSize = true;
            this.lblWachtwoord.Location = new System.Drawing.Point(9, 78);
            this.lblWachtwoord.Name = "lblWachtwoord";
            this.lblWachtwoord.Size = new System.Drawing.Size(68, 13);
            this.lblWachtwoord.TabIndex = 9;
            this.lblWachtwoord.Text = "wachtwoord:";
            // 
            // lblnaam
            // 
            this.lblnaam.AutoSize = true;
            this.lblnaam.Location = new System.Drawing.Point(9, 26);
            this.lblnaam.Name = "lblnaam";
            this.lblnaam.Size = new System.Drawing.Size(38, 13);
            this.lblnaam.TabIndex = 8;
            this.lblnaam.Text = "Naam:";
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(275, 189);
            this.Controls.Add(this.txtGebruikersnaam);
            this.Controls.Add(this.lblWUsername);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtWachtwoord);
            this.Controls.Add(this.txtnaam);
            this.Controls.Add(this.lblWachtwoord);
            this.Controls.Add(this.lblnaam);
            this.Name = "frmRegister";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGebruikersnaam;
        private System.Windows.Forms.Label lblWUsername;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtWachtwoord;
        private System.Windows.Forms.TextBox txtnaam;
        private System.Windows.Forms.Label lblWachtwoord;
        private System.Windows.Forms.Label lblnaam;
    }
}