namespace algorithms_how_old
{
    partial class HowOld
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
            this.btnYas = new System.Windows.Forms.Button();
            this.txtByear = new System.Windows.Forms.TextBox();
            this.lblYas = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnYas
            // 
            this.btnYas.BackColor = System.Drawing.Color.Coral;
            this.btnYas.Font = new System.Drawing.Font("Minion Pro SmBd", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYas.Location = new System.Drawing.Point(356, 112);
            this.btnYas.Name = "btnYas";
            this.btnYas.Size = new System.Drawing.Size(128, 50);
            this.btnYas.TabIndex = 0;
            this.btnYas.Text = "Yaşın Kaç";
            this.btnYas.UseVisualStyleBackColor = false;
            this.btnYas.Click += new System.EventHandler(this.btnYas_Click);
            // 
            // txtByear
            // 
            this.txtByear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtByear.Font = new System.Drawing.Font("Bodoni MT Poster Compressed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtByear.Location = new System.Drawing.Point(231, 83);
            this.txtByear.Name = "txtByear";
            this.txtByear.Size = new System.Drawing.Size(110, 50);
            this.txtByear.TabIndex = 1;
            // 
            // lblYas
            // 
            this.lblYas.AutoSize = true;
            this.lblYas.Font = new System.Drawing.Font("Minion Pro SmBd", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYas.ForeColor = System.Drawing.Color.Gray;
            this.lblYas.Location = new System.Drawing.Point(237, 215);
            this.lblYas.Name = "lblYas";
            this.lblYas.Size = new System.Drawing.Size(43, 29);
            this.lblYas.TabIndex = 2;
            this.lblYas.Text = "000";
            // 
            // txtYear
            // 
            this.txtYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtYear.Font = new System.Drawing.Font("Bodoni MT Poster Compressed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYear.Location = new System.Drawing.Point(231, 139);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(110, 50);
            this.txtYear.TabIndex = 3;
            // 
            // HowOld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::algorithms_how_old.Properties.Resources.images;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(505, 294);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.lblYas);
            this.Controls.Add(this.txtByear);
            this.Controls.Add(this.btnYas);
            this.Name = "HowOld";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnYas;
        private System.Windows.Forms.TextBox txtByear;
        private System.Windows.Forms.Label lblYas;
        private System.Windows.Forms.TextBox txtYear;
    }
}

