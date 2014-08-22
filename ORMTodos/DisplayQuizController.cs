using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;

namespace ORMTodos
{
    class DisplayQuizController : IControler
    {
        public void Process(string command, IEnumerable<string> args)
        {
            DispalyQuizView viewer = new DispalyQuizView();
            //jesses method instantiated

            //viewer.Render(jesses, List of answers);
        }
    }
}