namespace GameV1
{
    partial class Menu
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
            this.pnlMenuBG = new System.Windows.Forms.Panel();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnOptions = new System.Windows.Forms.Button();
            this.btnCredits = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tmrMenuAnimations = new System.Windows.Forms.Timer(this.components);
            this.tmrLeft = new System.Windows.Forms.Timer(this.components);
            this.tmrRight = new System.Windows.Forms.Timer(this.components);
            this.pnlMenuBG.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenuBG
            // 
            this.pnlMenuBG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(242)))), ((int)(((byte)(236)))));
            this.pnlMenuBG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMenuBG.Controls.Add(this.btnPlay);
            this.pnlMenuBG.Controls.Add(this.btnQuit);
            this.pnlMenuBG.Controls.Add(this.btnOptions);
            this.pnlMenuBG.Controls.Add(this.btnCredits);
            this.pnlMenuBG.Controls.Add(this.panel1);
            this.pnlMenuBG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMenuBG.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuBG.Name = "pnlMenuBG";
            this.pnlMenuBG.Size = new System.Drawing.Size(924, 450);
            this.pnlMenuBG.TabIndex = 0;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(428, 101);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(124, 49);
            this.btnPlay.TabIndex = 9;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click_1);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(426, 273);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(124, 49);
            this.btnQuit.TabIndex = 12;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click_1);
            // 
            // btnOptions
            // 
            this.btnOptions.Location = new System.Drawing.Point(426, 159);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(124, 49);
            this.btnOptions.TabIndex = 10;
            this.btnOptions.Text = "Options";
            this.btnOptions.UseVisualStyleBackColor = true;
            // 
            // btnCredits
            // 
            this.btnCredits.Location = new System.Drawing.Point(426, 218);
            this.btnCredits.Name = "btnCredits";
            this.btnCredits.Size = new System.Drawing.Size(124, 49);
            this.btnCredits.TabIndex = 11;
            this.btnCredits.Text = "Credits";
            this.btnCredits.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::GameV1.Properties.Resources.magic_cliffs_PREVIEWx1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2400, 450);
            this.panel1.TabIndex = 13;
            // 
            // tmrMenuAnimations
            // 
            this.tmrMenuAnimations.Enabled = true;
            this.tmrMenuAnimations.Interval = 5;
            this.tmrMenuAnimations.Tick += new System.EventHandler(this.tmrMenuAnimations_Tick);
            // 
            // tmrLeft
            // 
            this.tmrLeft.Interval = 10;
            this.tmrLeft.Tick += new System.EventHandler(this.tmrLeft_Tick);
            // 
            // tmrRight
            // 
            this.tmrRight.Interval = 10;
            this.tmrRight.Tick += new System.EventHandler(this.tmrRight_Tick);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 450);
            this.Controls.Add(this.pnlMenuBG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.pnlMenuBG.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenuBG;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.Button btnCredits;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer tmrMenuAnimations;
        private System.Windows.Forms.Timer tmrLeft;
        private System.Windows.Forms.Timer tmrRight;
    }
}