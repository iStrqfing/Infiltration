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

        static int i = 0;

        int score = 0;

        int speed = 3; // Character movement speed
        static int speedJump = 12; // Jump speed
        int jumpSpeed = speedJump; // Character jumping speed
        int constantGravityForce = 12;
        int gravityForce = 12; // How fast the character falls

        int backgroundSpeed = 4;

        bool jumping, movingRight, movingLeft, fall, rotated, playerAbleToJump;
        bool keyFound, openDoor;

        const int playerIdleAnimationFrames = 4;
        const int playerJumpAnimationFrames = 3;
        const int playerRunningAnimationFrames = 8;
        const int playerShootingAnimationFrames = 5;

        int playerIdleAnimation, playerJumpAnimation, playerRunningAnimation, playerShootingAnimation;

        List<Image> playerIdle = new List<Image>();
        List<Image> playerJump = new List<Image>();
        List<Image> playerRunningRight = new List<Image>();
        List<Image> playerRunningLeft = new List<Image>();
        List<Image> playerShooting = new List<Image>();

        List<Image> playerIdleRotated = new List<Image>();
        List<Image> playerJumpRotated = new List<Image>();

        private void Game_Load(object sender, EventArgs e)
        {
            Player.BringToFront();
            Player.Refresh();
            this.DoubleBuffered = true;

            //foreach (Control item in this.Controls)
            //{
            //    if (item is Timer)
            //    {
            //        item.Enabled = true;
            //    }
            //}

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





        public class DoubleBufferedPanel : Panel
        {
            public DoubleBufferedPanel()
            {
                this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                    ControlStyles.OptimizedDoubleBuffer |
                    ControlStyles.UserPaint, true);
            }
        }





        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && !jumping)
            {
                foreach (Control gameObject in this.Controls)
                {
                    if (gameObject is PictureBox && gameObject.Tag == "platform" && fall == false)
                    {

                        if (Player.Bounds.IntersectsWith(gameObject.Bounds) && !jumping)
                        {
                            Console.WriteLine("does intersect");
                            jumping = true;
                        }
                    }
                    else
                    {
                        if (!Player.Bounds.IntersectsWith(gameObject.Bounds))
                        {
                            Console.WriteLine("doesnt intersect");
                        }

                    }
                }
            }
            if (e.KeyCode == Keys.A) // Move left
            {
                rotated = true;
                movingLeft = true;
            }
            if (e.KeyCode == Keys.S) // Fast fall
            {
                fall = true;
            }
            if (e.KeyCode == Keys.D) // Move right
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
            if (e.KeyCode == Keys.A) // Move left
            {
                movingLeft = false;
            }
            if (e.KeyCode == Keys.S) // Fast fall
            {
                fall = false;
            }
            if (e.KeyCode == Keys.D) // Move right
            {
                movingRight = false;
            }
            if (e.KeyCode == Keys.F)
            {
                openDoor = false;
            }
        }


        private void tmrGame_Tick(object sender, EventArgs e)
        {
            txtScore.Text = $"Score: {score}";

            if (Player.Location.Y > height + 500)
            {
                Menu form = new Menu();
                form.Show();
                this.Hide();
                tmrGame.Stop();
            }
        }

        private void tmrPlayerMovement_Tick(object sender, EventArgs e)
        {
            Console.WriteLine(playerAbleToJump);
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
            
            if (movingRight == true && Player.Left + (Player.Width + 120) < this.ClientSize.Width)
            {
                Player.Left += speed;
                foreach (Control element in this.Controls)
                {
                    if (element is PictureBox && (string)element.Tag == "platform" || element is PictureBox && (string)element.Tag == "coin" || element is PictureBox && (string)element.Tag == "key" || element is PictureBox && (string)element.Tag == "door")
                    {
                            element.Left -= backgroundSpeed;
                    }
                }
            }
            if (movingLeft == true && Player.Left > 120) 
            {
                Player.Left -= speed;
                foreach (Control element in this.Controls)
                {
                    if (element is PictureBox && (string)element.Tag == "platform" || element is PictureBox && (string)element.Tag == "coin" || element is PictureBox && (string)element.Tag == "key" || element is PictureBox && (string)element.Tag == "door")
                    {
                        element.Left += backgroundSpeed;
                    }
                }
            }

            //            

            // x of platform 
           // pnlMiddleGround.Location.X

            foreach (Control gameObject in this.Controls)
            {               
                if (gameObject is PictureBox && gameObject.Tag == "platform" && fall == false)
                {

                    if (Player.Bounds.IntersectsWith(gameObject.Bounds) && !jumping)
                    {
                        playerAbleToJump = true;
                        gravityForce = constantGravityForce;
                        Player.Top = gameObject.Top - Player.Height + 1;
                    }
                }

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
                } else if (keyFound == true && gameObject is PictureBox && gameObject.Tag == "door")
                {
                    if (Player.Bounds.IntersectsWith(gameObject.Bounds) && openDoor == true)
                    {
                        Menu form = new Menu();
                        form.Show();
                        this.Hide();
                        tmrPlayerMovement.Stop();
                    }
                }
            }
        }

        private void tmrAnimations_Tick(object sender, EventArgs e)
        {
            if (movingRight == true)
            {
                if (playerRunningAnimation == playerJumpAnimationFrames)
                {
                    Player.BackgroundImage = playerRunningRight[playerRunningAnimation];
                    playerRunningAnimation = 0;
                }
                else
                {
                    Player.BackgroundImage = playerRunningRight[playerRunningAnimation];
                    playerRunningAnimation++;
                }

            } else if (movingLeft == true)
            {
                if (playerRunningAnimation == playerJumpAnimationFrames)
                {
                    Player.BackgroundImage = playerRunningLeft[playerRunningAnimation];
                    playerRunningAnimation = 0;
                }
                else
                {
                    Player.BackgroundImage = playerRunningLeft[playerRunningAnimation];
                    playerRunningAnimation++;
                }
            } else if (jumping == true)
            {
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
            }     else
            {
                if (rotated == false)
                {
                    if (playerIdleAnimation == playerJumpAnimationFrames)
                    {
                        Player.BackgroundImage = playerIdle[playerIdleAnimation];
                        playerIdleAnimation = 0;
                    } else
                    {
                        Player.BackgroundImage = playerIdle[playerIdleAnimation];
                        playerIdleAnimation++;
                    }                    
                } else
                {
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
    }
}
