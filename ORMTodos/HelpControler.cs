using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ORMTodos
{
    class HelpControler : IControler
    {
        public void Process(string command, IEnumerable<string> args)
        {
            HelpModel model = new HelpModel();
            HelpView view = new HelpView();


            view.Render(model);
        }
    }
}
