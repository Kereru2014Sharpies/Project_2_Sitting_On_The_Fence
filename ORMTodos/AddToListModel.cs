using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ORMTodos
{
    class AddToListModel
    {
        private List<string> AnswerList = new List<string>();

        public void AddAnswer(string answer)
        {
            AnswerList.Add(answer);
        }
    }
}
