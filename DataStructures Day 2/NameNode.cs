using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_Day_2
{
    internal class NameNode
    {
        public char data;
        public NameNode next;

        public NameNode(char data, NameNode next)
        {
            this.data = data;
            this.next = next;
        }

        public NameNode(char data) { this.data = data; }
    }
}
