using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.IO;

namespace seedsfromzion.DataAccess
{
    class Report
    {
        public enum ReportStyle {BlackWhite, Color};
        private LinkedList<HtmlElem> document;
        private ReportStyle docStyle;
        
        public Report()
        {
            document = new LinkedList<HtmlElem>();
            this.ReportColor = ReportStyle.Color;
            addSignature();
        }

        public Report append(HtmlElem elem)
        {
            document.AddLast(elem);
            return this;
        }

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

        public void save(string targetDir)
        {
            if (File.Exists(targetDir))
            {
                File.Delete(targetDir);
            }
            addHeader();
            TextWriter tw =null;
            try
            {
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
        private void addSignature()
        {
            string time=DateTime.Now.ToLocalTime().ToString();
            HtmlCode code = new HtmlCode("<table class=\"sign\"><tr><td class=\"tdSign\"><h1 class=\"signature\"><div align=left>" + time + "</div></h1></td><td class=\"tdSign\"><div align=right><h1 class=\"signature\">המסמך נוצר על ידי מערכת לניהול עסקי זרעים מציון</h1></div></td></tr></table><hr class=\"line\"/>");

            document.AddLast(code);
            document.AddLast(new HtmlEndLine(2));
        }



    }
}
