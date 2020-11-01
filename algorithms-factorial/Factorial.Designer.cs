namespace algorithms_factorial
{
    partial class Factorial
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
            this.btnFactorial = new System.Windows.Forms.Button();
            this.txtFactorial = new System.Windows.Forms.TextBox();
            this.lblFactorial = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFactorial
            // 
            this.btnFactorial.BackColor = System.Drawing.Color.Black;
            this.btnFactorial.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFactorial.ForeColor = System.Drawing.Color.White;
            this.btnFactorial.Location = new System.Drawing.Point(438, 57);
            this.btnFactorial.Name = "btnFactorial";
            this.btnFactorial.Size = new System.Drawing.Size(143, 43);
            this.btnFactorial.TabIndex = 0;
            this.btnFactorial.Text = "Faktöriyel";
            this.btnFactorial.UseVisualStyleBackColor = false;
            this.btnFactorial.Click += new System.EventHandler(this.btnFactorial_Click);
            // 
            // txtFactorial
            // 
            this.txtFactorial.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtFactorial.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFactorial.ForeColor = System.Drawing.Color.White;
            this.txtFactorial.Location = new System.Drawing.Point(219, 57);
            this.txtFactorial.Name = "txtFactorial";
            this.txtFactorial.Size = new System.Drawing.Size(196, 39);
            this.txtFactorial.TabIndex = 1;
            // 
            // lblFactorial
            // 
            this.lblFactorial.AutoSize = true;
            this.lblFactorial.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFactorial.Location = new System.Drawing.Point(225, 114);
            this.lblFactorial.Name = "lblFactorial";
            this.lblFactorial.Size = new System.Drawing.Size(46, 21);
            this.lblFactorial.TabIndex = 2;
            this.lblFactorial.Text = "000";
            // 
            // Factorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::algorithms_factorial.Properties.Resources.icon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(641, 213);
            this.Controls.Add(this.lblFactorial);
            this.Controls.Add(this.txtFactorial);
            this.Controls.Add(this.btnFactorial);
            this.Name = "Factorial";
            this.Text = "Girilen Sayının Faktöriyeli";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFactorial;
        private System.Windows.Forms.TextBox txtFactorial;
        private System.Windows.Forms.Label lblFactorial;
    }
}

