using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace seedsfromzion.DataAccess
{
    /// <summary>
    /// This Html elements represnts a paragraph in Html Document
    /// </summary>
    class HtmlParagraph : HtmlElem
    {
        /// <summary>
        /// The string which represents the paragraph text
        /// </summary>
        private string paragraph;

        /// <summary>
        /// Construct an HtmlParagraph with a given text
        /// </summary>
        /// <param name="paragraph"></param>
        public HtmlParagraph(String paragraph)
        {
            this.paragraph = paragraph;
        }

        /// <summary>
        /// Prints an Html Patagraph
        /// </summary>
        /// <returns></returns>
        public override string toString()
        {
            //<p> is html tag for paragrahp
            return String.Format("<div align={0}><p>{1}</p></div>", alignment.ToString(), paragraph);
        }

    }
}
