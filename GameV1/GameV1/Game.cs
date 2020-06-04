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
            if (e.KeyCode == Keys.Space) // Jump
            {
                tmrJump.Start();
            }
            if (e.KeyCode == Keys.A) // Move left
            {
                tmrLeftMovement.Start();
            }
            if (e.KeyCode == Keys.S) // Fast fall
            {
                tmrGravity.Start();
            }
            if (e.KeyCode == Keys.D) // Move right
            {
                tmrRightMovement.Start();
            }
        }

        private void tmrLeftMovement_Tick(object sender, EventArgs e)
        {
            pnlCharacter.Left -= 5;
        }

        private void tmrRightMovement_Tick(object sender, EventArgs e)
        {
            pnlCharacter.Left += 5;
        }

        private void tmrJump_Tick(object sender, EventArgs e)
        {
            pnlCharacter.Top -= 5;
        }

        private void tmrGravity_Tick(object sender, EventArgs e)
        {
            pnlCharacter.Top += 5;
        }

        private void Game_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) // Jump
            {
                tmrJump.Stop();
            }
            if (e.KeyCode == Keys.A) // Move left
            {
                tmrLeftMovement.Stop();
            }
            if (e.KeyCode == Keys.S) // Fast fall
            {
                tmrGravity.Stop();
            }
            if (e.KeyCode == Keys.D) // Move right
            {
                tmrRightMovement.Stop();
            }
        }
    }
}
