using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ORMTodos
{
    class ResponseControl : IControler
    {
        public int id { get; set; }
        public void Process(string command, IEnumerable<string> args)
        {
            ResponseModel response = new ResponseModel();
            id = Convert.ToInt32(command);
            response.IncrementTotal(id);

            
        }
    }
}
