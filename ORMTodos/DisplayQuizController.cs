using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;

namespace ORMTodos
{
    class DisplayQuizController : IControler
    {
        public bool GameEnded { get; set; }
        public int UsersParty { get; set; }

        public void Process(string command, IEnumerable<string> args)
        {

            DispalyQuizView viewer = new DispalyQuizView();
            viewer.DisplayGamePage();

            //user input somehow captured and entered into instance of the Karens party chooser Model, usersParty var updated by method

            // end of questions or exit

            viewer.DisplayEndPage(int thepartychoice);
        }
    }
}