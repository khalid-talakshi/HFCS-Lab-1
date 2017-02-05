using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HFCS_Lab_1
{
    public partial class Form1 : Form
    {
        public Greyhound[] greyhoundArray;

        public Form1()
        {
            InitializeComponent();

            greyhoundArray[0] = new Greyhound()
            {
                myPictureBox = pictureBox1,
                startingPosition = pictureBox1.Left,
                raceTrackLength = raceTrackPictureBox.Width - pictureBox1.Width,
                randomizer = myRandomizer;

            };
        }

        


    }
}
