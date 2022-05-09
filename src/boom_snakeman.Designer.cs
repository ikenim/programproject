namespace boom_snakeman
{
    partial class Snake
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Snake));
            this.lblScore = new System.Windows.Forms.Label();
            this.lblFood = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(12, 9);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(64, 21);
            this.lblScore.TabIndex = 0;
            this.lblScore.Text = "Score: 0";
            // 
            // lblFood
            // 
            this.lblFood.AutoSize = true;
            this.lblFood.BackColor = System.Drawing.Color.White;
            this.lblFood.Image = ((System.Drawing.Image)(resources.GetObject("lblFood.Image")));
            this.lblFood.Location = new System.Drawing.Point(361, 189);
            this.lblFood.Name = "lblFood";
            this.lblFood.Size = new System.Drawing.Size(14, 21);
            this.lblFood.TabIndex = 1;
            this.lblFood.Text = " ";
            this.lblFood.Click += new System.EventHandler(this.label1_Click);
            // 
            // Snake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.lblFood);
            this.Controls.Add(this.lblScore);
            this.Font = new System.Drawing.Font("Sitka Subheading", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Snake";
            this.Text = "Boom! Snakeman";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblScore;
        private Label lblFood;
    }
}