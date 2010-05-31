using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using seedsfromzion.DataAccess;
using System.Data;
using MySql.Data.MySqlClient;
using seedsfromzion.DataStructures;
using System.IO;

namespace seedsfromzion.GUI.OrdersForms
{
    public static class EmailSender
    {
        public class EmailSendProblem : Exception { }
        public static void Send(int orderid,ClientInfo info)
        {

            MailMessage message = new MailMessage();
            //Set the email properties
            message.From = new MailAddress(ConfigFile.getInstance.EmailUsername);
            message.To.Add(new MailAddress(info.email));
            message.Subject = orderid + " פרטי הזמנה מס";

            message.Body = "פתח את הקובץ המצורף בכדי לראות את פרטי ההזמנה";

            message.BodyEncoding = Encoding.GetEncoding("UTF-8");

            string fileName=generateOrderEmail(orderid,info);
            message.Attachments.Add(new Attachment(fileName));
            System.Net.Mail.SmtpClient Smtp = new SmtpClient();
            //set the gmail smtp server
            Smtp.Host = "smtp.gmail.com"; 
            Smtp.Port = 587;
            //gmail is using SSL, so enable it.
            Smtp.EnableSsl = true;
            //set the login details
            Smtp.UseDefaultCredentials = false;
            Smtp.Credentials = new System.Net.NetworkCredential(ConfigFile.getInstance.EmailUsername, ConfigFile.getInstance.EmailPassword);
            try
            {
                Smtp.Send(message);
            }
            catch (Exception e)
            {
                throw new EmailSendProblem();
            }
            finally
            {
                message.Attachments.Dispose();
                File.Delete(fileName);
            }

        }

        private static string generateOrderEmail(int orderId,ClientInfo info)
        {
            MySqlCommand command = DataAccessUtils.commandBuilder("SELECT  P.name, P.type ,SUM(O.units) AS units  FROM seedsdb.ordersfromstorage O ,seedsdb.planttypes P WHERE O.plantId=P.plantId AND orderId=@Order GROUP BY P.name,P.type", "@Order", orderId.ToString());
            DataTable table = DatabaseAccess.getResultSetFromDb(command);
            table.Columns[0].ColumnName = "שם הצמח";
            table.Columns[1].ColumnName = "סוג הצמח";
            table.Columns[2].ColumnName = "כמות";
            Report r = new Report();
            HtmlHeading heading =new HtmlHeading(orderId.ToString() + " פרטים עבור הזמנה מס ");
            heading.align(HtmlAlign.center);
            r.append(heading).append(new HtmlEndLine(2));
            r.append(new HtmlParagraph(info.name + " :שם הלקוח")).append(new HtmlParagraph(info.phoneNumber + " :מספר טלפון"));
            r.append(new HtmlEndLine(3));
            HtmlTable htmlTable = new HtmlTable(table);
            htmlTable.align(HtmlAlign.center);
            r.append(htmlTable);
            r.append(new HtmlEndLine(2));
            r.append(new HtmlParagraph("!תודה רבה"));
            string executionPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string filename = executionPath+ @"\" + orderId.ToString() + ".html";
            r.save(filename);
            return filename;



        }
    }
}
