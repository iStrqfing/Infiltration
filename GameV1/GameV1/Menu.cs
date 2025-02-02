﻿using System;
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
        static int height;
        static int width;

        bool rocketStartLand;

        const int menuItemsYOffset = 450;
        const int menuScrollSpeed = 4;
        int currentMenuItemsYOffset;

        const int rocketX = 64;
        const int rocketY = 48;
        const int rocketOffset = 200;
        const int rocketLandSpeed = 2;

        SoundPlayer mainMusic = new SoundPlayer(@"../../Resources/Music/Battle in the winter.wav");

        public Menu()
        {
            InitializeComponent();
        }


        
        //public double Volume { get { return Volume; } set { Volume = 0.1; } }

            private void stopTimers()
        {
            tmrLandRocket.Stop();
            tmrLeft.Stop();
            tmrRight.Stop();
            tmrWait.Stop();

        }

        private void setMenuItemLocations()
        {
            foreach (Control x in this.Controls)
            {
                if (x.Tag != "rocket")
                {
                    x.Top += menuItemsYOffset;
                } 
                if (x.Tag == "rocket")
                {
                    x.Location = new Point(rocketX, rocketY - rocketOffset);
                }
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            width = this.Width;
            height = this.Height;
            setMenuItemLocations();
            //mainMusic.Play();
            AlignBtns();
        }
        
        private void AlignBtns()
        {
            lblTitle.Left = (width / 2) - lblTitle.Width / 2;
            btnPlay.Left = (width / 2) - btnPlay.Width / 2;
            btnCredits.Left = (width / 2) - btnCredits.Width / 2;
            btnQuit.Left = (width / 2) - btnQuit.Width / 2;

            //btnPlay.Top = (height / 2) + btnPlay.Height - 300;
            //btnOptions.Top = (height / 2) + btnPlay.Height - 225;
            //btnCredits.Top = (height / 2) + btnPlay.Height - 150;
            //btnQuit.Top = (height / 2) + btnPlay.Height - 75;
        }


        private void tmrMenuAnimations_Tick(object sender, EventArgs e)
        {           
            if (pctBoxBG.Left >= 0)
            {
                tmrLeft.Enabled = true;
                tmrRight.Enabled = false;
            }
            
            if (pctBoxBG.Left <= -1470)
            {
                tmrRight.Enabled = true;
                tmrLeft.Enabled = false;
            }
        }





        private void tmrLeft_Tick(object sender, EventArgs e)
        {
            pctBoxBG.Left--;
            pctBoxRocket.Left--;
        }

        private void tmrRight_Tick(object sender, EventArgs e)
        {
            pctBoxRocket.Left++;
            pctBoxBG.Left++;
        }

        private void btnPlay_Click_2(object sender, EventArgs e)
        {
            stopTimers();
            mainMusic.Stop();
            Game form = new Game();
            form.Show();
            this.Hide();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to quit the game?", "Quit Game", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                System.Environment.Exit(0);
            }
        }

        private void tmrLandRocket_Tick(object sender, EventArgs e)
        {
            Console.WriteLine(pctBoxRocket.Top);

            if (rocketStartLand)
            {
                if (currentMenuItemsYOffset < menuItemsYOffset)
                {
                    foreach (Control x in this.Controls)
                    {
                        if (x.Tag != "rocket")
                        {
                            x.Top -= menuScrollSpeed;
                        }
                    }
                    currentMenuItemsYOffset += menuScrollSpeed;
                }
                else if (currentMenuItemsYOffset >= menuItemsYOffset)
                {
                    tmrLandRocket.Stop();
                    pctBoxBG.Location = new Point(0, 0);
                    tmrWait.Enabled = true;
                    pctBoxRocket.Height = 109;
                    pctBoxRocket.BackgroundImage = Image.FromFile("../../Resources/Game Objects/Story Line/rocketOff.png");
                }
            } else
            {
                if (pctBoxRocket.Location.Y != rocketY)
                {
                    pctBoxRocket.Top += rocketLandSpeed;
                } else
                {
                    rocketStartLand = true;
                }
                
            }          
        }

        private void tmrWait_Tick(object sender, EventArgs e)
        {
            tmrMenuAnimations.Enabled = true;
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnCredits_Click(object sender, EventArgs e)
        {
            stopTimers();
            Credits form = new Credits();
            form.Show();
            this.Hide();
        }
    }
}
