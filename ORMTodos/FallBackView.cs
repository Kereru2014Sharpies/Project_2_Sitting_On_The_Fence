using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORMTodos
{
    class FallBackView
    {
        public void Render()
        {
            Console.WriteLine("You need to add a command line argument. \nPass in the argument: Help for info on the available commands, \nOr Help <command argument> for info on that specific command argument.");
        }
    }
}
