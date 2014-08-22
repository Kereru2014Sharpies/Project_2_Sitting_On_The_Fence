using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace ORMTodos
{
    class DispalyQuizView
    {
        public void Render(string question, List<string> answers)
        {
            Console.WriteLine("{0}", question);
            answers.ForEach(Console.WriteLine);
            
        }
    }
}
