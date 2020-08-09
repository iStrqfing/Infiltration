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
            this.tmrPlayerAnimations = new System.Windows.Forms.Timer(this.components);
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Player = new System.Windows.Forms.PictureBox();
            this.pctBackground = new System.Windows.Forms.PictureBox();
            this.pctDoor = new System.Windows.Forms.PictureBox();
            this.pctKey = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.txtScore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pctBoxElevator = new System.Windows.Forms.PictureBox();
            this.pnlPaused = new System.Windows.Forms.Panel();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnOptions = new System.Windows.Forms.Button();
            this.btnResume = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pctBoxMine = new System.Windows.Forms.PictureBox();
            this.tmrAnimations = new System.Windows.Forms.Timer(this.components);
            this.tmrMine = new System.Windows.Forms.Timer(this.components);
            this.tmrExplosion = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctDoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctKey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxElevator)).BeginInit();
            this.pnlPaused.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxMine)).BeginInit();
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
            this.tmrPlayerMovement.Interval = 10;
            this.tmrPlayerMovement.Tick += new System.EventHandler(this.tmrPlayerMovement_Tick);
            // 
            // tmrPlayerAnimations
            // 
            this.tmrPlayerAnimations.Enabled = true;
            this.tmrPlayerAnimations.Interval = 1000;
            this.tmrPlayerAnimations.Tick += new System.EventHandler(this.tmrPlayerAnimations_Tick_1);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImage = global::GameV1.Properties.Resources.Gold;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(1325, 226);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(36, 35);
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "coin";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::GameV1.Properties.Resources.groundMiddleGrassyPlatform;
            this.pictureBox4.Location = new System.Drawing.Point(136, 85);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(506, 35);
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "platform";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::GameV1.Properties.Resources.groundMiddleGrassyPlatform;
            this.pictureBox3.Location = new System.Drawing.Point(836, 106);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(97, 35);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "platform";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::GameV1.Properties.Resources.groundMiddleGrassyPlatform;
            this.pictureBox2.Location = new System.Drawing.Point(836, 252);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(605, 35);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "platform";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::GameV1.Properties.Resources.groundMiddleGrassyPlatform;
            this.pictureBox1.Location = new System.Drawing.Point(179, 361);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(605, 35);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "solidPlatform";
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.BackgroundImage = global::GameV1.Properties.Resources.tile0001;
            this.Player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Player.Location = new System.Drawing.Point(238, 299);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(54, 63);
            this.Player.TabIndex = 2;
            this.Player.TabStop = false;
            // 
            // pctBackground
            // 
            this.pctBackground.BackColor = System.Drawing.Color.Black;
            this.pctBackground.BackgroundImage = global::GameV1.Properties.Resources.sky;
            this.pctBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctBackground.Location = new System.Drawing.Point(0, 0);
            this.pctBackground.Name = "pctBackground";
            this.pctBackground.Size = new System.Drawing.Size(2000, 460);
            this.pctBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pctBackground.TabIndex = 1;
            this.pctBackground.TabStop = false;
            // 
            // pctDoor
            // 
            this.pctDoor.BackColor = System.Drawing.Color.Transparent;
            this.pctDoor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctDoor.Location = new System.Drawing.Point(136, 12);
            this.pctDoor.Name = "pctDoor";
            this.pctDoor.Size = new System.Drawing.Size(46, 74);
            this.pctDoor.TabIndex = 8;
            this.pctDoor.TabStop = false;
            this.pctDoor.Tag = "portal";
            // 
            // pctKey
            // 
            this.pctKey.BackColor = System.Drawing.Color.Transparent;
            this.pctKey.BackgroundImage = global::GameV1.Properties.Resources.key;
            this.pctKey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctKey.Location = new System.Drawing.Point(1387, 218);
            this.pctKey.Name = "pctKey";
            this.pctKey.Size = new System.Drawing.Size(30, 35);
            this.pctKey.TabIndex = 9;
            this.pctKey.TabStop = false;
            this.pctKey.Tag = "key";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.BackgroundImage = global::GameV1.Properties.Resources.Gold;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Location = new System.Drawing.Point(1283, 226);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(36, 35);
            this.pictureBox6.TabIndex = 7;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "coin";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.BackgroundImage = global::GameV1.Properties.Resources.Gold;
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox7.Location = new System.Drawing.Point(866, 78);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(36, 35);
            this.pictureBox7.TabIndex = 7;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Tag = "coin";
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.BackgroundImage = global::GameV1.Properties.Resources.Gold;
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox8.Location = new System.Drawing.Point(414, 57);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(36, 35);
            this.pictureBox8.TabIndex = 7;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Tag = "coin";
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.BackColor = System.Drawing.Color.Transparent;
            this.txtScore.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.Location = new System.Drawing.Point(12, 23);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(95, 25);
            this.txtScore.TabIndex = 10;
            this.txtScore.Text = "Gold: 0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 28);
            this.label1.TabIndex = 11;
            this.label1.Tag = "gameObject";
            this.label1.Text = "WASD to move";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(620, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 28);
            this.label2.TabIndex = 11;
            this.label2.Tag = "gameObject";
            this.label2.Text = "Spacebar to Jump";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(188, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(293, 28);
            this.label3.TabIndex = 11;
            this.label3.Tag = "gameObject";
            this.label3.Text = "F to go through doors";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1087, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(366, 28);
            this.label4.TabIndex = 11;
            this.label4.Tag = "gameObject";
            this.label4.Text = "Collect Keys To Open Doors";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Unicode", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(754, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 28);
            this.label5.TabIndex = 11;
            this.label5.Tag = "gameObject";
            this.label5.Text = "S to Fall Through";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Lucida Sans Unicode", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(812, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 28);
            this.label6.TabIndex = 11;
            this.label6.Tag = "gameObject";
            this.label6.Text = "Platforms";
            // 
            // pctBoxElevator
            // 
            this.pctBoxElevator.BackColor = System.Drawing.Color.Transparent;
            this.pctBoxElevator.BackgroundImage = global::GameV1.Properties.Resources.islandPlatform;
            this.pctBoxElevator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctBoxElevator.Location = new System.Drawing.Point(-49, 352);
            this.pctBoxElevator.Name = "pctBoxElevator";
            this.pctBoxElevator.Size = new System.Drawing.Size(168, 108);
            this.pctBoxElevator.TabIndex = 4;
            this.pctBoxElevator.TabStop = false;
            this.pctBoxElevator.Tag = "elevator";
            // 
            // pnlPaused
            // 
            this.pnlPaused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(205)))), ((int)(((byte)(12)))));
            this.pnlPaused.Controls.Add(this.btnQuit);
            this.pnlPaused.Controls.Add(this.btnOptions);
            this.pnlPaused.Controls.Add(this.btnResume);
            this.pnlPaused.Controls.Add(this.label7);
            this.pnlPaused.Location = new System.Drawing.Point(393, 98);
            this.pnlPaused.Name = "pnlPaused";
            this.pnlPaused.Size = new System.Drawing.Size(173, 230);
            this.pnlPaused.TabIndex = 12;
            // 
            // btnQuit
            // 
            this.btnQuit.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(44, 163);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(82, 37);
            this.btnQuit.TabIndex = 1;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnOptions
            // 
            this.btnOptions.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOptions.Location = new System.Drawing.Point(44, 120);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(82, 37);
            this.btnOptions.TabIndex = 1;
            this.btnOptions.Text = "Options";
            this.btnOptions.UseVisualStyleBackColor = true;
            // 
            // btnResume
            // 
            this.btnResume.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResume.Location = new System.Drawing.Point(44, 77);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(82, 37);
            this.btnResume.TabIndex = 1;
            this.btnResume.Text = "Resume";
            this.btnResume.UseVisualStyleBackColor = true;
            this.btnResume.Click += new System.EventHandler(this.btnResume_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 42);
            this.label7.TabIndex = 0;
            this.label7.Text = "Paused";
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox9.BackgroundImage = global::GameV1.Properties.Resources.Solid_Ground;
            this.pictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox9.Location = new System.Drawing.Point(179, 352);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(93, 114);
            this.pictureBox9.TabIndex = 13;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Tag = "gameObject";
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.pictureBox10.Location = new System.Drawing.Point(269, 388);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(502, 78);
            this.pictureBox10.TabIndex = 14;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Tag = "gameObject";
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox11.BackgroundImage = global::GameV1.Properties.Resources.Solid_Ground_Reversed;
            this.pictureBox11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox11.Location = new System.Drawing.Point(691, 352);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(93, 114);
            this.pictureBox11.TabIndex = 13;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Tag = "gameObject";
            // 
            // pctBoxMine
            // 
            this.pctBoxMine.BackColor = System.Drawing.Color.Transparent;
            this.pctBoxMine.BackgroundImage = global::GameV1.Properties.Resources.mine_1;
            this.pctBoxMine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctBoxMine.Location = new System.Drawing.Point(614, 336);
            this.pctBoxMine.Name = "pctBoxMine";
            this.pctBoxMine.Size = new System.Drawing.Size(41, 29);
            this.pctBoxMine.TabIndex = 15;
            this.pctBoxMine.TabStop = false;
            this.pctBoxMine.Tag = "mine";
            // 
            // tmrAnimations
            // 
            this.tmrAnimations.Enabled = true;
            this.tmrAnimations.Interval = 40;
            this.tmrAnimations.Tick += new System.EventHandler(this.tmrAnimations_Tick);
            // 
            // tmrMine
            // 
            this.tmrMine.Enabled = true;
            this.tmrMine.Interval = 10;
            this.tmrMine.Tick += new System.EventHandler(this.tmrMine_Tick_1);
            // 
            // tmrExplosion
            // 
            this.tmrExplosion.Enabled = true;
            this.tmrExplosion.Interval = 120;
            this.tmrExplosion.Tick += new System.EventHandler(this.tmrExplosion_Tick);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GameV1.Properties.Resources.sky;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(924, 461);
            this.Controls.Add(this.pctBoxMine);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlPaused);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pctBoxElevator);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pctKey);
            this.Controls.Add(this.pctDoor);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.pctBackground);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Game_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctDoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctKey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxElevator)).EndInit();
            this.pnlPaused.ResumeLayout(false);
            this.pnlPaused.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxMine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer tmrLeftMovement;
        private System.Windows.Forms.Timer tmrRightMovement;
        private System.Windows.Forms.Timer tmrJump;
        private System.Windows.Forms.Timer tmrGame;
        private System.Windows.Forms.Timer tmrPlayerMovement;
        private System.Windows.Forms.PictureBox pctBackground;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Timer tmrPlayerAnimations;
        private System.Windows.Forms.PictureBox pctDoor;
        private System.Windows.Forms.PictureBox pctKey;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pctBoxElevator;
        private System.Windows.Forms.Panel pnlPaused;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.Button btnResume;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pctBoxMine;
        private System.Windows.Forms.Timer tmrAnimations;
        private System.Windows.Forms.Timer tmrMine;
        private System.Windows.Forms.Timer tmrExplosion;
    }
}