using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Demo;
using Mindscape.LightSpeed;

namespace ORMTodos
{
    class Program
    {
        
        static void Main(string[] args)
        {


            Router router = new Router();
            router.Route(args);


        }
    }
}
