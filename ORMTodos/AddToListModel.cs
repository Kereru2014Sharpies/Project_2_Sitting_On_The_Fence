using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ORMTodos
{
    class AddToListModel
    {
        private List<string> UserSelectedList = new List<string>();

        public void AddAnswer(string answer)
        {
            UserSelectedList.Add(answer);
        }
    }
}
