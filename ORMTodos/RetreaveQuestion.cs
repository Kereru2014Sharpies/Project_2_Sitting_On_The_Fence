using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ORMTodos
{
    class RetreaveQuestion: IControler
    {
        public void Process(string command, IEnumerable<string> args)
        {
            using (LightSpeedRepository<Question> retreavingitems = new LightSpeedRepository<Question>())
            {
                var incomingQuestions = retreavingitems.GetAll().ElementAt( int.Parse(args.First()));
                Console.WriteLine("Question" + incomingQuestions.QuestionField);
            }

        }
    }
}
