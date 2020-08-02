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

        int score = 0;

        int speed = 6; // Character movement speed
        static int speedJump = 16; // Jump speed
        int jumpSpeed = speedJump; // Character jumping speed
        int constantGravityForce = 9;
        int gravityForce = 9; // How fast the character falls

        int backgroundSpeed = 8;

        bool jumping, movingRight, movingLeft, fall;


        List<Image> playerIdle = new List<Image>();
        List<Image> playerJump = new List<Image>();
        List<Image> playerRunningRight = new List<Image>();
        List<Image> playerRunningLeft = new List<Image>();
        List<Image> playerShooting = new List<Image>();

        static int JUMP_ANIMATION_IMAGE = 2;


        private void Game_Load(object sender, EventArgs e)
        {
            Player.BringToFront();
            Player.Refresh();
            this.DoubleBuffered = true;


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

            //Flip each image set
            foreach (Image image in playerRunningLeft)
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
            if (e.KeyCode == Keys.Space && !jumping) // Jump if character is not jumping
            {
                jumping = true;                             
            }
            if (e.KeyCode == Keys.A) // Move left
            {
                movingLeft = true;
                MoveGameElements("forward");
            }
            if (e.KeyCode == Keys.S) // Fast fall
            {
                fall = true;
            }
            if (e.KeyCode == Keys.D) // Move right
            {
                movingRight = true;               
                MoveGameElements("back");
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
        }

        private void MoveGameElements(string direction)
        {
            //foreach (Control element in this.Controls)
            //{
            //    if (element is PictureBox && (string)element.Tag == "platform" || element is PictureBox && (string)element.Tag == "coin" || element is PictureBox && (string)element.Tag == "key" || element is PictureBox && (string)element.Tag == "door")
            //    {
            //        if (direction == "back")
            //        {
            //            element.Left -= backgroundSpeed;
            //        }
            //        else if (direction == "forward")
            //        {
            //            element.Left += backgroundSpeed;
            //        }
            //    }
            //}
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

            foreach (Control ground in Controls)
            {
                if (ground is PictureBox && ground.Tag == "platform" && fall == false)
                {
                    if (Player.Bounds.IntersectsWith(ground.Bounds) && !jumping)
                    {
                        gravityForce = constantGravityForce;
                        Player.Top = ground.Top - Player.Height + 1;
                    }
                }
            }
        }


        static int i = 0;



        private void tmrAnimations_Tick(object sender, EventArgs e)
        {
            if (movingRight == true)
            {
                if (i < 7)
                {
                    i++;
                }
                else
                {
                    i = 0;
                }
                Player.BackgroundImage = playerRunningRight[i];

            } else if (movingLeft == true)
            {
                if (i < 7)
                {
                    i++;
                }
                else
                {
                    i = 0;
                }
                Player.BackgroundImage = playerRunningLeft[i];
            } else if (jumping == true)
            {
                //Player.BackgroundImage = playerJump[JUMP_ANIMATION_IMAGE];
                if (JUMP_ANIMATION_IMAGE == playerJump.Count)
                {
                    JUMP_ANIMATION_IMAGE = 0;
                } else
                {
                    JUMP_ANIMATION_IMAGE++;
                }
            }     else
            {
                Player.BackgroundImage = playerIdle[1];
            }      
        }
    }
}
