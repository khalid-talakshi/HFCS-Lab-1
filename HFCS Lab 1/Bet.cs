using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFCS_Lab_1
{
    public class Bet
    {
        public int amount;
        public int dog;
        public guy  Bettor;

        public string GetDescription()
        {
            string description = "";
            if (amount > 0)
            {
                description = Bettor.name + " bets $" + amount + " on dog #" + dog;
            } else
            {
                description = Bettor.name + " has not placed a bet";
            }

            return description;
        }

        public int PayOut(int winner)
        {
            if (dog == winner)
            {
                return 2 * amount;
            }

            return -amount;
            
        }
    }
}
