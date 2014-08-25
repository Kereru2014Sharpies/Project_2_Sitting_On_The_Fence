using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;

namespace ORMTodos
{
    class QuizController : IControler
    {
    
        public void Process(string command, IEnumerable<string> args)
        {
            QuizView viewer = new QuizView();
            //viewer.Render(string question, List<string> response);
            Random rand = new Random();
            new RetreaveQuestion().Process("", Enumerable.Repeat(rand.Next(0,4).ToString(),1));
            Console.WriteLine("Please select 1-4");




            //user input somehow captured and entered into instance of the Karens party chooser Model, usersParty var updated by method



            // end of questions or exit
            

        }
    }
}