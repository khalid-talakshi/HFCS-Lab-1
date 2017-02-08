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

        public Bet(int amount, int dog, guy bettor)
        {
            this.amount = amount;
            this.dog = dog;
            this.Bettor = bettor;
        }
        public string GetDescription()
        {
            string description = "";

            if (amount > 0)
            {
                description = String.Format("{0} bets {1} on dog #{2}", Bettor.name, amount, dog);
            } else
            {
                description = String.Format("{0} hasn't placed any bets", Bettor.name);
            }

            return description;
        }

        public int PayOut(int winner)
        {
            if (dog == winner)
            {
                return amount;
            }

            return -amount;
            
        }
    }
}
