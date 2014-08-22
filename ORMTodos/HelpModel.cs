using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ORMTodos
{
    class HelpModel
    {
        public Dictionary<String, String> HelpTopics { get; set; }

        public HelpModel()
        {
            HelpTopics = new Dictionary<String, String>()
            {
                {"help", "Helpful message about help"}, 
                {"Add", "Helpful message about Adding a todo"},
                {"List", "Helpful message about Listing todo's"}
            };
        }
    }
}
