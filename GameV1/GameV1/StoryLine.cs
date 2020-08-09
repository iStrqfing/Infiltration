using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace GameV1
{
    public partial class StoryLine : Form
    {

        const int playerRunningAnimationFrames = 7;
        int playerRunningAnimation;

        const int starBackgroundAnimationFrames = 5;
        int starBackgroundAnimation;

        int playerMovementSpeed = 2;

        int countdownNumber = 10;
        int countdownTimerNumber = 0;

        bool rocketFirstPhase = true;
        bool rocketSecondPhase, rocketThirdPhase, rocketFourthPhase, rocketFifthPhase, rocketSixthPhase;

        const int rocketFirstPhaseNumber = 1250;
        int rocketFirstPhaseCountdown = 0;

        SoundPlayer mainMusic = new SoundPlayer(@"../../Resources/Music/space walk.wav");
        List<Image> playerRunningLeft = new List<Image>();
        List<Image> spaceBackgrounds = new List<Image>();
        List<Image> starBackground = new List<Image>();
        public StoryLine()
        {
            InitializeComponent();
        }














        private void tmrMain_Tick(object sender, EventArgs e)
        {
            lblCountdownTxt.Left = this.Width / 2 - lblCountdownTxt.Width / 2;
            lblGameTitle.Left = this.Width / 2 - lblGameTitle.Width / 2;


            Player.Left -= playerMovementSpeed;
            if (tmrCountdown.Enabled == false && tmrRocket.Enabled == false)
            {
                foreach (Control gameObject in this.Controls)
                {
                    if (gameObject.Tag == "rocket")
                    {
                        if (Player.Bounds.IntersectsWith(gameObject.Bounds))
                        {
                            lblCountdownTxt.Visible = true;
                            Player.Dispose();
                            lblGameTitle.Dispose();
                            tmrCountdown.Enabled = true;
                        }
                    }
                }
            }
            



        }

        private void lblCountdownTxt_Click(object sender, EventArgs e)
        {

        }

        private void tmrCountdown_Tick(object sender, EventArgs e)
        {
            if (countdownTimerNumber == 70 && countdownNumber != 0)
            {
                countdownNumber -= 1;
                lblCountdownTxt.Text = $"{countdownNumber}";
                countdownTimerNumber = 0;
            }
            else if (countdownTimerNumber != 70)
            {
                countdownTimerNumber++;
            }
            else if (countdownNumber == 0)
            {
                lblCountdownTxt.Dispose();
                tmrCountdown.Stop();
                tmrRocket.Enabled = true;
            }
        }

        private void StoryLine_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            mainMusic.Play();
            loadAnimations();
            loadLocations();         
        }

        private void tmrRocket_Tick(object sender, EventArgs e)
        {
            //First phase
            if (rocketFirstPhase)
            {
                if (rocketFirstPhaseCountdown < rocketFirstPhaseNumber)
                {
                    foreach (Control x in this.Controls)
                    {
                        if (x.Tag != "rocket")
                        {
                            x.Top += 5;
                        }
                        rocketFirstPhaseCountdown++;
                    }
                }
                else if (pctBoxRocket.Top > -300)
                {
                    pctBoxRocket.Top -= 5;
                }
                else
                {
                    rocketFirstPhase = false;
                    rocketSecondPhase = true;
                    this.BackgroundImage = spaceBackgrounds[3];
                    pctBoxRocket.Top = this.Height + 100;
                }
            }
            else if (rocketSecondPhase) //Second phase
            {
                pctBoxRocket.Size = new Size(51,104);
                foreach (Control Clouds in this.Controls)
                {
                    if (Clouds is PictureBox && Clouds.Tag == "cloud")
                    {
                        Clouds.Dispose();
                    }
                }
                if (pctBoxRocket.Top > -300)
                {
                    pctBoxRocket.Top -= 5;
                }
                else
                {
                    this.BackgroundImageLayout = ImageLayout.Tile;
                    //tmrStartBackground.Start();

                    

                    rocketSecondPhase = false;
                    rocketThirdPhase = true;
                    //this.BackgroundImage = starBackground[0];
                    this.BackgroundImage = Image.FromFile("../../Resources/Game Objects/Story Line/starTile.png");
                    pctBoxRocket.Top = this.Height + 100;
                }
            }
            else if (rocketThirdPhase) //Third phase
            {
                if (pctBoxRocket.Top > -300)
                {
                    pctBoxRocket.Top -= 5;
                }
                else
                {
                    this.BackgroundImageLayout = ImageLayout.Tile;
                    //tmrStartBackground.Start();
                    //this.BackgroundImage = starBackground[0];
                    this.BackgroundImage = Image.FromFile("../../Resources/Game Objects/Story Line/starTile.png");
                    pctBoxRocket.Top = this.Height + 100;
                    rocketThirdPhase = false;
                    rocketFourthPhase = true;
                }
            }

            else if (rocketFourthPhase) //Fourth phase
            {
                if (pctBoxRocket.Top > -300)
                {
                    pctBoxRocket.Top -= 5;
                }
                else
                {
                    tmrStartBackground.Stop();
                    this.BackgroundImageLayout = ImageLayout.Stretch;
                    this.BackgroundImage = spaceBackgrounds[4];
                    pctBoxRocket.Top = this.Height + 100;

                    rocketFourthPhase = false;
                    rocketFifthPhase = true;
                }
            }
            else if (rocketFifthPhase) //Fifth phase
            {
                if (pctBoxRocket.Top > -300)
                {
                    pctBoxRocket.Top -= 5;
                }
                else
                {
                    rocketFifthPhase = false;
                    ////rocketSixthPhase = true;
                    //this.BackgroundImage = spaceBackgrounds[4];
                    pctBoxRocket.Top = this.Height + 100;
                }
            
              //}else if (rocketSixthPhase) //Sixth phase
                //{
                //    if (pctBoxRocket.Top > -300)
                //    {
                //        pctBoxRocket.Top -= 5;
                //    }
                //    else
                //    {
                //        rocketSixthPhase = false;                   
                //        this.BackgroundImage = spaceBackgrounds[2];
                //        pctBoxRocket.Top = this.Height + 100;
                //    }
            } else
            {
                startMenu();
            }
        }

        private void tmrStartBackground_Tick(object sender, EventArgs e)
        {
            if (starBackgroundAnimation == starBackgroundAnimationFrames)
            {
                this.BackgroundImage = starBackground[starBackgroundAnimation];
                starBackgroundAnimation = 0;
            }
            else
            {
                this.BackgroundImage = starBackground[starBackgroundAnimation];
                starBackgroundAnimation++;
            }
        }

        private void loadAnimations()
        {
            foreach (FileInfo image in new DirectoryInfo("../../Resources/Game Objects/Story Line/Space Backgrounds").GetFiles())
            {
                spaceBackgrounds.Add(Image.FromFile(image.FullName));
            }

            foreach (FileInfo image in new DirectoryInfo("../../Resources/Game Objects/Story Line/Stars").GetFiles())
            {
                starBackground.Add(Image.FromFile(image.FullName));
            }
            // Flipped image sets
            foreach (FileInfo image in new DirectoryInfo("../../Resources/Player/Run").GetFiles())
            {
                playerRunningLeft.Add(Image.FromFile(image.FullName));
            }

            // Flips the images
            foreach (Image image in playerRunningLeft)
            {
                image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            }
        }

        private void loadLocations()
        {
            Player.Left = 970;
            pctBoxCloud.Top = -610;
            pctBoxCloud2.Top = -450;
            lblCountdownTxt.Visible = false;
        }

        private void tmrPlayerMovement_Tick(object sender, EventArgs e)
        {
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


        private void startMenu()
        {
            Menu form = new Menu();
            form.Show();
            this.Hide();

            foreach (Control x in this.Controls)
            {
                x.Dispose();
            }

            foreach (Image x in spaceBackgrounds)
            {
                x.Dispose();
            }
            foreach (Image x in starBackground)
            {
                x.Dispose();
            }
            foreach (Image x in playerRunningLeft)
            {
                x.Dispose();
            }

            tmrCountdown.Stop();
            tmrMain.Stop();
            tmrPlayerMovement.Stop();
            tmrRocket.Stop();
            tmrStartBackground.Stop();
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
    }
}
