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
        static int height;
        static int width;


        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            height = this.Height;
            width = this.Width;

            pctBoxLogo.Top = (height / 2) - (pctBoxLogo.Height / 2) - (100);
            pctBoxLogo.Left = 0 - pctBoxLogo.Width;

            lblPresents.Top = (height / 2) - (pctBoxLogo.Height / 2) + 50;
            lblPresents.Left = 0 - lblPresents.Width;    
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

                StoryLine form = new StoryLine();
                form.Show();
                this.Hide();
            }
        }
    }
}
