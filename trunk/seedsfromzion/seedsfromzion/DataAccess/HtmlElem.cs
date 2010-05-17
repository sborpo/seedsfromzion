using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace seedsfromzion.DataAccess
{
    /// <summary>
    /// Defines the alignment of the HTML element on the screen
    /// </summary>
    public enum HtmlAlign { left, right, center };

    /// <summary>
    /// This abstract class define the methods and the fields which 
    /// are shared by all Html elements.
    /// </summary>
   abstract class HtmlElem
    {
       /// <summary>
       /// Each HTML elemnt should have it's alignment on the screen
       /// </summary>
       protected HtmlAlign alignment;

       public HtmlElem()
       { 
           //the defualt alignment is right.
           alignment = HtmlAlign.right;
       
       }

       /// <summary>
       /// This method sets the alignment of the object according to it's argument
       /// </summary>
       /// <param name="align"></param>
       public void align(HtmlAlign align)
       {
           this.alignment = align;

       }

       /// <summary>
       /// This method Prints the Html element
       /// </summary>
       /// <returns></returns>
        public abstract String toString();
        
    }
}
