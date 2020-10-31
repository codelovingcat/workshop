namespace algorithms_largest_number
{
    partial class LargeNumber
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
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.btnEnb = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt1
            // 
            this.txt1.Font = new System.Drawing.Font("Minion Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt1.Location = new System.Drawing.Point(50, 34);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(121, 31);
            this.txt1.TabIndex = 0;
            // 
            // txt2
            // 
            this.txt2.Font = new System.Drawing.Font("Minion Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt2.Location = new System.Drawing.Point(50, 71);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(121, 31);
            this.txt2.TabIndex = 1;
            // 
            // btnEnb
            // 
            this.btnEnb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEnb.Location = new System.Drawing.Point(190, 54);
            this.btnEnb.Name = "btnEnb";
            this.btnEnb.Size = new System.Drawing.Size(121, 72);
            this.btnEnb.TabIndex = 2;
            this.btnEnb.Text = "En Büyük Sayı";
            this.btnEnb.UseVisualStyleBackColor = false;
            this.btnEnb.Click += new System.EventHandler(this.btnEnb_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Minion Pro", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotal.Location = new System.Drawing.Point(54, 177);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(42, 28);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "000";
            // 
            // txt3
            // 
            this.txt3.Font = new System.Drawing.Font("Minion Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt3.Location = new System.Drawing.Point(50, 108);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(121, 31);
            this.txt3.TabIndex = 4;
            // 
            // LargeNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(380, 246);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnEnb);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Name = "LargeNumber";
            this.Text = "En Büyük Sayı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Button btnEnb;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txt3;
    }
}

