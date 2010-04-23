using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.IO;

namespace seedsfromzion.DataAccess
{
    class Report
    {
        private LinkedList<HtmlElem> document;
        
        public Report()
        {
            document = new LinkedList<HtmlElem>();
            useHebrewEncoding();
            addSignature();
        }

        public Report append(HtmlElem elem)
        {
            document.AddLast(elem);
            return this;
        }

        public void save(string targetDir)
        {
            if (File.Exists(targetDir))
            {
                File.Delete(targetDir);
            }
          
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
        private void useHebrewEncoding()
        {
            HtmlCode code= new HtmlCode("<head>"+
                                        "<meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\">"+
                                        "<style type=\"text/css\">"+
                                        ".sign {width:100%;color:black}"+
                                         "body{background-color:#f4ffd8;}"+
                                         ".signature { color:green ; font-size:12px; font-family:\"Times New Roman\", Times, serif;}"+
                                         "p { color:black;}"+
                                          ".line {color: #f00; height: 1px;}"+
                                         " .maintable {color:black; border: 1px solid black; border-collapse:collapse;}"+
                                          " td {padding:15px; border: 1px solid green;}"+
                                           " th {background-color:green; color:white; border: 1px solid green;}"+
                                           " .tdsign{ border: 1px solid #f4ffd8;}"+
                                        "</style>"+
                                        "</head>");
            document.AddLast(code);

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
