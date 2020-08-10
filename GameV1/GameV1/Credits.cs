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
    public partial class Credits : Form
    {
        public Credits()
        {
            InitializeComponent();
        }

        private void Credits_Load(object sender, EventArgs e)
        {
            int width = this.Width;
            int height = this.Height;
            int labelHeight = 80;

            this.DoubleBuffered = true;

            foreach (Control x in this.Controls)
            {
                if (x is Label)
                {
                    x.Left = (width / 2) - x.Width / 2;
                }
            }

             foreach (Control x in this.Controls)
            {
                if (x is Label && x.Tag == "titleArt")
                {
                    labelHeight += 120;                   
                    x.Top = labelHeight;
                    labelHeight += 70;
                }
            }            

            foreach (Control x in this.Controls)
            {
                if (x is Label && x.Tag != "title" && x.Tag != "titleArt" && x.Tag != "music" && x.Tag != "titleMusic" && x.Tag != "copyright")
                {
                    x.Top = labelHeight;
                    labelHeight += 40;
                }
            }
            foreach (Control x in this.Controls)
            {
                if (x is Label && x.Tag == "titleMusic")
                {
                    labelHeight += 40;
                    x.Top = labelHeight;
                    labelHeight += 70;
                } 
            }
            foreach (Control x in this.Controls)
            {
                if (x is Label && x.Tag == "music")
                {
                    x.Top = labelHeight;
                    labelHeight += 40;
                }
            }
            foreach (Control x in this.Controls)
            {
                if (x is Label && x.Tag == "copyright")
                {
                    labelHeight += 40;
                    x.Top = labelHeight;                   
                    labelHeight += 70;
                }
            }

            
            tmrScroll.Enabled = true;
        }

        private void tmrScroll_Tick(object sender, EventArgs e)
        {

            foreach (Control x in this.Controls)
            {
                if (x is Label)
                {
                    x.Top -= 2;
                }
            }
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

        private void tmrCheckFinished_Tick(object sender, EventArgs e)
        {
            foreach (Control x in this.Controls)
            {
                if (x is Label && x.Tag == "copyright")
                {
                    if (x.Top < -80)
                    {
                        tmrCheckFinished.Stop();
                        Menu form = new Menu();
                        form.Show();
                        this.Hide();
                    }
                }
            }
        }
    }
}
