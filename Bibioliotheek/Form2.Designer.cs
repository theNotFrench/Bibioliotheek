namespace Bibioliotheek
{
    partial class Form2
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
            this.btnToevoegen = new System.Windows.Forms.Button();
            this.lbltitel = new System.Windows.Forms.Label();
            this.lbljaar = new System.Windows.Forms.Label();
            this.txttitel = new System.Windows.Forms.TextBox();
            this.txtjaar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnToevoegen
            // 
            this.btnToevoegen.Location = new System.Drawing.Point(12, 125);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Size = new System.Drawing.Size(252, 54);
            this.btnToevoegen.TabIndex = 0;
            this.btnToevoegen.Text = "Toevoegen";
            this.btnToevoegen.UseVisualStyleBackColor = true;
            this.btnToevoegen.Click += new System.EventHandler(this.btnToevoegen_Click);
            // 
            // lbltitel
            // 
            this.lbltitel.AutoSize = true;
            this.lbltitel.Location = new System.Drawing.Point(12, 33);
            this.lbltitel.Name = "lbltitel";
            this.lbltitel.Size = new System.Drawing.Size(26, 13);
            this.lbltitel.TabIndex = 1;
            this.lbltitel.Text = "titel:";
            // 
            // lbljaar
            // 
            this.lbljaar.AutoSize = true;
            this.lbljaar.Location = new System.Drawing.Point(12, 78);
            this.lbljaar.Name = "lbljaar";
            this.lbljaar.Size = new System.Drawing.Size(27, 13);
            this.lbljaar.TabIndex = 2;
            this.lbljaar.Text = "jaar:";
            // 
            // txttitel
            // 
            this.txttitel.Location = new System.Drawing.Point(106, 30);
            this.txttitel.Name = "txttitel";
            this.txttitel.Size = new System.Drawing.Size(158, 20);
            this.txttitel.TabIndex = 3;
            // 
            // txtjaar
            // 
            this.txtjaar.Location = new System.Drawing.Point(106, 75);
            this.txtjaar.Name = "txtjaar";
            this.txtjaar.Size = new System.Drawing.Size(158, 20);
            this.txtjaar.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(287, 192);
            this.Controls.Add(this.txtjaar);
            this.Controls.Add(this.txttitel);
            this.Controls.Add(this.lbljaar);
            this.Controls.Add(this.lbltitel);
            this.Controls.Add(this.btnToevoegen);
            this.Name = "Form2";
            this.Text = "toevoegen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnToevoegen;
        private System.Windows.Forms.Label lbltitel;
        private System.Windows.Forms.Label lbljaar;
        private System.Windows.Forms.TextBox txttitel;
        private System.Windows.Forms.TextBox txtjaar;
    }
}