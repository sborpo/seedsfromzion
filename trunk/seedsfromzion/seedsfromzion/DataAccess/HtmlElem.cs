using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace seedsfromzion.DataAccess
{
    public enum HtmlAlign { left, right, center };
   abstract class HtmlElem
    {
       protected HtmlAlign alignment;
       public HtmlElem()
       { 
           alignment = HtmlAlign.right;
       
       }
       public void align(HtmlAlign align)
       {
           this.alignment = align;

       }
        public abstract String toString();
        
    }
}
