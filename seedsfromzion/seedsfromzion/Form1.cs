using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using seedsfromzion.Backup;
using MySql.Data;
using MySql.Data.MySqlClient;
using seedsfromzion.DataAccess;


namespace seedsfromzion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //check 2
            ConfigFile config = ConfigFile.getInstance;
            string str=config.ConnectionString;
            str = config.MySqlPath;
            IDatabaseAccess db = new DatabaseAccess();
            DateTime date= new DateTime(2040,3,8);
            db.optimizeDb(date);
            Report r = new Report();
            HtmlElem head = new HtmlParagraph("אבא הלך לכדורגל");
            HtmlElem head3 = new HtmlEndLine(4);
            HtmlElem head2 = new HtmlParagraph("סתום סתום את הפה שלך");
            r.append(head).append(head3).append(head2);
            r.save(@"c:\das.html");
            
           
            InitializeComponent();
            
        }
    }
}
