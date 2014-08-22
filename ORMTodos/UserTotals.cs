using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ORMTodos
{
    public class UserTotals
    {
        public int partyOne { get; set; }
        public int partyTwo { get; set; }
        public int partyThird { get; set; }
        public int partyFour { get; set; }

        public void IncrementTotal(int userChoice)
        {
            switch (userChoice)
            {
                case 1:
                    partyOne++;
                    break;
                case 2:
                    partyTwo++;
                    break;
                case 3:
                    partyThird++;
                    break;
                case 4:
                    partyFour++;
                    break;
                default:
                    break;
            }
        }

        public int ReturnCurrentChoice()
        {
            int[] choice = { partyOne, partyTwo, partyThird, partyFour };
            int maxValue = choice.Max();
            int maxIndex = choice.ToList().IndexOf(maxValue);

            return maxIndex;

        }
    }
}
