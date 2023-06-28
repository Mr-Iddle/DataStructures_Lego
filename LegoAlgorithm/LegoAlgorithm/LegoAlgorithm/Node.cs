using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoAlgorithm
{
    public class Node<T>
    {
        //Proprieties for the node data which is the color of type string and pointers to the next and previous node
        public T color { get; set; }
        public Node<T> nextNode { get; set; }
        public Node<T> prevNode { get; set; }

        public Node(T color)
        {
            this.color = color;
            this.nextNode = null;
            this.prevNode = null;
        }
    }
}
