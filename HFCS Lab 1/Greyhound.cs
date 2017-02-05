using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            return true;
        }

        public void takeStartingPosition()
        {
            return;
        }
    }
}
