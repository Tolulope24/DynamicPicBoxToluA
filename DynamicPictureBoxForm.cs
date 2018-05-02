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
        /*
        * Created by:Tolu Adebayo
        * Created on: 02-05-2018
        * Created for: ICS3U Programming
        * Daily Assignment – Day #32 - Dynamic Picture Box Program
        * This program creates a Picture Box dynamically and then responds to a mouse click.
        */
        private void PictureBox_Click(object sender, EventArgs e)
        {
            //cast the sender object into a picture box
            PictureBox tmpPicMan = (PictureBox)sender;

            //  declare local variables and constants
            Console.WriteLine("Picture box (" + tmpPicMan.Location.X + "," + tmpPicMan.Location.Y + ") was clicked.");

            // declare local variables and constants
            const byte MAX_FRAMES = 10;
            int pictureFrameCounter = 1;

            // continue loop while the frame counter has not reached the max number of frames we have to display
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
            // dynamically generate a new picture box  and a new point at the given location
            PictureBox tmpPicMan = new PictureBox();
            Point pntPic = new System.Drawing.Point(x,y);
            // set the location of the picture box
            tmpPicMan.Location = pntPic;
            // assign the image to the picture box
            tmpPicMan.Image = Properties.Resources.walk1;
            // stretch the image to the size of the picture pox
            tmpPicMan.SizeMode = PictureBoxSizeMode.StretchImage;
            //make the picture box width and height to be the same as the image
            tmpPicMan.ClientSize = new Size(Properties.Resources.walk1.Width, Properties.Resources.walk1.Height);
            //add the event listner
            tmpPicMan.Click += new System.EventHandler(PictureBox_Click);
            //add the picture box to the form
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
