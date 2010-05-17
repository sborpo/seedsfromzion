using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace seedsfromzion.DataAccess
{
    /// <summary>
    ///  This HTML element represents an heading in HTML document.
    /// </summary>
    class HtmlHeading : HtmlElem
    {
        /// <summary>
        /// The text that should be in the heading
        /// </summary>
        private string head;

        /// <summary>
        /// Construct HtmlHeading with the given heading text.
        /// </summary>
        /// <param name="heading"></param>
        public HtmlHeading(String heading)
        {
            head = heading;
        }

        /// <summary>
        /// Prints the heading
        /// </summary>
        /// <returns></returns>
        public override string  toString()
        {
            return String.Format("<div align={0}><h3>{1}</h3></div>", alignment.ToString(), head);
        }
    }
}
