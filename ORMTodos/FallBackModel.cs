using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORMTodos
{
    class FallBackModel
    {
        public String Message { get; set; }

        public FallBackModel()
        {
            Message = "Type quizme to start the game.";
        }
    }
}
