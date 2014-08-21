using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORMTodos
{
    class FallBackControler: IControler
    {
     

        public void Process(string command, IEnumerable<string> args)
        {
            FallBackModel model = new FallBackModel();
            FallBackView view = new FallBackView();
            

            view.Render(model);
        }
    }
}
