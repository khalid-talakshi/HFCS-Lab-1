using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace HFCS_Lab_1
{
    public class Greyhound
    {
        public int startingPosition; // Where pictureBox starts 
        public int raceTrackLength; // How long the race track is
        public PictureBox myPictureBox = null; // Object  myPictureBox
        public int location = 0; // my location on the racetrack
        public Random randomizer; // randomizer object

        public bool run()
        {
            // Randomly chooses distance run
            randomizer = new Random();
            int distance = randomizer.Next(1, 5);

            //Moves the picturebox that many units (1 unit = 1 greyhound)
            Point p = myPictureBox.Location;
            p.X += myPictureBox.Width * distance;
            location += distance;

            //check if greyhound crossed finish line
            if (location >= raceTrackLength - startingPosition)
            {
                return true;
            }

            return false;
            
        }

        public void takeStartingPosition()
        {
            Point p = myPictureBox.Location;
            p.X -= myPictureBox.Width * location;
            location = 0;
        }

    }
}
