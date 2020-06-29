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
    public partial class GameSplashScreen : Form
    {

        /// <summary>
        /// Prevents flickering when loading images
        /// </summary>
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        static int height = SystemInformation.VirtualScreen.Height;
        static int width = SystemInformation.VirtualScreen.Width;

        public GameSplashScreen()
        {
            InitializeComponent();
        }

        private void GameSplashScreen_Load(object sender, EventArgs e)
        {
            pnlGameSplash.Top = (height / 2) - (pnlGameSplash.Height / 2) - (200);
            pnlGameSplash.Left = (width / 2) - pnlGameSplash.Width;

            pnlGameSplash.Refresh();

            System.Threading.Thread.Sleep(3000);

            Menu form = new Menu();
            form.Show();
            this.Hide();
        }
    }
}
