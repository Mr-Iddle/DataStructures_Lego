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
        public T Color { get; set; }
        public Node<T> NextNode { get; set; }
        public Node<T> PrevNode { get; set; }

        public Node(T color)
        {
            this.Color = color;
            this.NextNode = null;
            this.PrevNode = null;
        }
    }
}
