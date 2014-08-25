using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace ORMTodos
{
    class QuizView
    {
        public void Render(string question, List<string> answers)
        {
            Console.WriteLine("{0}", question);
            answers.ForEach(Console.WriteLine);

        }

        internal void DisplayGamePage()
        {
            // take inputs and return stuff for the view render
            throw new NotImplementedException();
        }

        internal void DisplayEndPage()
        {
            //take final int from the QuizController and display the endpage
            throw new NotImplementedException();
        }
    }
}