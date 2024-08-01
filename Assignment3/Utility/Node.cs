using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.Utility
{
    public class Node
    {
        public User data{ get; set; }
        public Node next { get; set; }
        public Node() { }
        public Node(User data)
        {
            this.data= data;
            this.next = null;
        }
    }
}
