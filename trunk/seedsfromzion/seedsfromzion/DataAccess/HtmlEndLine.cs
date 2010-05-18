using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace seedsfromzion.DataAccess
{
    class HtmlEndLine : HtmlElem
    {
        private int endLines;
        public HtmlEndLine(int numOfEndlines)
        {
            endLines = numOfEndlines;
        }


        public override string toString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < endLines; i++)
            {
                sb.Append("<br />");
            }
            return sb.ToString();
            
        }

    }
}
