using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ORMTodos;

namespace Demo
{
    class Router
    {
        public void RunOneRoute(string[] args)
        {
            RunCommandCycle(args);
        }

        public void Route(string[] initalArgs)
        {

            IControler controler = ControlerFactory("welcome");
            controler.Process("welcome", Enumerable.Repeat(String.Empty,0));

            while (true)
            {
                var args = Console.ReadLine() ?? String.Empty;
                var cleanedUpArgs = args.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                Console.Clear();

                if (args.Equals("exit",StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

                RunCommandCycle(cleanedUpArgs);
            }
           
        }

        protected void RunCommandCycle(string[] args)
        {
            String command = args.Length != 0 ? args[0].ToLowerInvariant() : String.Empty;

            IControler controler = ControlerFactory(command);

            controler.Process(command, args.Skip(1));
        }

        protected IControler ControlerFactory(string command)
        {
            IControler controler;
            switch (command)
            {
                case "add":
                    controler = new AddControler();
                    break;
                case "help":
                case "h":
                case "-h":
                    controler = new HelpControler();
                    break;
                default:
                    controler = new FallBackControler();
                    break;
            }
            return controler;
        }
    }
}
