using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace seedsfromzion.DataAccess
{
    class HtmlParagraph : HtmlElem
    {
        private string paragraph;
        public HtmlParagraph(String paragraph)
        {
            this.paragraph = paragraph;
        }


        public override string toString()
        {
            return String.Format("<div align={0}><p>{1}</p></div>", alignment.ToString(), paragraph);
        }

    }
}
