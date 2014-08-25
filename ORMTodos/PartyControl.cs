using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ORMTodos
{
    class PartyControl : IControler
    {
        public void Process(string command, IEnumerable<string> args)
        {
            ResponseModel response = new ResponseModel();
            int party = response.ReturnCurrentChoice();
            switch (party)
            {
                case 1:
                    Console.WriteLine("Wishy Washy Random Party");
                    break;
                case 2:
                    Console.WriteLine("The Grumpy Party");
                    break;
                case 3:
                    Console.WriteLine("The Unicorn Farts Party");
                    break;
                case 4:
                    Console.WriteLine("The Beige Party");
                    break;
                default:
                    Console.WriteLine("Don't bother voting:");
                    break;
            }
        }
    }
}
