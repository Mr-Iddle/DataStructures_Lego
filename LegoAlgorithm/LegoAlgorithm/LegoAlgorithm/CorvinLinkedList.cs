using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoAlgorithm
{
    public class CorvinLinkedList<T> : IEnumerable<T>
    {
        //creation of the internal node class
        /*public class Node<T>
        {
            public Node(T value)
            {
                Value = value;
                Next = null;
                Previous = null;
            }

            public T Value { get; set; }
            public Node<T> Next { get; set; }
            public Node<T> Previous { get; set; }
        }*/

        public Node<T> _head;
        public Node<T> _tail;

        //setting the head and tail to null and the count to 0
        public CorvinLinkedList()
        {
            _head = null;
            _tail = null;
            Count = 0;
        }
        public int Count { get; private set; }

        //add value to the beginning of the list
        public void AddFirst(T value)
        {
            var newNode = new Node<T>(value);
            //when empty, head and tail are the same
            if (_head == null)
            {
                _head = newNode;
                _tail = newNode;
            }
            else
            {
                newNode.NextNode = _head;
                _head.PrevNode = newNode;
                _head = newNode;
            }

            Count++;
        }

        //add value to the end of the list
        public void AddLast(T value)
        {
            var newNode = new Node<T>(value);

            //head and tail are the same when empty
            if (_tail == null)
            {
                _head = newNode;
                _tail = newNode;
            }
            else
            {
                newNode.PrevNode = _tail;
                _tail.NextNode = newNode;
                _tail = newNode;
            }

            Count++;
        }

        //inset value at specific position
        public void InsertAt(T value, int index)
        {
            if (index < 0 || index > Count)
            {
                throw new ArgumentOutOfRangeException("Index out of range");
            }

            //if the index is 0, add to the beginning
            if (index == 0)
            {
                AddFirst(value);
            }
            //else if the index is the count, add to the end
            else if (index.Equals(Count))
            {
                AddLast(value);
            }
            //else loop through the list to find the index
            else
            {
                var newNode = new Node<T>(value);
                var current = _head;
                for (var i = 0; i < index; i++)
                {
                    current = current.NextNode;
                }

                newNode.PrevNode = current.PrevNode;
                newNode.NextNode = current;
                current.PrevNode.NextNode = newNode;
                current.PrevNode = newNode;

                Count++;
            }
        }

        //remove value
        public bool Remove(T value)
        {
            var current = _head;
            //while head is not null, loop through the list
            while (current != null)
            {
                //if the value is found, remove it
                if (EqualityComparer<T>.Default.Equals(current.Color, value))
                {
                    //if node before is not null, set the next node to the current node
                    if (current.PrevNode != null)
                    {
                        current.PrevNode.NextNode = current.NextNode;
                    }
                    else
                    {
                        _head = current.NextNode;
                    }

                    //if node after is not null, set the previous node to the current node
                    if (current.NextNode != null)
                    {
                        current.NextNode.PrevNode = current.PrevNode;
                    }
                    else
                    {
                        _tail = current.PrevNode;
                    }

                    Count--;
                    return true;
                }
                //set the current node to the next node
                current = current.NextNode;
            }

            return false;
        }

        //remove at specific position
        public void RemoveAt(int index)
        {
            //setting the head
            var current = _head;

            if (index < 0 || index >= Count)
            {
                throw new ArgumentOutOfRangeException("Index out of Bounds");
            }

            //loop through the list to find the index
            for (var i = 0; i < index; i++)
            {
                current = current.NextNode;
            }

            //if the current node is the head, set the head to the next node
            if (current.PrevNode != null)
            {
                current.PrevNode.NextNode = current.NextNode;
            }
            else
            {
                _head = current.NextNode;
            }

            //if the current node is the tail, set the tail to the previous node
            if (current.NextNode != null)
            {
                current.NextNode.PrevNode = current.PrevNode;
            }
            else
            {
                _tail = current.PrevNode;
            }
            Count--;
        }

        //gets the head of the list
        public T GetFirst()
        {
            if (_head.Equals(null))
            {
                throw new InvalidOperationException("Personal LinkedList contains nothing!");
            }
            return _head.Color;
        }

        //get the tail of the list
        public T GetLast()
        {
            //when not found, throw exception
            if (_tail.Equals(null))
            {
                throw new InvalidOperationException("Personal LinkedList contains nothing!");
            }
            return _tail.Color;
        }

        //Get the node at a specific index
        public Node<T> GetNodeAt(int index)

        {
            var currentNode = _head;
            var currentIndex = 0;

            //loop for getting the node at the index
            while (currentNode != null)
            {
                //when found, show node
                if (currentIndex.Equals(index))
                {
                    return currentNode;
                }
                //increase   
                currentNode = currentNode.NextNode;
                currentIndex++;
            }

            //else not found at all
            throw new ArgumentOutOfRangeException("index", "Index is out of the range of the list.");
        }

        //clear the entries in the list
        public void Clear()
        {
            _head = null;
            _tail = null;
            Count = 0;
        }

        //looks at the list and gets the index of the value
        public int IndexOf(T value)
        {
            var index = 0;
            var current = _head;

            //while the current node is not null
            while (current != null)
            {
                //check if the value is equal to the current node
                if (EqualityComparer<T>.Default.Equals(current.Color, value))
                {
                    return index;
                }
                index++;
                current = current.NextNode;
            }

            return -1;
        }

        //Get the index of a node
        private Node<T> GetIndexOfNode(int target)
        {
            var currentNode = _head;
            var currentIndex = 0;

            while (currentNode != null)
            {
                if (currentIndex == target)
                {
                    return currentNode;
                }
                currentNode = currentNode.NextNode;
                currentIndex++;
            }

            return null;
        }

        //Check if value is present in the list
        public bool does_Contain(T value)
        {
            return IndexOf(value) != -1;
        }

        //Swapping function
        private void Change(Node<T> target, Node<T> exchanger)
        {
            var temp = target.Color;
            target.Color = exchanger.Color;
            exchanger.Color = temp;
        }

        private int Partition(int startIndex, int endIndex)
        {
            var pivotValue = GetNodeAt(endIndex);
            var position = startIndex++;
            var currentNode = GetNodeAt(startIndex);

            //loop through the list
            for (var j = startIndex; j <= endIndex - 1; j++)
            {
                //if the current node is less than the pivot value, increment the position and swap the nodes
                if (Comparer<T>.Default.Compare(currentNode.Color, pivotValue.Color) < 0)
                {
                    position++;
                    Change(GetNodeAt(position), currentNode);
                }

                currentNode = currentNode.NextNode;
            }

            //Swapping the nodes
            Change(GetNodeAt(position + 1), GetNodeAt(endIndex));

            //return the position
            return position + 1;
        }


        public TimeSpan QuickSort(int startindex, int endIndex)
        {
            //Create new stopwatch
            var clock = Stopwatch.StartNew();

            //if the indexes are invalid, throw an exception
            if (startindex < 0 || endIndex >= Count || startindex > endIndex)
            {
                throw new ArgumentOutOfRangeException("Invalid start || end index.");
            }


            //call the method
            QuickSortInternal(startindex, endIndex);
            //end the clock
            clock.Stop();
            return clock.Elapsed;
        }

        //This is the recursive method for the quick sort
        private void QuickSortInternal(int startIndex, int endIndex)
        {
            {
                if (startIndex < endIndex)
                {
                    //Set the pivot index to the partition method
                    var pivotIndex = Partition(startIndex, endIndex);
                    //Get the pivot index and subtract 1
                    QuickSortInternal(startIndex, pivotIndex - 1);
                    //Get the pivot index and add 1
                    QuickSortInternal(pivotIndex + 1, endIndex);
                }
            }
        }

        public TimeSpan BubbleSort(int startIndex, int endIndex)
        {
            //Start the clock
            var clock = Stopwatch.StartNew();

            bool swapped;
            var startNode = GetNodeAt(startIndex);
            var endNode = GetNodeAt(endIndex);

            if (startNode == null || endNode == null || Comparer<Node<T>>.Default.Compare(startNode, endNode) > 0)
            {
                throw new ArgumentOutOfRangeException("The start or end index is incorrect");
            }

            do
            {
                swapped = false;
                var current = startNode;

                while (current != endNode)
                {
                    if (Comparer<T>.Default.Compare(current.Color, current.NextNode.Color) > 0)
                    {
                        Change(current, current.NextNode);
                        swapped = true;
                    }
                    current = current.NextNode;
                }

                endNode = endNode.PrevNode;
            } while (swapped);

            clock.Stop();
            return clock.Elapsed;
        }

        public int LinearSearch(T value)
        {
            //start Stopwatch
            var sw = Stopwatch.StartNew();
            //get the first node from the List
            var currentNode = _head;
            int i = 0;

            //check if the start index is valid, else return error message
            if (_head == null)
            {
                return -1;
            }

            while (currentNode != null)
            {
                if (EqualityComparer<T>.Default.Equals(value, currentNode.Color)) ///ignore capital or small letters, treat it as the same
                {
                    return i;
                }
                
                currentNode = currentNode.NextNode;
                i++;
            }
            return -1;
        }

        public int BinarySearch(T value)
        {
            if (_head == null)
            {
                return -1;
            }

            int l = 0; //left
            int r = this.Count - 1; //right

            while (l <= r)
            {
                int m = l + (r - l) / 2;//middle
                Node<T> mNode = GetNodeAt(m);

                int compareStrings = Comparer<T>.Default.Compare(value, mNode.Color);

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


        //create a method to display the list as a string => Checking if the whole sh*t works
        public override string ToString()
        {
            var currentNode = _head;
            var result = new StringBuilder();
            while (currentNode != null)
            {
                result.Append(currentNode.Color);
                result.Append(" ");
                currentNode = currentNode.NextNode;
            }
            return result.ToString();
        }

        public IEnumerator<T> GetEnumerator()
        {
            var current = _head;
            while (current != null)
            {
                yield return current.Color;
                current = current.NextNode;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }


}

