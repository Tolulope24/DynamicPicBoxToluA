using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace DynamicPicBoxToluA
{
    public partial class frmDynamicPictureBox : Form
    {
        public frmDynamicPictureBox()
        {
            InitializeComponent();
            lblInstruction.Hide();
        }
        
        private void PictureBox_Click(object sender, EventArgs e)
        {
            //
            PictureBox tmpPicMan = (PictureBox)sender;

            // 
            Console.WriteLine("Picture box (" + tmpPicMan.Location.X + "," + tmpPicMan.Location.Y + ") was clicked.");

            //
            const byte MAX_FRAMES = 10;
            int pictureFrameCounter = 1;

            // 
            while (pictureFrameCounter < MAX_FRAMES + 1)
            {
                if (pictureFrameCounter == 1)
                {
                    tmpPicMan.Image = Properties.Resources.walk1;
                }
                else if (pictureFrameCounter == 2)
                {
                    tmpPicMan.Image = Properties.Resources.walk2;
                }
                else if (pictureFrameCounter == 3)
                {
                    tmpPicMan.Image = Properties.Resources.walk3;
                }
                else if (pictureFrameCounter == 4)
                {
                    tmpPicMan.Image = Properties.Resources.walk4;
                }
                else if (pictureFrameCounter == 5)
                {
                    tmpPicMan.Image = Properties.Resources.walk5;
                }
                else if (pictureFrameCounter == 6)
                {
                    tmpPicMan.Image = Properties.Resources.walk6;
                }
                else if (pictureFrameCounter == 7)
                {
                    tmpPicMan.Image = Properties.Resources.walk7;
                }
                else if (pictureFrameCounter == 8)
                {
                    tmpPicMan.Image = Properties.Resources.walk8;
                }
                else if (pictureFrameCounter == 9)
                {
                    tmpPicMan.Image = Properties.Resources.walk9;
                }
                else if (pictureFrameCounter == 10)
                {
                    tmpPicMan.Image = Properties.Resources.walk10;
                }
                // increment
                pictureFrameCounter = pictureFrameCounter + 1;
                //
                this.Refresh();
                //
                Thread.Sleep(100);
            }
        }

        private void GeneratePictureBox(int x, int y)
        {
            // dynamical
            PictureBox tmpPicMan = new PictureBox();
            Point pntPic = new System.Drawing.Point(x,y);
            // 
            tmpPicMan.Location = pntPic;
            //
            tmpPicMan.Image = Properties.Resources.walk1;
            // 
            tmpPicMan.SizeMode = PictureBoxSizeMode.StretchImage;
            //
            tmpPicMan.ClientSize = new Size(Properties.Resources.walk1.Width, Properties.Resources.walk1.Height);
            //
            tmpPicMan.Click += new System.EventHandler(PictureBox_Click);
            //
            this.Controls.Add(tmpPicMan);
        }

        private void GeneratePictureBoxes()
        {
            // Generate each of the picture boxes on the form
            GeneratePictureBox (61, 78);
            GeneratePictureBox (464, 78);
            GeneratePictureBox (61, 356);
            GeneratePictureBox (464, 358);
        }



        private void frmDynamicPictureBox_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // reveal the instructions
            this.lblInstruction.Show();
            // Generate picture boxes
            GeneratePictureBoxes();
        }
    }
}
