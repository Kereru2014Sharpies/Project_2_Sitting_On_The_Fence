using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ORMTodos
{
    class HelpView
    {
        public void Render(HelpModel model)
        {
            foreach (var topic in model.HelpTopics)
            {
                Console.WriteLine("{0}", topic.Value);
            }
        }
    }
}
