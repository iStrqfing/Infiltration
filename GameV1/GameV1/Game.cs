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
        public Game()
        {
            InitializeComponent();
        }

        static int speed = 5; // Character movement speed
        static int speedJump = 12; // Jump speed
        static int jumpSpeed = speedJump; // Character jumping speed
        static int gravityForce = 9; // How fast the character falls
        static bool jumping = false; // Is the character jumping

        static bool movingRight = false;
        static bool movingLeft = false;

        protected override CreateParams CreateParams // Prevents flickering when loading images
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
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
                tmrGravity.Start();
            }
            if (e.KeyCode == Keys.D) // Move right
            {
                movingRight = true;
            }
        }


        private void tmrGravity_Tick(object sender, EventArgs e)
        {
            pnlCharacter.Top += speed;
        }

        private void Game_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) // Jump
            {
                if (jumping)
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
                tmrGravity.Stop();
            }
            if (e.KeyCode == Keys.D) // Move right
            {
                movingRight = false;
            }
        }

        private void tmrGame_Tick(object sender, EventArgs e)
        {

        }

        private void tmrPlayerMovement_Tick(object sender, EventArgs e)
        {

            //pnlCharacter.Top += jumpSpeed;
            if (jumping && gravityForce < 0) // Checks whether player is jumping
            {
                jumping = false;
            }

            if (jumping)
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
                pnlCharacter.Left += speed;
            }

            if (movingLeft == true)
            {
                pnlCharacter.Left -= speed;
            }

        }
    }
}
