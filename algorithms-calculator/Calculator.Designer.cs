namespace algorithms_calculator
{
    partial class Calculator
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
            this.btnDik = new System.Windows.Forms.Button();
            this.lblbirincikenar = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.txtUzun = new System.Windows.Forms.TextBox();
            this.txtkenar1 = new System.Windows.Forms.TextBox();
            this.lblUzun = new System.Windows.Forms.Label();
            this.lblAlan = new System.Windows.Forms.Label();
            this.lblCevre = new System.Windows.Forms.Label();
            this.lblCevreSonuc = new System.Windows.Forms.Label();
            this.lblAlanSonuc = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnDikdortgen = new System.Windows.Forms.Button();
            this.btnKare = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDik);
            this.panel1.Controls.Add(this.lblbirincikenar);
            this.panel1.Controls.Add(this.btnHesapla);
            this.panel1.Controls.Add(this.txtUzun);
            this.panel1.Controls.Add(this.txtkenar1);
            this.panel1.Controls.Add(this.lblUzun);
            this.panel1.Controls.Add(this.lblAlan);
            this.panel1.Controls.Add(this.lblCevre);
            this.panel1.Controls.Add(this.lblCevreSonuc);
            this.panel1.Controls.Add(this.lblAlanSonuc);
            this.panel1.Location = new System.Drawing.Point(98, 135);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 183);
            this.panel1.TabIndex = 17;
            // 
            // btnDik
            // 
            this.btnDik.Location = new System.Drawing.Point(33, 104);
            this.btnDik.Name = "btnDik";
            this.btnDik.Size = new System.Drawing.Size(142, 23);
            this.btnDik.TabIndex = 13;
            this.btnDik.Text = "Hesapla Dikdörtgen Alan";
            this.btnDik.UseVisualStyleBackColor = true;
            this.btnDik.Click += new System.EventHandler(this.btnDik_Click);
            // 
            // lblbirincikenar
            // 
            this.lblbirincikenar.AutoSize = true;
            this.lblbirincikenar.Location = new System.Drawing.Point(35, 17);
            this.lblbirincikenar.Name = "lblbirincikenar";
            this.lblbirincikenar.Size = new System.Drawing.Size(73, 13);
            this.lblbirincikenar.TabIndex = 4;
            this.lblbirincikenar.Text = "Birinci kenarı :";
            this.lblbirincikenar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(40, 75);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(124, 23);
            this.btnHesapla.TabIndex = 10;
            this.btnHesapla.Text = "Hesapla Kare Alan";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // txtUzun
            // 
            this.txtUzun.Location = new System.Drawing.Point(114, 34);
            this.txtUzun.Name = "txtUzun";
            this.txtUzun.Size = new System.Drawing.Size(48, 20);
            this.txtUzun.TabIndex = 12;
            // 
            // txtkenar1
            // 
            this.txtkenar1.Location = new System.Drawing.Point(114, 12);
            this.txtkenar1.Name = "txtkenar1";
            this.txtkenar1.Size = new System.Drawing.Size(48, 20);
            this.txtkenar1.TabIndex = 5;
            // 
            // lblUzun
            // 
            this.lblUzun.AutoSize = true;
            this.lblUzun.Location = new System.Drawing.Point(35, 37);
            this.lblUzun.Name = "lblUzun";
            this.lblUzun.Size = new System.Drawing.Size(69, 13);
            this.lblUzun.TabIndex = 11;
            this.lblUzun.Text = "Uzun Kenar :";
            this.lblUzun.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAlan
            // 
            this.lblAlan.AutoSize = true;
            this.lblAlan.Location = new System.Drawing.Point(108, 141);
            this.lblAlan.Name = "lblAlan";
            this.lblAlan.Size = new System.Drawing.Size(37, 13);
            this.lblAlan.TabIndex = 6;
            this.lblAlan.Text = "Alan =";
            this.lblAlan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCevre
            // 
            this.lblCevre.AutoSize = true;
            this.lblCevre.Location = new System.Drawing.Point(21, 141);
            this.lblCevre.Name = "lblCevre";
            this.lblCevre.Size = new System.Drawing.Size(44, 13);
            this.lblCevre.TabIndex = 7;
            this.lblCevre.Text = "Çevre =";
            this.lblCevre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCevreSonuc
            // 
            this.lblCevreSonuc.AutoSize = true;
            this.lblCevreSonuc.Location = new System.Drawing.Point(71, 141);
            this.lblCevreSonuc.Name = "lblCevreSonuc";
            this.lblCevreSonuc.Size = new System.Drawing.Size(19, 13);
            this.lblCevreSonuc.TabIndex = 9;
            this.lblCevreSonuc.Text = "00";
            // 
            // lblAlanSonuc
            // 
            this.lblAlanSonuc.AutoSize = true;
            this.lblAlanSonuc.Location = new System.Drawing.Point(158, 141);
            this.lblAlanSonuc.Name = "lblAlanSonuc";
            this.lblAlanSonuc.Size = new System.Drawing.Size(19, 13);
            this.lblAlanSonuc.TabIndex = 8;
            this.lblAlanSonuc.Text = "00";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(124, 119);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(31, 13);
            this.lblResult.TabIndex = 16;
            this.lblResult.Text = "0000";
            // 
            // btnDikdortgen
            // 
            this.btnDikdortgen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDikdortgen.Location = new System.Drawing.Point(216, 74);
            this.btnDikdortgen.Name = "btnDikdortgen";
            this.btnDikdortgen.Size = new System.Drawing.Size(75, 33);
            this.btnDikdortgen.TabIndex = 15;
            this.btnDikdortgen.Text = "Dikdörtgen";
            this.btnDikdortgen.UseVisualStyleBackColor = false;
            this.btnDikdortgen.Click += new System.EventHandler(this.btnDikdortgen_Click);
            // 
            // btnKare
            // 
            this.btnKare.BackColor = System.Drawing.Color.LightCoral;
            this.btnKare.Location = new System.Drawing.Point(120, 74);
            this.btnKare.Name = "btnKare";
            this.btnKare.Size = new System.Drawing.Size(75, 33);
            this.btnKare.TabIndex = 14;
            this.btnKare.Text = "Kare";
            this.btnKare.UseVisualStyleBackColor = false;
            this.btnKare.Click += new System.EventHandler(this.btnKare_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::algorithms_calculator.Properties.Resources.icon_hesaplamaci_410;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(422, 412);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnDikdortgen);
            this.Controls.Add(this.btnKare);
            this.DoubleBuffered = true;
            this.Name = "Calculator";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDik;
        private System.Windows.Forms.Label lblbirincikenar;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.TextBox txtUzun;
        private System.Windows.Forms.TextBox txtkenar1;
        private System.Windows.Forms.Label lblUzun;
        private System.Windows.Forms.Label lblAlan;
        private System.Windows.Forms.Label lblCevre;
        private System.Windows.Forms.Label lblCevreSonuc;
        private System.Windows.Forms.Label lblAlanSonuc;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnDikdortgen;
        private System.Windows.Forms.Button btnKare;
    }
}

