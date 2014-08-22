using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ORMTodos
{
    class RetreaveQuestionControler: IControler
    {
        void IControler.Process(string command, IEnumerable<string> args)
        {
           

            using (LightSpeedRepository<Question> retreavingitems = new LightSpeedRepository<Question>())
            {
                incomingQuestions = retreavingitems.GetAll.First(o => o.Id == int.Parse(args.First()));
                Console.WriteLine("Question" + incomingQuestions());

            }

        }
    }
}
