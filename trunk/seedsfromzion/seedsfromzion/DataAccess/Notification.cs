using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections;
using System.Drawing;


namespace seedsfromzion.DataAccess
{

    class Notification
    {

        private static Rectangle notifyWindow;
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


        public void close()
        {
            //notify.Visible = false;
        }
        public Notification(Rectangle component)
        {
            if (not != null)
            {
                return;
            }
            notificationQueue = new Queue<NotifyMessage>();
            not = this;
            notifyWindow = component;




        }


        void notify_BalloonTipClosed(object sender, EventArgs e)
        {
            //notify.Visible = false;
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


        private void displayNotify(NotifyMessage mes)
        {
            NotificationWindow notific = new NotificationWindow(mes.Title, mes.Text, notifyWindow);
            notific.CloseButtonClick += new EventHandler(notify_BalloonTipClosed);
            notific.Show();
        }


        public void showNotification(String title, String text)
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
