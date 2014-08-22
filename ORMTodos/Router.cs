﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ORMTodos;

namespace Demo
{
    class Router
    {
        public void Route(string[] args)
        {
            String command = args.Length != 0 ? args[0].ToLowerInvariant() : String.Empty;

            IControler controler;
            switch (command)
            {
                case "add":
                    controler = new AddControler();
                    break;
                case "help" :
                case "h":
                case "-h":
                    controler = new HelpControler();
                    break;
                default :
                    controler = new FallBackControler();
                    break;
            }

            controler.Process(command,args.Skip(1));
        }
    }
}