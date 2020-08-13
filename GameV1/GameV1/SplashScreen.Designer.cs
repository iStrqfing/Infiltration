namespace GameV1
{
    partial class SplashScreen
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
            this.components = new System.ComponentModel.Container();
            this.tmrShowLogo = new System.Windows.Forms.Timer(this.components);
            this.lblPresents = new System.Windows.Forms.Label();
            this.tmrShowText = new System.Windows.Forms.Timer(this.components);
            this.pctBoxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrShowLogo
            // 
            this.tmrShowLogo.Enabled = true;
            this.tmrShowLogo.Interval = 10;
            this.tmrShowLogo.Tick += new System.EventHandler(this.tmrShowLogo_Tick);
            // 
            // lblPresents
            // 
            this.lblPresents.AutoSize = true;
            this.lblPresents.BackColor = System.Drawing.Color.Black;
            this.lblPresents.Font = new System.Drawing.Font("Verdana", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresents.ForeColor = System.Drawing.Color.White;
            this.lblPresents.Location = new System.Drawing.Point(169, 272);
            this.lblPresents.Name = "lblPresents";
            this.lblPresents.Size = new System.Drawing.Size(522, 116);
            this.lblPresents.TabIndex = 1;
            this.lblPresents.Text = "Presents";
            // 
            // tmrShowText
            // 
            this.tmrShowText.Interval = 10;
            this.tmrShowText.Tick += new System.EventHandler(this.tmrShowText_Tick);
            // 
            // pctBoxLogo
            // 
            this.pctBoxLogo.BackgroundImage = global::GameV1.Properties.Resources.logo;
            this.pctBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctBoxLogo.Location = new System.Drawing.Point(12, 127);
            this.pctBoxLogo.Name = "pctBoxLogo";
            this.pctBoxLogo.Size = new System.Drawing.Size(683, 112);
            this.pctBoxLogo.TabIndex = 0;
            this.pctBoxLogo.TabStop = false;
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(924, 461);
            this.Controls.Add(this.lblPresents);
            this.Controls.Add(this.pctBoxLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SplashScreen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Infiltration By Joshua Randall";
            this.Load += new System.EventHandler(this.SplashScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer tmrShowLogo;
        private System.Windows.Forms.PictureBox pctBoxLogo;
        private System.Windows.Forms.Label lblPresents;
        private System.Windows.Forms.Timer tmrShowText;
    }
}

