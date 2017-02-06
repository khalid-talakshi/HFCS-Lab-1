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
        public Greyhound[] greyhoundArray = new Greyhound[4];
        public guy[] guyArray = new guy[3];
        Random myRandomizer = new Random();

        public Form1()
        {
            InitializeComponent();
            setupGreyhounds();
            setupGuys();           
        }

        void setupGreyhounds()
        {
            greyhoundArray[0] = new Greyhound()
            {
                myPictureBox = pictureBox1,
                startingPosition = pictureBox1.Left,
                raceTrackLength = raceTrackPictureBox.Width - pictureBox1.Width,
                randomizer = myRandomizer
            };

            greyhoundArray[1] = new Greyhound()
            {
                myPictureBox = pictureBox2,
                startingPosition = pictureBox2.Left,
                raceTrackLength = raceTrackPictureBox.Width - pictureBox2.Width,
                randomizer = myRandomizer
            };

            greyhoundArray[2] = new Greyhound()
            {
                myPictureBox = pictureBox3,
                startingPosition = pictureBox3.Left,
                raceTrackLength = raceTrackPictureBox.Width - pictureBox3.Width,
                randomizer = myRandomizer
            };

            greyhoundArray[3] = new Greyhound()
            {
                myPictureBox = pictureBox4,
                startingPosition = pictureBox4.Left,
                raceTrackLength = raceTrackPictureBox.Width - pictureBox4.Width,
                randomizer = myRandomizer
            };

        }

        void setupGuys()
        {
            guyArray[0] = new guy
            {
                name = "Joe",
                cash = 50,
                myRadioButton = joeBetRadioButton,
                myLabel = joeBetlabel,
            };

            guyArray[1] = new guy
            {
                name = "Bob",
                cash = 75,
                myRadioButton = bobBetRadioButton,
                myLabel = bobBetLabel,
            };

            guyArray[0] = new guy
            {
                name = "Hal",
                cash = 45,
                myRadioButton = halBetRadioButton,
                myLabel = halBetLabel,
            };

            foreach (guy guy in guyArray)
            {
                guy.updateLabel();
            }
        }

    }
}
