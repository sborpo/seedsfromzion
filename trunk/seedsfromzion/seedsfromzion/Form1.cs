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
            DatabaseAccess db = new DatabaseAccess();
            Report r = new Report();
            HtmlElem head = new HtmlHeading("שעות העבודה של עובד מספר 5");
            HtmlElem linebreak = new HtmlEndLine(4);
            HtmlElem table = new HtmlTable(db.getResultSetFromDb(new MySqlCommand("SELECT* FROM seedsdb.workdays WHERE workerId=5")).Tables[0]);
            HtmlElem ending = new HtmlParagraph("משהו לסוף");
            table.align(HtmlAlign.center);
            r.append(head).append(linebreak).append(table).append(linebreak).append(ending);
            r.ReportColor = Report.ReportStyle.Color;
            r.save(@"c:\example.html");
           
            InitializeComponent();
            
        }
    }
}
