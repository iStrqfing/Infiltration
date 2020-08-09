namespace GameV1
{
    partial class StoryLine
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
            this.lblCountdownTxt = new System.Windows.Forms.Label();
            this.tmrMain = new System.Windows.Forms.Timer(this.components);
            this.tmrCountdown = new System.Windows.Forms.Timer(this.components);
            this.tmrRocket = new System.Windows.Forms.Timer(this.components);
            this.tmrPlayerMovement = new System.Windows.Forms.Timer(this.components);
            this.tmrStartBackground = new System.Windows.Forms.Timer(this.components);
            this.lblGameTitle = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pctBoxRocket = new System.Windows.Forms.PictureBox();
            this.Player = new System.Windows.Forms.PictureBox();
            this.pctBoxCloud2 = new System.Windows.Forms.PictureBox();
            this.pctBoxCloud = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxRocket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxCloud2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxCloud)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCountdownTxt
            // 
            this.lblCountdownTxt.AutoSize = true;
            this.lblCountdownTxt.Font = new System.Drawing.Font("Verdana", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountdownTxt.Location = new System.Drawing.Point(436, 134);
            this.lblCountdownTxt.Name = "lblCountdownTxt";
            this.lblCountdownTxt.Size = new System.Drawing.Size(125, 78);
            this.lblCountdownTxt.TabIndex = 0;
            this.lblCountdownTxt.Text = "10";
            this.lblCountdownTxt.Click += new System.EventHandler(this.lblCountdownTxt_Click);
            // 
            // tmrMain
            // 
            this.tmrMain.Enabled = true;
            this.tmrMain.Interval = 10;
            this.tmrMain.Tick += new System.EventHandler(this.tmrMain_Tick);
            // 
            // tmrCountdown
            // 
            this.tmrCountdown.Interval = 10;
            this.tmrCountdown.Tick += new System.EventHandler(this.tmrCountdown_Tick);
            // 
            // tmrRocket
            // 
            this.tmrRocket.Interval = 10;
            this.tmrRocket.Tick += new System.EventHandler(this.tmrRocket_Tick);
            // 
            // tmrPlayerMovement
            // 
            this.tmrPlayerMovement.Enabled = true;
            this.tmrPlayerMovement.Interval = 50;
            this.tmrPlayerMovement.Tick += new System.EventHandler(this.tmrPlayerMovement_Tick);
            // 
            // tmrStartBackground
            // 
            this.tmrStartBackground.Interval = 75;
            this.tmrStartBackground.Tick += new System.EventHandler(this.tmrStartBackground_Tick);
            // 
            // lblGameTitle
            // 
            this.lblGameTitle.AutoSize = true;
            this.lblGameTitle.Font = new System.Drawing.Font("Verdana", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameTitle.Location = new System.Drawing.Point(180, 117);
            this.lblGameTitle.Name = "lblGameTitle";
            this.lblGameTitle.Size = new System.Drawing.Size(644, 116);
            this.lblGameTitle.TabIndex = 8;
            this.lblGameTitle.Text = "Infiltration";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::GameV1.Properties.Resources.SingleCloud;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(641, -33);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(271, 120);
            this.pictureBox5.TabIndex = 6;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "cloud";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::GameV1.Properties.Resources.SingleCloud;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(75, 22);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(205, 112);
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "cloud";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::GameV1.Properties.Resources.tree;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(96, 233);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(160, 155);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.pictureBox1.Location = new System.Drawing.Point(-2, 421);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(929, 40);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::GameV1.Properties.Resources.groundMiddleGrassyPlatform;
            this.pictureBox2.Location = new System.Drawing.Point(-2, 387);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(929, 38);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pctBoxRocket
            // 
            this.pctBoxRocket.BackColor = System.Drawing.Color.Transparent;
            this.pctBoxRocket.BackgroundImage = global::GameV1.Properties.Resources.rocket;
            this.pctBoxRocket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctBoxRocket.Location = new System.Drawing.Point(419, 253);
            this.pctBoxRocket.Name = "pctBoxRocket";
            this.pctBoxRocket.Size = new System.Drawing.Size(102, 208);
            this.pctBoxRocket.TabIndex = 1;
            this.pctBoxRocket.TabStop = false;
            this.pctBoxRocket.Tag = "rocket";
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.BackgroundImage = global::GameV1.Properties.Resources.tile000__1_;
            this.Player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Player.Location = new System.Drawing.Point(882, 342);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(30, 46);
            this.Player.TabIndex = 5;
            this.Player.TabStop = false;
            // 
            // pctBoxCloud2
            // 
            this.pctBoxCloud2.BackgroundImage = global::GameV1.Properties.Resources.SingleCloud;
            this.pctBoxCloud2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctBoxCloud2.Location = new System.Drawing.Point(122, 102);
            this.pctBoxCloud2.Name = "pctBoxCloud2";
            this.pctBoxCloud2.Size = new System.Drawing.Size(255, 134);
            this.pctBoxCloud2.TabIndex = 7;
            this.pctBoxCloud2.TabStop = false;
            this.pctBoxCloud2.Tag = "cloud";
            // 
            // pctBoxCloud
            // 
            this.pctBoxCloud.BackgroundImage = global::GameV1.Properties.Resources.SingleCloud;
            this.pctBoxCloud.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctBoxCloud.Location = new System.Drawing.Point(572, 160);
            this.pctBoxCloud.Name = "pctBoxCloud";
            this.pctBoxCloud.Size = new System.Drawing.Size(211, 102);
            this.pctBoxCloud.TabIndex = 7;
            this.pctBoxCloud.TabStop = false;
            this.pctBoxCloud.Tag = "cloud";
            // 
            // StoryLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(242)))), ((int)(((byte)(236)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(924, 461);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblCountdownTxt);
            this.Controls.Add(this.pctBoxRocket);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.pctBoxCloud2);
            this.Controls.Add(this.pctBoxCloud);
            this.Controls.Add(this.lblGameTitle);
            this.Name = "StoryLine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StoryLine";
            this.Load += new System.EventHandler(this.StoryLine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxRocket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxCloud2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxCloud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCountdownTxt;
        private System.Windows.Forms.Timer tmrMain;
        private System.Windows.Forms.Timer tmrCountdown;
        private System.Windows.Forms.PictureBox pctBoxRocket;
        private System.Windows.Forms.Timer tmrRocket;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.Timer tmrPlayerMovement;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pctBoxCloud;
        private System.Windows.Forms.PictureBox pctBoxCloud2;
        private System.Windows.Forms.Timer tmrStartBackground;
        private System.Windows.Forms.Label lblGameTitle;
    }
}