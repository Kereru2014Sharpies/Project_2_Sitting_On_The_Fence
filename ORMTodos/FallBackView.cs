using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORMTodos
{
    class FallBackView
    {
        public void Render(FallBackModel model)
        {
            Console.WriteLine("{0}", model.Message);
        }
    }
}
