using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;

namespace GameV1
{
    public partial class SplashScreen : Form
    {
        static int height = SystemInformation.VirtualScreen.Height;
        static int width = SystemInformation.VirtualScreen.Width;

        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            pctBoxLogo.Top = (height / 2) - (pctBoxLogo.Height / 2) - (200);
            pctBoxLogo.Left = 0 - pctBoxLogo.Width;

            lblPresents.Top = (height / 2) - (pctBoxLogo.Height / 2);
            lblPresents.Left = 0 - lblPresents.Width;

            //SoundPlayer simpleSound = new SoundPlayer(@"K:\12IA\Downloads\Lurid Delusion.wav");
            //simpleSound.Play();
        }

        private void tmrShowLogo_Tick(object sender, EventArgs e)
        {
            if (pctBoxLogo.Left < (width / 2) - (pctBoxLogo.Width / 2))
            {
                pctBoxLogo.Left += ((width / 2) - (pctBoxLogo.Width / 2)) / 20;
            }           

            if (pctBoxLogo.Left >= (width / 2) - (pctBoxLogo.Width / 2))
            {
                
                tmrShowLogo.Stop();
                System.Threading.Thread.Sleep(1000);
                tmrShowText.Start();
            }
        }

        private void tmrShowText_Tick(object sender, EventArgs e)
        {

            if (lblPresents.Left < (width / 2) - (lblPresents.Width / 2))
            {
                lblPresents.Left += ((width / 2) - (lblPresents.Width / 2)) / 20;
            }

            if (lblPresents.Left >= (width / 2) - (lblPresents.Width / 2))
            {
                tmrShowText.Stop();
                System.Threading.Thread.Sleep(3000);

                GameSplashScreen form = new GameSplashScreen();
                form.Show();
                this.Hide();
            }
        }
    }
}
