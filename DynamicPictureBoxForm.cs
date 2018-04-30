using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamicPicBoxToluA
{
    public partial class frmDynamicPictureBox : Form
    {
        public frmDynamicPictureBox()
        {
            InitializeComponent();
        }
        private void GeneratePictureBox()
        {
            // Generate each of the picture boxes on the form
            GeneratePictureBox (61, 78);
            GeneratePictureBox (464, 78);
            GeneratePictureBox (61, 356);
            GeneratePictureBox (464, 358);
        }

        private


        private void frmDynamicPictureBox_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {

        }
    }
}
