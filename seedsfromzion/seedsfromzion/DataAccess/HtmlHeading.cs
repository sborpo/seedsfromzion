using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace seedsfromzion.DataAccess
{
    class HtmlHeading : HtmlElem
    {
        private string head;
        public HtmlHeading(String heading)
        {
            head = heading;
        }

        public override string  toString()
        {
            return String.Format("<div align={0}><h3>{1}</h3></div>", alignment.ToString(), head);
        }
    }
}
