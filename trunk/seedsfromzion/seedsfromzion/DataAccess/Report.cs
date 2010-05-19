using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.IO;

namespace seedsfromzion.DataAccess
{
    /// <summary>
    /// Represent a printable HTML report. manages 
    /// the HTML document. In order to conduct a document , just construct
    /// an instance of this class and use the append method to add HTML Elements
    /// to the document. finnally use the save method to save the document in the 
    /// file system
    /// </summary>
    class Report
    {
        /// <summary>
        /// Represent the document style of the report, It can be a colored document
        /// or a Black&White document which is better for printing.
        /// </summary>
        public enum ReportStyle {BlackWhite, Color};

        /// <summary>
        /// A linked list , where the order is significant. stores the html
        /// element of the document.
        /// </summary>
        private LinkedList<HtmlElem> document;

        /// <summary>
        /// Stores the current style of the document
        /// </summary>
        private ReportStyle docStyle;
        
        /// <summary>
        /// Constructs an empty report, with defualt properties
        /// </summary>
        public Report()
        {
            document = new LinkedList<HtmlElem>();
            //the defualt style is colored
            this.ReportColor = ReportStyle.Color;
            //add a signature of the system to the documents
            addSignature();
        }

        /// <summary>
        /// This method appends an HTML element to the end of the document
        /// </summary>
        /// <param name="elem"></param>
        /// <returns></returns>
        public Report append(HtmlElem elem)
        {
            document.AddLast(elem);
            return this;
        }

        /// <summary>
        /// Sets and gets the color style of the document
        /// </summary>
        public ReportStyle ReportColor
        {
            get
            {
                return docStyle;
            }
            set
            {
                docStyle = value;
            }
        }

        /// <summary>
        /// Save the report as an HTML text file to the specific given
        /// location in the file system 
        /// </summary>
        /// <param name="targetDir"></param>
        public void save(string targetDir)
        {
            //if the file exists , delete it
            if (File.Exists(targetDir))
            {
                File.Delete(targetDir);
            }
            //add the header to the document
            addHeader();
            TextWriter tw =null;
            try
            {
                //print the report to the file
                tw=new StreamWriter(targetDir);
                foreach (HtmlElem elem in document)
                {
                    tw.Write(elem.toString());
                }
            }
            finally
            {
                if (tw!=null){tw.Close();}
            }
        }

        /// <summary>
        /// Represent an Html code that can be added to the document
        /// </summary>
        private class HtmlCode : HtmlElem
        {
            private String code;
            public HtmlCode(String code)
            {
                this.code=code;
            }
            public override  String toString()
            {
                return code;
            }
        }

        /// <summary>
        /// This method adds the header to the document. Hebrew encoding and ect.
        /// </summary>
        private void addHeader()
        {
            string style = (docStyle.Equals(ReportStyle.BlackWhite)) ? Properties.Resources.blackAndWhiteStyle : Properties.Resources.colorStyle;
            HtmlCode code = new HtmlCode("<head>" +
                                      "<meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\">" +
                                      "<style type=\"text/css\">" +
                                      style+
                                      "</style>" +
                                      "</head>");

            document.AddFirst(code);

        }

        /// <summary>
        /// This method adds the system signature to the documents
        /// in consist of the name of the system and a Time Stamp.
        /// </summary>
        private void addSignature()
        {
            string time=DateTime.Now.ToLocalTime().ToString();
            HtmlCode code = new HtmlCode("<table class=\"sign\"><tr><td class=\"tdSign\"><h1 class=\"signature\"><div align=left>" + time + "</div></h1></td><td class=\"tdSign\"><div align=right><h1 class=\"signature\">המסמך נוצר על ידי מערכת לניהול עסקי זרעים מציון</h1></div></td></tr></table><hr class=\"line\"/>");

            document.AddLast(code);
            document.AddLast(new HtmlEndLine(2));
        }



    }
}
