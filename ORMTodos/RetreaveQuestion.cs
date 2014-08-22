using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ORMTodos
{
    class RetreaveQuestion: IControler
    {
        void IControler.Process(string command, IEumerable<strings> args)
        {
            DBScript dbscript;

            using (LightSpeedRepository<DBScript> retreavingitems = new LightSpeedRepository<DBScript>())
            {
                incomingQuestions = dbscript.retreavingitems.First(o => o.Id == int.Parse(args.First()));
                Console.WriteLine("Question" + incomingQuestions());

            }

        }
    }
}
