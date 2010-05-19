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
    /// <summary>
    /// This class handles the notifications in the system.
    /// </summary>
    public class Notification
    {
        /// <summary>
        /// represents the rectangle window where the notifications will be presented to 
        /// the user
        /// </summary>
        private static Rectangle notifyWindow;

        /// <summary>
        /// We want to store only one notification class in the system. acts like a singelton
        /// </summary>
        private static Notification not;

        /// <summary>
        /// The notification messages queue. the notifications are inserted into
        /// the queue and presented one by one to the user.
        /// Working Algorithm : every incoming message is inserted to the queue no matter what.
        /// when we want to display the message we are using Queue.peek.
        /// Only when the user closes the Notification Window which display the notification message
        /// , the message is removed from the Queue
        /// </summary>
        private static Queue<NotifyMessage> notificationQueue;

        /// <summary>
        /// Constructs the notification class with the rectangle window where the 
        /// notifications will be presented
        /// </summary>
        /// <param name="component"></param>
        public Notification(Rectangle component)
        {
            //if there is a current active Notification class , so we want to use it.
            if (not != null)
            {
                return;
            }
            //There are no occurenes of Notification class , so construct it.
            notificationQueue = new Queue<NotifyMessage>();
            not = this;
            notifyWindow = component;
        }

        /// <summary>
        /// This class represents a Notification Message
        /// </summary>
        private class NotifyMessage
        {
            /// <summary>
            /// The title of the notification
            /// </summary>
            private string title;

            /// <summary>
            /// The text of the notification
            /// </summary>
            private string text;


            public NotifyMessage(String title, String text)
            {
                this.title = title; this.text = text;
            }

            /// <summary>
            /// Sets and gets the title of the notification
            /// </summary>
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

            /// <summary>
            /// Sets and gets the text of the notification
            /// </summary>
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
            //checked out
            //notify.Visible = false;
        }


        /// <summary>
        /// Notification window close event handler , this method is invoked when
        /// the user closes the notification message that was displayed to him.
        /// in this case we should pop-out this message from the queue and display
        /// the next notifications if the queue isn't empty
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void notify_BalloonTipClosed(object sender, EventArgs e)
        {
            //Only one thread at a time
            lock (notificationQueue)
            {
                //pop-out the message that it's window was closed
                notificationQueue.Dequeue();
                if (notificationQueue.Count != 0)
                {
                    //there is a pending message , display it to the user.
                    NotifyMessage nt = notificationQueue.Peek();
                    displayNotify(nt);
                }
            }
        }

        /// <summary>
        /// This method displays to the user in a Notification Window the message obtained
        /// from the queue.
        /// </summary>
        /// <param name="mes"></param>
        private void displayNotify(NotifyMessage mes)
        {
            //construct the notification window
            NotificationWindow notific = new NotificationWindow(mes.Title, mes.Text, notifyWindow);
            //register the window close event handler to the event
            notific.CloseButtonClick += new EventHandler(notify_BalloonTipClosed);
            //display the window
            notific.Show();
        }

        /// <summary>
        /// This method pushes the given message into the notifications queue , if the queue was
        /// empty before , the method display's the message to the user.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="text"></param>
        public void showNotification(String title, String text)
        {
            NotifyMessage message = new NotifyMessage(title, text);
            //only one thread at a time
            lock (notificationQueue)
            {
                //if the queue is empty push into the queue and display the message
                if (notificationQueue.Count == 0)
                {
                    notificationQueue.Enqueue(message);
                    displayNotify(message);
                }
                else
                {
                    //if the queue isn't empty , just push the message into it
                    notificationQueue.Enqueue(message);
                }
            }



        }
    }

}
