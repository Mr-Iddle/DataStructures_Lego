using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoAlgorithm
{

        public class Dll<T>
        {
            /*The double linked list, it has a head pointer pointing to the first node and a tail pointer which is pointing
                at the last node. The count field keeps track of how many nodes are in the list.
            */

            //Head node is the first node of the linked list
            public Node<T> headNode;
            //Tail node is the last nofde of the linked list
            public Node<T> tailNode;
            //Keeps track of how many nodes are in the list
            public int countNodes;

            //Return the number of nodes

            //Useless method I didn't need it in other classes, initially I wanted to separate the methods for quicksort etc. .

            public int CountNodes
            {
                get { return this.countNodes; }
            }


            /*
             * The method adds a new node with the color at the end of the linked list
             * If the list is empty, headNode == null part, then the new node becomes both the head and tail node/
             * If the list IS NOT EMPTY (else) the new node is put after the current tail node (appended).
               The prevNode of the new node points to the current tail node and the next node of the current tail points to the current node.
                At the end, the tail node updated to the new node and the countNodes field is increased.
             */
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

            //Get the node index (not used lmao)
            /*
             * This returns the node at a specific index in the dll.
             * It starts from the head node and traverses the entire dll (list) by following the nextNode pointers
                until it reaches the desired index.
                If the index (i) is out of range the exception is thrown
             */
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

            /*
             * OOOO EXPLAIN THIS ONE IT'S SUPER FANCY
             * Time complexity O(N)
             * SLS idea is to add an extra element at the end (tail) of the dll (the sentinel value, colorSls) that matches the target
               we are looking for in this case colorSls. 
                By using this search algorithm the avoidance of conditional checks for the end of the list are avoided and the search finishes early
                as soon as we find the sentinel element. It's a slight performance improvement
               *
               * In the method it creates the sentinel node with the colorSls in the dll and inserts it before the headNode.
                 The method goes (iterates) through the list UNTIL IT FINDS A NODE WITH A MATCHING COLOR NAME OR IT REACHES THE SENTINEL NODE.
                 And well, if the sentinel node is not found it returns -1.

                EqualityComparer was used because it provides reliable comparison between the colors of the nodes in the dll regardless
                of the specific type T used (string etc).
                The ! is used to negate if the result of the check. So if the colors are not equal the result will be false, if they are equal true.
                Equals is part of the EqualityComparer to check if the color of the current node is equal to the color we are searching for.
                The inequality of the EqualityComparer keeps the while loop going until it find the node with the color.
                By using .Default it can handle type T (from MS !EqualityComparer<T>.Default.Equals(currNode.color, colorSLs))
             */
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


            /*
             * This method performs a simple linear search for a specific color (colorLs) in the dll.
             * It iterates through the list, (Equality) comparing each node's color with the target color ls.
             * If there is a match, then it returns the index of the node.
             * If the end of the dll is reached rthen -1 is returned
             */
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


            //Quicksort = pivot

            /*
             * It follows 3 conditions:
                    - Correct position in final, sorted array
                    - Items to the left are smaller (than the pivot)
                    - Items to the right are larger (than the pivot)
            */
            /*
             * This method swaps the color values between two node which are given.
             * It stores the colors of nOne in a temporary T variable and assigns the color of nTwo to nOne, and assigns the temporary
               variable value to nTwo
             */
            private void moveColors(Node<T> nOne, Node<T> nTwo)
            {
                T tempNodeOne = nOne.color;
                nOne.color = nTwo.color;
                nTwo.color = tempNodeOne;

                //swap colors
            }

            /*
             * Pivoting 
             * The recursive method implements the Quicksort to to sort the dll.
             * It uses a partitioning scheme (Lomuto??) to select a pivot(r) and partition the dll into two sublists.
             * WHAT'S RECURSIVE ABOUT THIS METHOD IT'S BECAUSE IT'S BECAUSE IT APPLIES QUICKSORT TO THE LEFT SUBLIST (BEFORE THE PIVOT)
                AND THE RIGHT SUBLIST(AFTER THE PIVOT)
              * When l is null, r is null, l and r are the same node, l is the node before r those are the base cases
             */
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


            /*
             * Paritioning step 
             * As parameters it takes a left node and right node and partitions the sublist between them.
             * A pivot (r) is selected and the sublist is iterated through, MOVING NODES WITH COLORS LESS THAN OR EQUAL TO THE PIVOT'S COLOR
              TO THE LEFT SIDE.
              In the final, it returns the final position of the pivot after positioning
             */
            private Node<T> delimitN(Node<T> l, Node<T> r) //partition nodes
            {
                Node<T> i = l.prevNode;
                for (Node<T> j = l; j != r; j = j.nextNode)
                {
                    if (Comparer<T>.Default.Compare(j.color, r.color) <= 0)
                    {
                        if (i == null)
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

                if (i == null)
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
                //We just let recusivity handle the rest of the ordering 
                //The sorting continues recursively until everything has been sorted
                qSRec(headNode, tailNode);
            }


            //Bubblesort
            /*
             *  How does it work we compare consecutive items, if they are not in their right place we will swap them
             *  The highest number will go(bubble) to the right with each iteration
             *  A sorted partition forms at the end of the list
             *  A pro over quicksort is that bubblesort will stop as soon as it's done even though quicksort is faster than bubblesort.
            */

            /*
             * This method compares the adjacent nodes and swaps them if they ar ein the wrong order until the list is fully sorted.
             * It used the previously move colors method to swap the color values of the nodes
             */
            public void bubbleSort()
            {
                if (headNode == null || headNode.nextNode == null)
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

            //Binary search
            //Put the quicksort inside brainiac to sort it
            public int bSearch(T colorBs)
            {
                if (headNode == null)
                {
                    return -1;
                }

                int l = 0; //left
                int r = this.countNodes - 1; //right

                while (l <= r)
                {
                    int m = l + (r - l) / 2;//middle
                    Node<T> mNode = getNodeIndex(m);

                    int compareStrings = Comparer<T>.Default.Compare(colorBs, mNode.color);

                    if (compareStrings == 0)
                    {
                        return m;
                    }
                    else if (compareStrings < 0)
                    {
                        r = m - 1; //left half
                    }
                    else
                    {
                        l = m + 1; //right half
                    }
                }
                return -1;
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
    }
