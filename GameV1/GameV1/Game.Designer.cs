namespace GameV1
{
    partial class Game
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
            this.tmrLeftMovement = new System.Windows.Forms.Timer(this.components);
            this.tmrRightMovement = new System.Windows.Forms.Timer(this.components);
            this.tmrJump = new System.Windows.Forms.Timer(this.components);
            this.tmrGame = new System.Windows.Forms.Timer(this.components);
            this.tmrPlayerMovement = new System.Windows.Forms.Timer(this.components);
            this.pnlBG = new DoubleBufferedPanel();
            this.pnlCharacter = new DoubleBufferedPanel();
            this.pnlSky = new System.Windows.Forms.Panel();
            this.pnlClouds = new System.Windows.Forms.Panel();
            this.pnlMiddleGround = new System.Windows.Forms.Panel();
            this.pnlGround = new System.Windows.Forms.Panel();
            this.pnlGroundStart = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlWater = new System.Windows.Forms.Panel();
            this.pnlBG.SuspendLayout();
            this.pnlSky.SuspendLayout();
            this.pnlGround.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrLeftMovement
            // 
            this.tmrLeftMovement.Interval = 10;
            // 
            // tmrRightMovement
            // 
            this.tmrRightMovement.Interval = 10;
            // 
            // tmrJump
            // 
            this.tmrJump.Enabled = true;
            this.tmrJump.Interval = 10;
            // 
            // tmrGame
            // 
            this.tmrGame.Enabled = true;
            this.tmrGame.Interval = 10;
            this.tmrGame.Tick += new System.EventHandler(this.tmrGame_Tick);
            // 
            // tmrPlayerMovement
            // 
            this.tmrPlayerMovement.Enabled = true;
            this.tmrPlayerMovement.Interval = 10;
            this.tmrPlayerMovement.Tick += new System.EventHandler(this.tmrPlayerMovement_Tick);
            // 
            // pnlBG
            // 
            this.pnlBG.BackgroundImage = global::GameV1.Properties.Resources.sky;
            this.pnlBG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlBG.Controls.Add(this.pnlCharacter);
            this.pnlBG.Controls.Add(this.pnlSky);
            this.pnlBG.Controls.Add(this.pnlMiddleGround);
            this.pnlBG.Controls.Add(this.pnlGround);
            this.pnlBG.Controls.Add(this.pnlWater);
            this.pnlBG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBG.Location = new System.Drawing.Point(0, 0);
            this.pnlBG.Name = "pnlBG";
            this.pnlBG.Size = new System.Drawing.Size(800, 450);
            this.pnlBG.TabIndex = 0;
            // 
            // pnlCharacter
            // 
            this.pnlCharacter.BackColor = System.Drawing.Color.Transparent;
            this.pnlCharacter.BackgroundImage = global::GameV1.Properties.Resources.testCharacter1;
            this.pnlCharacter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlCharacter.Location = new System.Drawing.Point(282, 12);
            this.pnlCharacter.Name = "pnlCharacter";
            this.pnlCharacter.Size = new System.Drawing.Size(68, 78);
            this.pnlCharacter.TabIndex = 0;
            this.pnlCharacter.Tag = "player";
            // 
            // pnlSky
            // 
            this.pnlSky.BackColor = System.Drawing.Color.Transparent;
            this.pnlSky.Controls.Add(this.pnlClouds);
            this.pnlSky.Location = new System.Drawing.Point(3, 100);
            this.pnlSky.Name = "pnlSky";
            this.pnlSky.Size = new System.Drawing.Size(800, 155);
            this.pnlSky.TabIndex = 3;
            // 
            // pnlClouds
            // 
            this.pnlClouds.BackColor = System.Drawing.Color.Transparent;
            this.pnlClouds.BackgroundImage = global::GameV1.Properties.Resources.clouds;
            this.pnlClouds.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlClouds.Location = new System.Drawing.Point(0, -2);
            this.pnlClouds.Name = "pnlClouds";
            this.pnlClouds.Size = new System.Drawing.Size(800, 157);
            this.pnlClouds.TabIndex = 2;
            // 
            // pnlMiddleGround
            // 
            this.pnlMiddleGround.BackgroundImage = global::GameV1.Properties.Resources.groundMiddleGrassyPlatform;
            this.pnlMiddleGround.Location = new System.Drawing.Point(251, 256);
            this.pnlMiddleGround.Name = "pnlMiddleGround";
            this.pnlMiddleGround.Size = new System.Drawing.Size(565, 34);
            this.pnlMiddleGround.TabIndex = 1;
            this.pnlMiddleGround.Tag = "";
            // 
            // pnlGround
            // 
            this.pnlGround.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGround.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.pnlGround.Controls.Add(this.pnlGroundStart);
            this.pnlGround.Controls.Add(this.panel1);
            this.pnlGround.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlGround.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pnlGround.Location = new System.Drawing.Point(161, 256);
            this.pnlGround.Name = "pnlGround";
            this.pnlGround.Size = new System.Drawing.Size(642, 194);
            this.pnlGround.TabIndex = 1;
            this.pnlGround.Tag = "platform";
            // 
            // pnlGroundStart
            // 
            this.pnlGroundStart.BackColor = System.Drawing.Color.Transparent;
            this.pnlGroundStart.BackgroundImage = global::GameV1.Properties.Resources.groundPlatform;
            this.pnlGroundStart.Location = new System.Drawing.Point(-2, -11);
            this.pnlGroundStart.Name = "pnlGroundStart";
            this.pnlGroundStart.Size = new System.Drawing.Size(94, 112);
            this.pnlGroundStart.TabIndex = 0;
            this.pnlGroundStart.Tag = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::GameV1.Properties.Resources.groundPlatform;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(-5, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(94, 112);
            this.panel1.TabIndex = 1;
            this.panel1.Tag = "";
            // 
            // pnlWater
            // 
            this.pnlWater.BackColor = System.Drawing.Color.Transparent;
            this.pnlWater.BackgroundImage = global::GameV1.Properties.Resources.sea;
            this.pnlWater.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlWater.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlWater.Location = new System.Drawing.Point(0, 256);
            this.pnlWater.Name = "pnlWater";
            this.pnlWater.Size = new System.Drawing.Size(800, 194);
            this.pnlWater.TabIndex = 4;
            this.pnlWater.Tag = "";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlBG);
            this.Name = "Game";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Game_KeyUp);
            this.pnlBG.ResumeLayout(false);
            this.pnlSky.ResumeLayout(false);
            this.pnlGround.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DoubleBufferedPanel pnlBG;
        private DoubleBufferedPanel pnlCharacter;
        private System.Windows.Forms.Timer tmrLeftMovement;
        private System.Windows.Forms.Timer tmrRightMovement;
        private System.Windows.Forms.Timer tmrJump;
        private System.Windows.Forms.Timer tmrGame;
        private System.Windows.Forms.Timer tmrPlayerMovement;
        private System.Windows.Forms.Panel pnlGround;
        private System.Windows.Forms.Panel pnlGroundStart;
        private System.Windows.Forms.Panel pnlMiddleGround;
        private System.Windows.Forms.Panel pnlClouds;
        private System.Windows.Forms.Panel pnlSky;
        private System.Windows.Forms.Panel pnlWater;
        private System.Windows.Forms.Panel panel1;
    }
}