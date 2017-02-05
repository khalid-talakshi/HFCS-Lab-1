using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HFCS_Lab_1
{
    public class guy
    {
        public string name; // name of guy
        public Bet myBet; // an instance of the bet that is his bet
        public int cash; // how much cash he has

        //GUI objects
        public RadioButton myRadioButton;
        public Label myLabel; 

        public void updateLabel()
        {

        }

        public void resetBet()
        {
            
        }

        public bool placeBet(int betAmount, int dogToWin)
        {
            return true;
        }

        public void collect (int winner)
        {

        }
    }
}
