namespace DoubleLinkedList;

//Defining the node in the DLL
public class Node
{
    //Proprieties for the node data which is the color of type string and pointers to the next and previous node
    public string color { get; set; }
    public Node nextNode { get; set; }
    public Node prevNode { get; set; }

    public Node(string color)
    {
        this.color = color;
        this.nextNode = null;
        this.prevNode = null;
    }
}