using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        static int speed = 6; // Character movement speed
        static int speedJump = 16; // Jump speed
        static int jumpSpeed = speedJump; // Character jumping speed
        const int constantGravityForce = 9;
        static int gravityForce = 9; // How fast the character falls
        static bool jumping = false; // Is the character jumping

        static bool movingRight = false;
        static bool movingLeft = false;


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
            }
            if (e.KeyCode == Keys.S) // Fast fall
            {
            }
            if (e.KeyCode == Keys.D) // Move right
            {
                movingRight = true;
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
            }
            if (e.KeyCode == Keys.D) // Move right
            {
                movingRight = false;
            }
        }

        private void tmrGame_Tick(object sender, EventArgs e)
        {
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

            if (movingRight == true)
            {
                Player.Left += speed;
            }

            if (movingLeft == true)
            {
                Player.Left -= speed;
            }

            //            

            // x of platform 
           // pnlMiddleGround.Location.X

            foreach (Control ground in Controls)
            {
                if (ground is PictureBox && ground.Tag == "platform")
                {
                    if (Player.Bounds.IntersectsWith(ground.Bounds) && !jumping)
                    {
                        gravityForce = constantGravityForce;
                        Player.Top = ground.Top - Player.Height;
                    }
                }
            }
        }

        private void Game_Load(object sender, EventArgs e)
        {
            Player.BringToFront();
            Player.Refresh();
            this.DoubleBuffered = true;
        }

        private void pnlBG_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
