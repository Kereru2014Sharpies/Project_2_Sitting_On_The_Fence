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
           
            ResponseModel userTotals = new ResponseModel();
            QuizView viewer = new QuizView();
            //viewer.Render(string question, List<string> response);
           
            //user input somehow captured and entered into instance of the Karens party chooser Model, usersParty var updated by method



            // end of questions or exit
            

        }
    }
}