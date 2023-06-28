using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoAlgorithm
{
    public class CorvinLinkedList<T> : IEnumerable<T>
    {
        //creation of the internal node class
        public class Node<T>
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
        }

        private Node<T> _head;
        private Node<T> _tail;

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
                newNode.Next = _head;
                _head.Previous = newNode;
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
                newNode.Previous = _tail;
                _tail.Next = newNode;
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
                    current = current.Next;
                }

                newNode.Previous = current.Previous;
                newNode.Next = current;
                current.Previous.Next = newNode;
                current.Previous = newNode;

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
                if (EqualityComparer<T>.Default.Equals(current.Value, value))
                {
                    //if node before is not null, set the next node to the current node
                    if (current.Previous != null)
                    {
                        current.Previous.Next = current.Next;
                    }
                    else
                    {
                        _head = current.Next;
                    }

                    //if node after is not null, set the previous node to the current node
                    if (current.Next != null)
                    {
                        current.Next.Previous = current.Previous;
                    }
                    else
                    {
                        _tail = current.Previous;
                    }

                    Count--;
                    return true;
                }
                //set the current node to the next node
                current = current.Next;
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
                current = current.Next;
            }

            //if the current node is the head, set the head to the next node
            if (current.Previous != null)
            {
                current.Previous.Next = current.Next;
            }
            else
            {
                _head = current.Next;
            }

            //if the current node is the tail, set the tail to the previous node
            if (current.Next != null)
            {
                current.Next.Previous = current.Previous;
            }
            else
            {
                _tail = current.Previous;
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
            return _head.Value;
        }

        //get the tail of the list
        public T GetLast()
        {
            //when not found, throw exception
            if (_tail.Equals(null))
            {
                throw new InvalidOperationException("Personal LinkedList contains nothing!");
            }
            return _tail.Value;
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
                currentNode = currentNode.Next;
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
                if (EqualityComparer<T>.Default.Equals(current.Value, value))
                {
                    return index;
                }
                index++;
                current = current.Next;
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
                currentNode = currentNode.Next;
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
            var temp = target.Value;
            target.Value = exchanger.Value;
            exchanger.Value = temp;
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
                if (Comparer<T>.Default.Compare(currentNode.Value, pivotValue.Value) < 0)
                {
                    position++;
                    Change(GetNodeAt(position), currentNode);
                }

                currentNode = currentNode.Next;
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
                    if (Comparer<T>.Default.Compare(current.Value, current.Next.Value) > 0)
                    {
                        Change(current, current.Next);
                        swapped = true;
                    }
                    current = current.Next;
                }

                endNode = endNode.Previous;
            } while (swapped);

            clock.Stop();
            return clock.Elapsed;
        }

        public (bool, TimeSpan) LinearSearch(T value, int startIndex, int endIndex)
        {
            //start Stopwatch
            var sw = Stopwatch.StartNew();
            //get the first node from the List
            var currentNode = GetNodeAt(startIndex);

            //check if the start index is valid, else return error message
            if (startIndex < 0 || endIndex >= Count || startIndex > endIndex)
            {
                throw new ArgumentOutOfRangeException("Invalid index, check start || end index");
            }

            //Start loop to find the value
            for (var i = startIndex; i <= endIndex; i++)
            {
                //When the value is found, stopp the Stopwatch and return the time
                if (EqualityComparer<T>.Default.Equals(currentNode.Value, value))
                {
                    sw.Stop();
                    return (true, sw.Elapsed);
                }
                //else, go to the next node
                currentNode = currentNode.Next;
            }

            //return time to display
            return (false, sw.Elapsed);
        }

        public (bool, TimeSpan) BinarySearch(T value, int startIndex, int endIndex)
        {
            //start Stopwatch
            var sw = Stopwatch.StartNew();
            //get the middle index from the List
            var middleIndex = startIndex + (endIndex - startIndex) / 2;
            //Access the middle node
            var middleNode = GetNodeAt(middleIndex);
            //State the comparison result
            var comparisonResult = Comparer<T>.Default.Compare(middleNode.Value, value);

            //Start loop to find the value
            while (startIndex <= endIndex)
            {
                //When the value is found, stopp the Stopwatch and return the time
                if (comparisonResult == 0)
                {
                    sw.Stop();
                    return (true, sw.Elapsed);
                }

                //If not found, change the start or end index
                if (comparisonResult < 0)
                {
                    startIndex = middleIndex + 1;
                }
                else
                {
                    endIndex = middleIndex - 1;
                }
            }
            //return time to display
            sw.Stop();
            return (false, sw.Elapsed);
        }


        //create a method to display the list as a string => Checking if the whole sh*t works
        public override string ToString()
        {
            var currentNode = _head;
            var result = new StringBuilder();
            while (currentNode != null)
            {
                result.Append(currentNode.Value);
                result.Append(" ");
                currentNode = currentNode.Next;
            }
            return result.ToString();
        }

        public IEnumerator<T> GetEnumerator()
        {
            var current = _head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }


}

