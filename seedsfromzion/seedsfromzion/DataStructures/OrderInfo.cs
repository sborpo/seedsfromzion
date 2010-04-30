using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace seedsfromzion.DataStructures
{
    public struct OrderInfo
    {
        public string orderId;
        public string[] plantId;
        public double[] units;
        public string[] fromStorageId;
        public DateTime orderDate;
        public DateTime dueDate;
        public char status;
    }
}
