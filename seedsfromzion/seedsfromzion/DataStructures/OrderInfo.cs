using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace seedsfromzion.DataStructures
{
    public struct OrderInfo
    {
        public int orderId;
        public System.UInt32[] plantId;
        public double[] units;
        public string[] fromStorageId;
        public DateTime orderDate;
        public DateTime dueDate;
        public char status;
    }
}
