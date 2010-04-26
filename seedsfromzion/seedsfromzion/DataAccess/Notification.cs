using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections;


namespace seedsfromzion.DataAccess
{

    class Notification
    {
       private static NotifyIcon notify;
       private static Notification not;
       private static Queue<NotifyMessage> notificationQueue;


       private class NotifyMessage
       {
           private string title;
           private string text;
           public NotifyMessage(String title, String text)
           {
               this.title = title; this.text = text;
           }
           public string Title
           {
               get
               {
                   return title;
               }
               set
               {
                   title = value;
               }
           }
           public string Text
           {
               get
               {
                   return text;
               }
               set
               {
                   text = value;
               }
           }
       }



       public Notification(IContainer component)
       {
           if (not !=null)
           {
               return;
           }
           notify = new NotifyIcon(component);
           notificationQueue = new Queue<NotifyMessage>();
           notify.Visible = true;
           notify.BalloonTipIcon = ToolTipIcon.Warning;
           notify.BalloonTipClosed += new EventHandler(notify_BalloonTipClosed);
           notify.BalloonTipClicked +=new EventHandler(notify_BalloonTipClosed);
           not = this;

       }


       void notify_BalloonTipClosed(object sender, EventArgs e)
       {
           notify.Visible = false;
           lock (notificationQueue)
           {
               notificationQueue.Dequeue();
               if (notificationQueue.Count != 0)
               {

                   NotifyMessage nt = notificationQueue.Peek();
                   displayNotify(nt);
               }
           }
       }
       public void setIcon(System.Drawing.Icon icn)
       {
           notify.Icon = icn;
       }

       private void displayNotify(NotifyMessage mes)
       {
           notify.Visible = true;
           notify.BalloonTipTitle = mes.Title;
           notify.BalloonTipText = mes.Text;
           notify.ShowBalloonTip(50000);

       }
       public void showNotification(String title,String text)
       {
           NotifyMessage message = new NotifyMessage(title, text);
           lock (notificationQueue)
           {
               if (notificationQueue.Count == 0)
               {
                   notificationQueue.Enqueue(message);
                   displayNotify(message);
               }
               else
               {
                   notificationQueue.Enqueue(message);
               }
           }
            
        
           
       }
    }

}
