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

            if (myBet == null)
            {

                myLabel.Text = String.Format("{0} hasn't placed any bets", name);

            }
            else
            {

                myLabel.Text = myBet.GetDescription();

            }
            myRadioButton.Text = name + " has " + cash + " bucks";

        }

        public void resetBet()
        {
            myBet.amount = 0;
        }

        public bool placeBet(int betAmount, int dogToWin)
        {

            if (betAmount <=  cash)
            {
                Bet myBet = new Bet(betAmount, dogToWin, this);
                return true;
            }   
            else
            {
                myRadioButton.Text = name + " has insufficent funds.";
                return false;
            }
            
        }

        public void collect (int winner)
        {
            cash += myBet.PayOut(winner);
        }
    }
}
