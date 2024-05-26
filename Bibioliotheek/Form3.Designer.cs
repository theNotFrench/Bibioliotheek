namespace Bibioliotheek
{
    partial class frmUpdate
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
            this.txtjaar = new System.Windows.Forms.TextBox();
            this.txttitel = new System.Windows.Forms.TextBox();
            this.lbljaar = new System.Windows.Forms.Label();
            this.lbltitel = new System.Windows.Forms.Label();
            this.btnUpdaten = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtjaar
            // 
            this.txtjaar.Location = new System.Drawing.Point(106, 66);
            this.txtjaar.Name = "txtjaar";
            this.txtjaar.Size = new System.Drawing.Size(158, 20);
            this.txtjaar.TabIndex = 9;
            // 
            // txttitel
            // 
            this.txttitel.Location = new System.Drawing.Point(106, 21);
            this.txttitel.Name = "txttitel";
            this.txttitel.Size = new System.Drawing.Size(158, 20);
            this.txttitel.TabIndex = 8;
            // 
            // lbljaar
            // 
            this.lbljaar.AutoSize = true;
            this.lbljaar.Location = new System.Drawing.Point(12, 69);
            this.lbljaar.Name = "lbljaar";
            this.lbljaar.Size = new System.Drawing.Size(27, 13);
            this.lbljaar.TabIndex = 7;
            this.lbljaar.Text = "jaar:";
            // 
            // lbltitel
            // 
            this.lbltitel.AutoSize = true;
            this.lbltitel.Location = new System.Drawing.Point(12, 24);
            this.lbltitel.Name = "lbltitel";
            this.lbltitel.Size = new System.Drawing.Size(26, 13);
            this.lbltitel.TabIndex = 6;
            this.lbltitel.Text = "titel:";
            // 
            // btnUpdaten
            // 
            this.btnUpdaten.Location = new System.Drawing.Point(12, 116);
            this.btnUpdaten.Name = "btnUpdaten";
            this.btnUpdaten.Size = new System.Drawing.Size(252, 54);
            this.btnUpdaten.TabIndex = 5;
            this.btnUpdaten.Text = "Update";
            this.btnUpdaten.UseVisualStyleBackColor = true;
            this.btnUpdaten.Click += new System.EventHandler(this.btnUpdaten_Click);
            // 
            // frmUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(283, 176);
            this.Controls.Add(this.txtjaar);
            this.Controls.Add(this.txttitel);
            this.Controls.Add(this.lbljaar);
            this.Controls.Add(this.lbltitel);
            this.Controls.Add(this.btnUpdaten);
            this.Name = "frmUpdate";
            this.Text = "Update";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtjaar;
        private System.Windows.Forms.TextBox txttitel;
        private System.Windows.Forms.Label lbljaar;
        private System.Windows.Forms.Label lbltitel;
        private System.Windows.Forms.Button btnUpdaten;
    }
}