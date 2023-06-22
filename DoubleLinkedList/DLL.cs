using System.Collections.Concurrent;
using System.Drawing;

namespace DoubleLinkedList;

/*
 * Double Linked List
 * From a single linked list it is different BECAUSE EACH NODE HAS AN EXTRA POINTER THAT POINTS AT THE PREVIOUS NODE
 *
 * Visualization
 *
 * |NULL| data | next | <----> prev | data | next <----> |prev | data | NULL |
     ^
     |
    |HEAD|
 */


public class DLL<T>
{
    /*The double linked list, it has a head pointer pointing to the first node and a tail pointer which is pointing
        at the last node. The count field keeps track of how many nodes are in the list.
    */

    public Node<T> headNode;
    public Node<T> tailNode;
    public int countNodes;

    public int CountNodes
    {
        get { return this.countNodes; }
    }

    public void AddLastNode(T color)
    {
        Node<T> newNode = new Node<T>(color);

        if (this.headNode == null)
        {
            headNode = newNode;
            tailNode = newNode;
        }
        else
        {
            newNode.prevNode = this.tailNode; //from the Node class prevNode
            this.tailNode.nextNode = newNode;
            this.tailNode = newNode;
        }

        this.countNodes++;
    }

    //Get the node index
    private Node<T> getNodeIndex(int i)
    {
        if (i < 0 || i >= this.countNodes)
        {
            throw new IndexOutOfRangeException();
        }

        Node<T> currNode = this.headNode;
        int currI = 0;

        while (currI < i)
        {
            currNode = currNode.nextNode; //nextNode from the Node Class
            currI++;
        }

        return currNode;
    }

    public int sentinelLinearSearch(T colorSLs)
    {
        if (headNode == null)
        {
            return -1;
        }

        //Sentinel node as next node
        Node<T> sentiNode = new Node<T>(colorSLs);
        sentiNode.nextNode = headNode;

        Node<T> currNode = headNode;
        int i = 0;

        //We iterate through the csv until the value is found
        while (!EqualityComparer<T>.Default.Equals(currNode.color, colorSLs))
        {
            currNode = currNode.nextNode;
            i++;
        }

        //If the current node is the sentinel then we didn't found the color name we looking for
        if (currNode == sentiNode)
        {
            return -1;
        }

        return i;
    }

    public int linearSearch(T colorLs)
    {
        if (headNode == null)
        {
            return -1;
        }

        Node<T> currNode = headNode;
        int i = 0;

        while (currNode != null)
        {
            if (EqualityComparer<T>.Default.Equals(colorLs, currNode.color)) ///ignore capital or small letters, treat it as the same
            {
                return i;
            }

            currNode = currNode.nextNode;
            i++;
        }
        return -1;
    }


    //Quicksort
    private void moveColors(Node<T> nOne, Node<T> nTwo)
    {
        T tempNodeOne = nOne.color;
        nOne.color = nTwo.color;
        nTwo.color = tempNodeOne;

        //swap colors
    }

    private void qSRec(Node<T> l, Node<T> r)
    {
        if (l == null || r == null || l == r || l == r.nextNode)
        {
            return;
        }

        Node<T> p = delimitN(l, r); //pivot
        qSRec(l, p.prevNode);
        qSRec(p.nextNode, r);

    }

    private Node<T> delimitN(Node<T> l, Node<T> r) //partition nodes
    {
        Node<T> i = l.prevNode;
        for(Node<T> j=l; j != r; j = j.nextNode)
        {
            if(Comparer<T>.Default.Compare(j.color,r.color) <= 0)
            {
                if(i==null)
                {
                    i = l;
                }
                else
                {
                    i = i.nextNode;
                }

                moveColors(i, j);
            }
        }

        if(i == null)
        {
            i = l;
        }
        else
        {
            i = i.nextNode;
        }

        moveColors(i, r);
        return i;
    }

    public void quickSort()
    {
        qSRec(headNode, tailNode);
    }


    //Bubblesort
    public void bubbleSort()
    {
        if(headNode == null || headNode.nextNode == null)
        {
            return;
        }

        bool isSwap;
        Node<T> currN;
        Node<T> lSortN = null;

        do
        {
            isSwap = false;
            currN = headNode;

            while (currN.nextNode != lSortN)
            {
                if (Comparer<T>.Default.Compare(currN.color, currN.nextNode.color) > 0)
                {
                    moveColors(currN, currN.nextNode);
                    isSwap = true;
                }
                currN = currN.nextNode;
            }
            lSortN = currN;
        }
        while (isSwap);

    }

    public void trFwd() //Traversing Forward
    {
        Node<T> currNode = this.headNode;

        while (currNode != null)
        {
            Console.WriteLine(currNode.color);
            currNode = currNode.nextNode;
        }
    }

    public void trBwd() //Traversing Backwards
    {
        Node<T> currNode = this.tailNode;

        while (currNode != null)
        {
            Console.WriteLine(currNode.color);
            currNode = currNode.prevNode;
        }
    } 
}