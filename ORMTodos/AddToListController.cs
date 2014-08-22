using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ORMTodos
{
    class AddToListController : IControler
    {
        public void Process(string command, IEnumerable<string> args)
        {
            AddToListModel Saver = new AddToListModel();
            Saver.AddAnswer(String.Join(" ", args));
        }
    }
}
