using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace GameV1
{
    public partial class Game : Form
    {

        protected override CreateParams CreateParams // Prevents flickering when loading images
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        public Game()
        {
            InitializeComponent();
        }

        static int height = SystemInformation.VirtualScreen.Height;
        static int width = SystemInformation.VirtualScreen.Width;

        SoundPlayer mainMusic = new SoundPlayer(@"../../Resources/Music/Lurid Delusion.wav");

        int score = 0;

        int speed = 3; // Character movement speed
        static int speedJump = 8; // Jump speed
        int jumpSpeed = speedJump; // Character jumping speed
        int constantGravityForce = 12;
        int gravityForce = 12; // How fast the character falls

        int backgroundSpeed = 4;
        int backgroundHeight = 1;

        

        bool gameStarted, jumping, movingRight, movingLeft, fall, rotated, playerAbleToJump, portalOpen;
        bool keyFound, openDoor, paused, explode, exploded;

        const int playerIdleAnimationFrames = 4;
        const int playerJumpAnimationFrames = 3;
        const int playerRunningAnimationFrames = 7;
        const int playerShootingAnimationFrames = 5;

        const int playerDieAnimationFrames = 6;
        int playerDieAnimation = 6;

        const int mineIdleAnimationFrames = 1;
        const int mineExplosionAnimationFrames = 6;
        int mineIdleAnimationSlow = 0;
        Control explodingMine;

        const int portalIdleAnimationFrames = 4;
        const int portalActiveAnimationFrames = 17;

        int playerIdleAnimation, playerJumpAnimation, playerRunningAnimation, playerShootingAnimation, mineIdleAnimation, mineExplosionAnimation, portalIdleAnimation, portalActiveAnimation;
       

        /// <summary>
        /// Player animations
        /// </summary>
        List<Image> playerIdle = new List<Image>();
        List<Image> playerJump = new List<Image>();
        List<Image> playerRunningRight = new List<Image>();
        List<Image> playerRunningLeft = new List<Image>();
        List<Image> playerShooting = new List<Image>();
        List<Image> playerDie = new List<Image>();


        /// <summary>
        /// Mine Field
        /// </summary>
        List<Image> mineIdle = new List<Image>();
        List<Image> mineExplosion = new List<Image>();

        /// <summary>
        /// Portal
        /// </summary>
        List<Image> portalIdle = new List<Image>();
        List<Image> portalActive = new List<Image>();


        private void btnResume_Click(object sender, EventArgs e)
        {
            pnlPaused.Visible = false;
            paused = false;
            startStopTimers(true);
            this.Focus();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Menu form = new Menu();
            form.Show();
            this.Hide();
            mainMusic.Stop();
            tmrGame.Stop();
        }



        List<Image> playerIdleRotated = new List<Image>();
        List<Image> playerJumpRotated = new List<Image>();

        List<Control> platforms = new List<Control>();
        List<Control> gameItems = new List<Control>();
        List<Control> key = new List<Control>();
        List<Control> coins = new List<Control>();
        List<Control> portal = new List<Control>();

        private void Game_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            Player.Visible = false;
            mainMusic.Play();

            loadImages();

            loadGameObjects();

            loadGameDesign();
        }

        private void loadGameObjects()
        {
            foreach (Control gameObject in this.Controls)
            {
                if (gameObject is PictureBox && gameObject.Tag == "platform" || gameObject.Tag == "elevator" || gameObject.Tag == "solidPlatform")
                {
                    platforms.Add(gameObject);
                }
                if (gameObject is PictureBox && (string)gameObject.Tag == "platform" || (string)gameObject.Tag == "elevator" || (string)gameObject.Tag == "gameObject" || (string)gameObject.Tag == "mine" || (string)gameObject.Tag == "solidPlatform" || (string)gameObject.Tag == "coin" || (string)gameObject.Tag == "key" || (string)gameObject.Tag == "portal" || gameObject is Label && (string)gameObject.Tag == "gameObject")
                {
                    gameItems.Add(gameObject);
                }
                if (gameObject is PictureBox && gameObject.Tag == "coin")
                {
                    coins.Add(gameObject);
                }
                if (gameObject is PictureBox && gameObject.Tag == "key")
                {
                    key.Add(gameObject);
                }
                if (gameObject is PictureBox && gameObject.Tag == "portal")
                {
                    coins.Add(gameObject);
                }
            }
        }

        private void loadImages()
        {
            //Load Image sets
            foreach (FileInfo image in new DirectoryInfo("../../Resources/Player/Run").GetFiles())
            {
                playerRunningRight.Add(Image.FromFile(image.FullName));
            }
            foreach (FileInfo image in new DirectoryInfo("../../Resources/Player/Jump").GetFiles())
            {
                playerJump.Add(Image.FromFile(image.FullName));
            }
            foreach (FileInfo image in new DirectoryInfo("../../Resources/Player/Idle").GetFiles())
            {
                playerIdle.Add(Image.FromFile(image.FullName));
            }
            foreach (FileInfo image in new DirectoryInfo("../../Resources/Player/Shoot").GetFiles())
            {
                playerShooting.Add(Image.FromFile(image.FullName));
            }
            foreach (FileInfo image in new DirectoryInfo("../../Resources/Player/Death").GetFiles())
            {
                playerDie.Add(Image.FromFile(image.FullName));
            }

            //Mine
            foreach (FileInfo image in new DirectoryInfo("../../Resources/Game Objects/traps/mine/Idle").GetFiles())
            {
                mineIdle.Add(Image.FromFile(image.FullName));
            }
            foreach (FileInfo image in new DirectoryInfo("../../Resources/Game Objects/traps/mine/Explosion").GetFiles())
            {
                mineExplosion.Add(Image.FromFile(image.FullName));
            }

            //Portal
            foreach (FileInfo image in new DirectoryInfo("../../Resources/Game Objects/Portal/Idle").GetFiles())
            {
                portalIdle.Add(Image.FromFile(image.FullName));
            }
            foreach (FileInfo image in new DirectoryInfo("../../Resources/Game Objects/Portal/Active").GetFiles())
            {
                portalActive.Add(Image.FromFile(image.FullName));
            }

            //Load flipped Image sets
            foreach (FileInfo image in new DirectoryInfo("../../Resources/Player/Run").GetFiles())
            {
                playerRunningLeft.Add(Image.FromFile(image.FullName));
            }
            foreach (FileInfo image in new DirectoryInfo("../../Resources/Player/Jump").GetFiles())
            {
                playerJumpRotated.Add(Image.FromFile(image.FullName));
            }
            foreach (FileInfo image in new DirectoryInfo("../../Resources/Player/Idle").GetFiles())
            {
                playerIdleRotated.Add(Image.FromFile(image.FullName));
            }


            //Flip each image set
            foreach (Image image in playerRunningLeft)
            {
                image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            }
            foreach (Image image in playerJumpRotated)
            {
                image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            }
            foreach (Image image in playerIdleRotated)
            {
                image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            }
        }

        private void loadGameDesign()
        {
            pnlPaused.Visible = false;

            Player.BringToFront();
            Player.Refresh();


            foreach (Control x in this.Controls)
            {
                if (x is Label)
                {
                    x.BringToFront();
                }
            }
        }

        private void tmrAnimations_Tick(object sender, EventArgs e)
        {
            if (portalOpen)
            {
                Player.Visible = false;
                if (portalActiveAnimation == portalActiveAnimationFrames)
                {
                    startStopTimers(false);
                    pctDoor.BackgroundImage = portalActive[portalActiveAnimation];
                    Menu form = new Menu();
                    form.Show();
                    this.Hide();
                    tmrPlayerMovement.Stop();
                }
                else
                {
                    pctDoor.BackgroundImage = portalActive[portalActiveAnimation];
                    portalActiveAnimation++;
                }
                

            } else if (portalIdleAnimation == portalIdleAnimationFrames)
            {
                pctDoor.BackgroundImage = portalIdle[portalIdleAnimation];
                portalIdleAnimation = 0;
            }
            else
            {
                pctDoor.BackgroundImage = portalIdle[portalIdleAnimation];
                portalIdleAnimation++;
            }
        }

        private void playerDeath()
        {
            startStopTimers(false);

            foreach (Control x in this.Controls)
            {
                x.Dispose();
            }
            mainMusic.Stop();
            Menu form = new Menu();
            form.Show();
            this.Hide();

            
        }

        private void tmrExplosion_Tick(object sender, EventArgs e)
        {
            if (explode)
            {
                tmrPlayerAnimations.Stop();
                tmrPlayerMovement.Stop();
                
                if (mineExplosionAnimation > mineExplosionAnimationFrames)
                {
                    if (exploded == false)
                    {
                        explodingMine.Dispose();
                        Player.Size = new Size(54, 63);
                        Player.Left -= 10;
                        Player.Top -= 15;
                        exploded = true;
                    }                  

                    if (playerDieAnimation > playerDieAnimationFrames)
                    {
                        Player.Dispose();
                        playerDeath();
                        tmrExplosion.Stop();
                    }
                    else
                    {
                        Player.BackgroundImage = playerDie[playerDieAnimation];
                        playerDieAnimation++;
                    }
                }
                else
                {
                    explodingMine.BackgroundImage = mineExplosion[mineExplosionAnimation];
                    mineExplosionAnimation++;
                }
            }
            
        }

        private void tmrMine_Tick_1(object sender, EventArgs e)
        {
            mineIdleAnimationSlow++;
            if (mineIdleAnimationSlow >= 25)
            {
                if (explode == false)
                {
                    if (mineIdleAnimation == mineIdleAnimationFrames)
                    {
                        pctBoxMine.BackgroundImage = mineIdle[mineIdleAnimation];
                        mineIdleAnimation = 0;
                    }
                    else
                    {
                        pctBoxMine.BackgroundImage = mineIdle[mineIdleAnimation];
                        mineIdleAnimation++;
                    }
                }
               
                mineIdleAnimationSlow = 0;
            }

            foreach (Control gameObject in this.Controls)
            {
                if (gameObject is PictureBox && gameObject.Tag == "mine")
                {
                    if (Player.Bounds.IntersectsWith(gameObject.Bounds) && explode == false)
                    {
                        explode = true;
                        explodingMine = gameObject;
                        gameObject.Size = new Size(240, 176);
                        gameObject.Left -= 85;
                        gameObject.Top -= 150;
                        gameObject.BringToFront();                                              
                   }
                }
            }          
        }      

        private void tmrGame_Tick(object sender, EventArgs e)
        {
            txtScore.Text = $"Gold: {score}";

            if (Player.Location.Y > height + 100)
            {
                playerDeath();
            }
        }

        private void startStopTimers(bool start)
        {
            if (start)
            {
                tmrPlayerAnimations.Start();
                tmrAnimations.Start();
                tmrGame.Start();
                tmrJump.Start();
                tmrPlayerMovement.Start();
                tmrLeftMovement.Start();
                tmrRightMovement.Start();
                tmrMine.Start();
            }
            else
            {
                tmrPlayerAnimations.Stop();
                tmrAnimations.Stop();
                tmrGame.Stop();
                tmrJump.Stop();
                tmrPlayerMovement.Stop();
                tmrLeftMovement.Stop();
                tmrRightMovement.Stop();
                tmrMine.Stop();
            }
        }

        private void tmrPlayerMovement_Tick(object sender, EventArgs e)
        {
            Player.Top += jumpSpeed;
            if (jumping && gravityForce < 0) // Checks whether player is jumping
            {
                jumping = false;
            }

            if (jumping == true)
            {
                jumpSpeed = -speedJump;
                gravityForce -= 1;
            }
            else
            {
                jumpSpeed = speedJump;
            }

            /// Island Elevator Platform
            /// 
            ///

            if (Player.Bounds.IntersectsWith(pctBoxElevator.Bounds))
            {
                if (pctBoxElevator.Top > 140)
                {
                    pctBoxElevator.Top -= backgroundHeight;
                }
            }
            else if (pctBoxElevator.Top < 350)
            {
                pctBoxElevator.Top += backgroundHeight;
            }




            if (movingRight == true && Player.Left + (Player.Width + 120) < this.ClientSize.Width)
            {
                Player.Left += speed;

                foreach (Control gameItem in gameItems)
                {
                    gameItem.Left -= backgroundSpeed;
                }
            }
            if (movingLeft == true && Player.Left > 120)
            {
                Player.Left -= speed;

                foreach (Control gameItem in gameItems)
                {
                    gameItem.Left += backgroundSpeed;
                }
            }

            //            

            // x of platform 
            // pnlMiddleGround.Location.X

            foreach (Control gameObject in platforms)
            {
                if (Player.Bounds.IntersectsWith(gameObject.Bounds) && !jumping)
                {
                    if (fall == false)
                    {
                        playerAbleToJump = true;
                        gravityForce = constantGravityForce;
                        if (movingLeft == true || movingRight == true)
                        {
                            Player.Top = gameObject.Top - Player.Height + 1;
                        }
                        else
                        {
                            Player.Top = gameObject.Top - Player.Height + 1;
                        }
                    }

                    if (fall == true && gameObject.Tag == "elevator" || gameObject.Tag == "solidPlatform") // Prevents player from falling through elevators
                    {
                        gravityForce = constantGravityForce;
                        if (movingLeft == true || movingRight == true)
                        {
                            Player.Top = gameObject.Top - Player.Height + 1;
                        }
                        else
                        {
                            Player.Top = gameObject.Top - Player.Height + 1;
                        }
                    }
                    
                        
                    

                    
                }
            }
            foreach (Control gameObject in this.Controls)
                if (gameObject is PictureBox && gameObject.Tag == "coin")
                {
                    if (Player.Bounds.IntersectsWith(gameObject.Bounds))
                    {
                        gameObject.Dispose();
                        score++;
                    }
                }
                else if (gameObject is PictureBox && gameObject.Tag == "key")
                {
                    if (Player.Bounds.IntersectsWith(gameObject.Bounds))
                    {
                        gameObject.Dispose();
                        keyFound = true;
                    }
                }
                else if (keyFound == true && gameObject is PictureBox && gameObject.Tag == "portal")
                {
                    if (Player.Bounds.IntersectsWith(gameObject.Bounds) && openDoor == true)
                    {
                        portalOpen = true;
                        
                    }
                } 
        }

        private void tmrPlayerAnimations_Tick_1(object sender, EventArgs e)
        {
            if (gameStarted == false)
            {                               
                Console.WriteLine(playerDieAnimation);
                tmrPlayerAnimations.Interval = 100;
                Player.Size = new Size(54, 63);
                if (playerDieAnimation == 0)
                {
                    Player.BackgroundImage = playerDie[playerDieAnimation];
                    gameStarted = true;
                    tmrPlayerMovement.Enabled = true;
                    tmrPlayerAnimations.Interval = 50;
                    Player.Size = new Size(30, 46);
                }
                else
                {
                    Player.Visible = true;
                    
                    Player.BackgroundImage = playerDie[playerDieAnimation];
                    playerDieAnimation--;
                }
            } else if (movingRight == true)
            {
                tmrPlayerAnimations.Interval = 50;
                if (playerRunningAnimation == playerRunningAnimationFrames)
                {
                    Player.BackgroundImage = playerRunningRight[playerRunningAnimation];
                    playerRunningAnimation = 0;
                }
                else
                {
                    Player.BackgroundImage = playerRunningRight[playerRunningAnimation];
                    playerRunningAnimation++;
                }

            }
            else if (movingLeft == true)
            {
                tmrPlayerAnimations.Interval = 50;
                if (playerRunningAnimation == playerRunningAnimationFrames)
                {
                    Player.BackgroundImage = playerRunningLeft[playerRunningAnimation];
                    playerRunningAnimation = 0;
                }
                else
                {
                    Player.BackgroundImage = playerRunningLeft[playerRunningAnimation];
                    playerRunningAnimation++;
                }
            }
            else if (jumping == true)
            {
                tmrPlayerAnimations.Interval = 50;
                if (rotated == false)
                {
                    if (playerJumpAnimation == playerJumpAnimationFrames - 1)
                    {
                        Player.BackgroundImage = playerJump[playerJumpAnimation];
                        playerJumpAnimation = 0;
                    }
                    else
                    {
                        Player.BackgroundImage = playerJump[playerJumpAnimation];
                        playerJumpAnimation++;
                    }
                }
                else
                {
                    if (rotated == false)
                    {
                        if (playerJumpAnimation == playerJumpAnimationFrames - 1)
                        {
                            Player.BackgroundImage = playerJumpRotated[playerJumpAnimation];
                            playerJumpAnimation = 0;
                        }
                        else
                        {
                            Player.BackgroundImage = playerJumpRotated[playerJumpAnimation];
                            playerJumpAnimation++;
                        }
                    }
                }
            }
            else
            {
                if (rotated == false)
                {
                    tmrPlayerAnimations.Interval = 100;
                    if (playerIdleAnimation == playerJumpAnimationFrames)
                    {
                        Player.BackgroundImage = playerIdle[playerIdleAnimation];
                        playerIdleAnimation = 0;
                    }
                    else
                    {
                        Player.BackgroundImage = playerIdle[playerIdleAnimation];
                        playerIdleAnimation++;
                    }
                }
                else
                {
                    tmrPlayerAnimations.Interval = 100;
                    if (playerIdleAnimation == playerJumpAnimationFrames)
                    {
                        Player.BackgroundImage = playerIdleRotated[playerIdleAnimation];
                        playerIdleAnimation = 0;
                    }
                    else
                    {
                        Player.BackgroundImage = playerIdleRotated[playerIdleAnimation];
                        playerIdleAnimation++;
                    }

                }

            }
        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (paused == true)
                {
                    paused = false;
                    pnlPaused.Visible = false;
                    startStopTimers(true);
                } else
                {
                    pnlPaused.BringToFront();
                    pnlPaused.Visible = true;
                    pnlPaused.BackColor = Color.FromArgb(80, 79, 249, 249);
                    paused = true;
                    startStopTimers(false);
                }


            }
            if (e.KeyCode == Keys.Space && !jumping)
            {
                foreach (Control gameObject in platforms)
                {
                        if (Player.Bounds.IntersectsWith(gameObject.Bounds) && !jumping)
                        {
                            jumping = true;
                        }

                    
                }
            }
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left) // Move left
            {
                rotated = true;
                movingLeft = true;
            }
            if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down) // Fast fall
            {
                fall = true;
            }
            if (e.KeyCode == Keys.D || e.KeyCode == Keys.Up) // Move right
            {
                movingRight = true;
                rotated = false;
            }
            if (e.KeyCode == Keys.F)
            {
                openDoor = true;
            }
        }

        private void Game_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) // Jump
            {
                if (jumping == true)
                {
                    jumping = false;
                }
            }
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left) // Move left
            {
                movingLeft = false;
            }
            if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down) // Fast fall
            {
                fall = false;
            }
            if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right) // Move right
            {
                movingRight = false;
            }
            if (e.KeyCode == Keys.F)
            {
                openDoor = false;
            }
        }

        public class DoubleBufferedPanel : Panel
        {
            public DoubleBufferedPanel()
            {
                this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                    ControlStyles.OptimizedDoubleBuffer |
                    ControlStyles.UserPaint, true);
            }
        }
    }
}
