using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace seedsfromzion.DataAccess
{
    /// <summary>
    /// This HTML element represents the endline. after adding this element
    /// to the document , we will start a new line.
    /// </summary>
    class HtmlEndLine : HtmlElem
    {
        /// <summary>
        /// The number of lines that we want in the gap.
        /// </summary>
        private int endLines;

        /// <summary>
        /// Constructs an HtmlEndLine elemnts with a given number of endlines.
        /// </summary>
        /// <param name="numOfEndlines"></param>
        public HtmlEndLine(int numOfEndlines)
        {
            //set num of endlines
            endLines = numOfEndlines;
        }

        /// <summary>
        /// Prints the element. 
        /// </summary>
        /// <returns></returns>
        public override string toString()
        {
            StringBuilder sb = new StringBuilder();
            //<br> is end of line , print it as many times as was set
            //in the c'tor.
            for (int i = 0; i < endLines; i++)
            {
                sb.Append("<br />");
            }
            return sb.ToString();

        }

    }
}
