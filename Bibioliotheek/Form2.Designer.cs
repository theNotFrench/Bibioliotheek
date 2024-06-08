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
            this.lbltitel = new System.Windows.Forms.Label();
            this.lbljaar = new System.Windows.Forms.Label();
            this.txttitel = new System.Windows.Forms.TextBox();
            this.txtjaar = new System.Windows.Forms.TextBox();
            this.btnToevoegen = new System.Windows.Forms.Button();
            this.txtProducer = new System.Windows.Forms.TextBox();
            this.lblproducer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbltitel
            // 
            this.lbltitel.AutoSize = true;
            this.lbltitel.Location = new System.Drawing.Point(9, 25);
            this.lbltitel.Name = "lbltitel";
            this.lbltitel.Size = new System.Drawing.Size(26, 13);
            this.lbltitel.TabIndex = 1;
            this.lbltitel.Text = "titel:";
            // 
            // lbljaar
            // 
            this.lbljaar.AutoSize = true;
            this.lbljaar.Location = new System.Drawing.Point(9, 77);
            this.lbljaar.Name = "lbljaar";
            this.lbljaar.Size = new System.Drawing.Size(27, 13);
            this.lbljaar.TabIndex = 2;
            this.lbljaar.Text = "jaar:";
            // 
            // txttitel
            // 
            this.txttitel.Location = new System.Drawing.Point(103, 22);
            this.txttitel.Name = "txttitel";
            this.txttitel.Size = new System.Drawing.Size(158, 20);
            this.txttitel.TabIndex = 3;
            // 
            // txtjaar
            // 
            this.txtjaar.Location = new System.Drawing.Point(103, 74);
            this.txtjaar.Name = "txtjaar";
            this.txtjaar.Size = new System.Drawing.Size(158, 20);
            this.txtjaar.TabIndex = 4;
            // 
            // btnToevoegen
            // 
            this.btnToevoegen.Location = new System.Drawing.Point(12, 121);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Size = new System.Drawing.Size(249, 47);
            this.btnToevoegen.TabIndex = 5;
            this.btnToevoegen.Text = "Add game";
            this.btnToevoegen.UseVisualStyleBackColor = true;
            this.btnToevoegen.Click += new System.EventHandler(this.btnToevoegen_Click_1);
            // 
            // txtProducer
            // 
            this.txtProducer.Location = new System.Drawing.Point(103, 48);
            this.txtProducer.Name = "txtProducer";
            this.txtProducer.Size = new System.Drawing.Size(158, 20);
            this.txtProducer.TabIndex = 7;
            // 
            // lblproducer
            // 
            this.lblproducer.AutoSize = true;
            this.lblproducer.Location = new System.Drawing.Point(9, 51);
            this.lblproducer.Name = "lblproducer";
            this.lblproducer.Size = new System.Drawing.Size(52, 13);
            this.lblproducer.TabIndex = 6;
            this.lblproducer.Text = "producer:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(278, 181);
            this.Controls.Add(this.txtProducer);
            this.Controls.Add(this.lblproducer);
            this.Controls.Add(this.btnToevoegen);
            this.Controls.Add(this.txtjaar);
            this.Controls.Add(this.txttitel);
            this.Controls.Add(this.lbljaar);
            this.Controls.Add(this.lbltitel);
            this.Name = "Form2";
            this.Text = "Add";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Label lbltitel;
        private System.Windows.Forms.Label lbljaar;
        private System.Windows.Forms.TextBox txttitel;
        private System.Windows.Forms.TextBox txtjaar;
        private System.Windows.Forms.Button btnToevoegen;
        private System.Windows.Forms.TextBox txtProducer;
        private System.Windows.Forms.Label lblproducer;
    }
}
