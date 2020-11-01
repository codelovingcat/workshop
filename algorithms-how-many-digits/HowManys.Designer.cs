namespace algorithms_how_many_digits
{
    partial class HowManys
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
            this.btnBasamak = new System.Windows.Forms.Button();
            this.txtBasamak = new System.Windows.Forms.TextBox();
            this.lblBasamak = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBasamak
            // 
            this.btnBasamak.BackColor = System.Drawing.Color.Red;
            this.btnBasamak.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnBasamak.Font = new System.Drawing.Font("Minion Pro SmBd", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBasamak.ForeColor = System.Drawing.Color.White;
            this.btnBasamak.Location = new System.Drawing.Point(392, 75);
            this.btnBasamak.Name = "btnBasamak";
            this.btnBasamak.Size = new System.Drawing.Size(129, 40);
            this.btnBasamak.TabIndex = 0;
            this.btnBasamak.Text = "Kaç Basamak";
            this.btnBasamak.UseVisualStyleBackColor = false;
            this.btnBasamak.Click += new System.EventHandler(this.btnBasamak_Click);
            // 
            // txtBasamak
            // 
            this.txtBasamak.Font = new System.Drawing.Font("Minion Pro SmBd", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBasamak.Location = new System.Drawing.Point(195, 75);
            this.txtBasamak.Name = "txtBasamak";
            this.txtBasamak.Size = new System.Drawing.Size(190, 40);
            this.txtBasamak.TabIndex = 1;
            // 
            // lblBasamak
            // 
            this.lblBasamak.AutoSize = true;
            this.lblBasamak.Font = new System.Drawing.Font("Minion Pro SmBd", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBasamak.Location = new System.Drawing.Point(188, 146);
            this.lblBasamak.Name = "lblBasamak";
            this.lblBasamak.Size = new System.Drawing.Size(32, 27);
            this.lblBasamak.TabIndex = 2;
            this.lblBasamak.Text = "00";
            // 
            // HowManys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::algorithms_how_many_digits.Properties.Resources._38116_200;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(641, 265);
            this.Controls.Add(this.lblBasamak);
            this.Controls.Add(this.txtBasamak);
            this.Controls.Add(this.btnBasamak);
            this.Name = "HowManys";
            this.Text = "Sayı Kaç Basamaklı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBasamak;
        private System.Windows.Forms.TextBox txtBasamak;
        private System.Windows.Forms.Label lblBasamak;
    }
}

