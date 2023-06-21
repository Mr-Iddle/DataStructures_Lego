namespace DoubleLinkedList;

/*
 * Double Linked List
 * From a single linked list it is different BECAUSE EACH NODE HAS AN EXTRA POINTER THAT POINTS AT THE PREVIOUS NODE
 *
 * Visualization
 *
 * |NULL| data | next | <----> prev | data | next <----> |prev | data | NULL
     ^
     |
    |HEAD|
 */


public class DLL
{
    /*The double linked list, it has a head pointer pointing to the first node and a tail pointer which is pointing
        at the last node. The count field keeps track of how many nodes are in the list.
    */
    
    public Node headNode;
    public Node tailNode;
    public int countNodes;

    public int CountNodes
    {
        get { return this.countNodes; }
    }

    public void AddLastNode(string color)
    {
        Node newNode = new Node(color);

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
    private Node getNodeIndex(int i)
    {
        if (i < 0 || i >= this.countNodes)
        {
            throw new IndexOutOfRangeException();
        }

        Node currNode = this.headNode;
        int currI = 0;

        while (currI < i)
        {
            currNode = currNode.nextNode; //nextNode from the Node Class
            currI++;
        }

        return currNode;
    }

    public int binarySearch(string colorBs)
    {
        if (this.headNode == null)
        {
            return -1;
        }

        int st = 0; //start
        int end = this.countNodes - 1;

        while (st <= end)
        {
            int m = (st + end) / 2; //middle
            Node mNode= getNodeIndex(m); //middle node

            int compareString =
                string.Compare(colorBs, mNode.color,
                    StringComparison.OrdinalIgnoreCase); //.color is from the Node class
            //Explanation on why StringComparison.OrdinalIgnoreCase is used, so the binary search won't be influenced by
            //case sensitive strings

            if (compareString == 0)
            {
                return m;
            }else if (compareString < 0)
            {
                end = m - 1;
            }
            else
            {
                st = m + 1;
            }
        }

        return -1;
    }

    public void trFwd() //Traversing Forward
    {
        Node currNode = this.headNode;

        while (currNode != null)
        {
            Console.WriteLine(currNode.color);
            currNode = currNode.prevNode;
        }
    }

    public void trBwd() //Traversing Backwards
    {
        Node currNode = this.tailNode;

        while (currNode != null)
        {
            Console.WriteLine(currNode.color);
            currNode = currNode.prevNode;
        }
    } 
}