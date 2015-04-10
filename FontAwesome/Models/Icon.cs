using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FontAwesome.Models
{
    public class Icon
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Unicode { get; set; }
        
        public string HtmlCode
        {
            get
            {
                return "&#x" + Code + ";";
            }
        }

        public override string ToString()
        {
            return Unicode;
        }
    }
}
