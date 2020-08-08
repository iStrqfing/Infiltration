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
            System.Windows.Forms.Label lblTitle;
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnCredits = new System.Windows.Forms.Button();
            this.btnOptions = new System.Windows.Forms.Button();
            this.tmrMenuAnimations = new System.Windows.Forms.Timer(this.components);
            this.tmrLeft = new System.Windows.Forms.Timer(this.components);
            this.tmrRight = new System.Windows.Forms.Timer(this.components);
            this.tmrLandRocket = new System.Windows.Forms.Timer(this.components);
            this.tmrWait = new System.Windows.Forms.Timer(this.components);
            this.pctBoxRocket = new System.Windows.Forms.PictureBox();
            this.pctBoxBG = new System.Windows.Forms.PictureBox();
            lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxRocket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxBG)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitle.Location = new System.Drawing.Point(284, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(387, 77);
            lblTitle.TabIndex = 19;
            lblTitle.Text = "Infiltration";
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(415, 117);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(124, 49);
            this.btnPlay.TabIndex = 15;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click_2);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(413, 285);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(124, 49);
            this.btnQuit.TabIndex = 18;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnCredits
            // 
            this.btnCredits.Location = new System.Drawing.Point(413, 230);
            this.btnCredits.Name = "btnCredits";
            this.btnCredits.Size = new System.Drawing.Size(124, 49);
            this.btnCredits.TabIndex = 17;
            this.btnCredits.Text = "Credits";
            this.btnCredits.UseVisualStyleBackColor = true;
            // 
            // btnOptions
            // 
            this.btnOptions.Location = new System.Drawing.Point(413, 175);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(124, 49);
            this.btnOptions.TabIndex = 16;
            this.btnOptions.Text = "Options";
            this.btnOptions.UseVisualStyleBackColor = true;
            // 
            // tmrMenuAnimations
            // 
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
            // tmrLandRocket
            // 
            this.tmrLandRocket.Enabled = true;
            this.tmrLandRocket.Interval = 10;
            this.tmrLandRocket.Tick += new System.EventHandler(this.tmrLandRocket_Tick);
            // 
            // tmrWait
            // 
            this.tmrWait.Interval = 1000;
            this.tmrWait.Tick += new System.EventHandler(this.tmrWait_Tick);
            // 
            // pctBoxRocket
            // 
            this.pctBoxRocket.BackColor = System.Drawing.Color.Transparent;
            this.pctBoxRocket.BackgroundImage = global::GameV1.Properties.Resources.rocket;
            this.pctBoxRocket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctBoxRocket.Location = new System.Drawing.Point(65, 52);
            this.pctBoxRocket.Name = "pctBoxRocket";
            this.pctBoxRocket.Size = new System.Drawing.Size(72, 140);
            this.pctBoxRocket.TabIndex = 20;
            this.pctBoxRocket.TabStop = false;
            this.pctBoxRocket.Tag = "rocket";
            // 
            // pctBoxBG
            // 
            this.pctBoxBG.BackgroundImage = global::GameV1.Properties.Resources.magic_cliffs_PREVIEWx1;
            this.pctBoxBG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctBoxBG.Location = new System.Drawing.Point(0, 0);
            this.pctBoxBG.Name = "pctBoxBG";
            this.pctBoxBG.Size = new System.Drawing.Size(2400, 450);
            this.pctBoxBG.TabIndex = 14;
            this.pctBoxBG.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(242)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(924, 450);
            this.Controls.Add(lblTitle);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.pctBoxRocket);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnCredits);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.pctBoxBG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxRocket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxBG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer tmrMenuAnimations;
        private System.Windows.Forms.Timer tmrLeft;
        private System.Windows.Forms.Timer tmrRight;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnCredits;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.PictureBox pctBoxBG;
        private System.Windows.Forms.Timer tmrLandRocket;
        private System.Windows.Forms.Timer tmrWait;
        private System.Windows.Forms.PictureBox pctBoxRocket;
    }
}