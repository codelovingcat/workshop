namespace algorithms_seasons
{
    partial class Season
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
            this.btnSeasons = new System.Windows.Forms.Button();
            this.txtSeasons = new System.Windows.Forms.TextBox();
            this.lblSeasons = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSeasons
            // 
            this.btnSeasons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSeasons.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSeasons.Font = new System.Drawing.Font("Minion Pro SmBd", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSeasons.Location = new System.Drawing.Point(356, 106);
            this.btnSeasons.Name = "btnSeasons";
            this.btnSeasons.Size = new System.Drawing.Size(75, 33);
            this.btnSeasons.TabIndex = 0;
            this.btnSeasons.Text = "Mevsimler";
            this.btnSeasons.UseVisualStyleBackColor = false;
            this.btnSeasons.Click += new System.EventHandler(this.btnSeasons_Click);
            // 
            // txtSeasons
            // 
            this.txtSeasons.Font = new System.Drawing.Font("Minion Pro SmBd", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeasons.Location = new System.Drawing.Point(118, 106);
            this.txtSeasons.Name = "txtSeasons";
            this.txtSeasons.Size = new System.Drawing.Size(217, 33);
            this.txtSeasons.TabIndex = 1;
            // 
            // lblSeasons
            // 
            this.lblSeasons.AutoSize = true;
            this.lblSeasons.Font = new System.Drawing.Font("Minion Pro SmBd", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSeasons.Location = new System.Drawing.Point(126, 169);
            this.lblSeasons.Name = "lblSeasons";
            this.lblSeasons.Size = new System.Drawing.Size(184, 29);
            this.lblSeasons.TabIndex = 2;
            this.lblSeasons.Text = "Meysimlerin ayları.";
            // 
            // Season
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::algorithms_seasons.Properties.Resources.mevsimler_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(596, 347);
            this.Controls.Add(this.lblSeasons);
            this.Controls.Add(this.txtSeasons);
            this.Controls.Add(this.btnSeasons);
            this.Name = "Season";
            this.Text = "Mevsimlerin Ayları";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSeasons;
        private System.Windows.Forms.TextBox txtSeasons;
        private System.Windows.Forms.Label lblSeasons;
    }
}

