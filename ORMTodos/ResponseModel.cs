using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ORMTodos
{
    public class ResponseModel
    {
        public void IncrementTotal(int userChoice)
        {
            switch (userChoice)
            {
                case 1:
                    StateHolder.partyOne++;
                    break;
                case 2:
                    StateHolder.partyTwo++;
                    break;
                case 3:
                    StateHolder.partyThird++;
                    break;
                case 4:
                    StateHolder.partyFour++;
                    break;
                default:
                    break;
            }
        }

        public int ReturnCurrentChoice()
        {
            int[] choice = { StateHolder.partyOne, StateHolder.partyTwo, StateHolder.partyThird, StateHolder.partyFour };
            int maxValue = choice.Max();
            int maxIndex = choice.ToList().IndexOf(maxValue);

            return maxIndex + 1;

        }
    }
}
