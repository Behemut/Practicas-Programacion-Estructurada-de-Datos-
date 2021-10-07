using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Node
    {
        public int Element;
        public Node Link;

        public Node()
        {
            Element = 0;
            Link = null;
        }

        public Node(int theElement)
        {
            Element = theElement;
            Link = null;
        }


 
    }
}
