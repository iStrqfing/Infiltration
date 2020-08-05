using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameV1
{
    public partial class Menu : Form
    {
        static int height = SystemInformation.VirtualScreen.Height;
        static int width = SystemInformation.VirtualScreen.Width;

        public Menu()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            
            AlignBtns();
        }
        
        private void AlignBtns()
        {
            //btnPlay.Left = (width / 2) - btnPlay.Width;
            //btnOptions.Left = (width / 2) - btnPlay.Width;
            //btnCredits.Left = (width / 2) - btnPlay.Width;
            //btnQuit.Left = (width / 2) - btnPlay.Width;

            //btnPlay.Top = (height / 2) + btnPlay.Height - 300;
            //btnOptions.Top = (height / 2) + btnPlay.Height - 225;
            //btnCredits.Top = (height / 2) + btnPlay.Height - 150;
            //btnQuit.Top = (height / 2) + btnPlay.Height - 75;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCredits_Click(object sender, EventArgs e)
        {

        }

        private void tmrMenuAnimations_Tick(object sender, EventArgs e)
        {
            Console.WriteLine(panel1.Left);
            if (panel1.Left >= 0)
            {
                tmrLeft.Enabled = true;
                tmrRight.Enabled = false;
            }
            
            if (panel1.Left <= -1500)
            {
                tmrRight.Enabled = true;
                tmrLeft.Enabled = false;
            }
        }




        private void btnPlay_Click_1(object sender, EventArgs e)
        {
            Game form = new Game();
            form.Show();
            this.Hide();
        }

        private void btnQuit_Click_1(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to quit the game?", "Quit Game", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                System.Environment.Exit(0);
            }
        }

        private void tmrLeft_Tick(object sender, EventArgs e)
        {
            panel1.Left--;
        }

        private void tmrRight_Tick(object sender, EventArgs e)
        {

            panel1.Left++;
        }
    }
}
