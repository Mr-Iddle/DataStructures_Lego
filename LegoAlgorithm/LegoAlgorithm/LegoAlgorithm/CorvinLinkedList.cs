/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoAlgorithm
{
    public class Node
    {
        public LegoData Lego { get; set; }
        public Node Next { get; set; }

        public Node(LegoData data)
        {
            Lego = data;
            Next = null;
        }
    }
    public class MyLinkedList
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }
        public int Count { get; set; }

        public MyLinkedList()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        public void AddFirst(LegoData data)
        {
            Node newNode = new Node(data);
            if (Head == null)
            {
                Head = newNode;
                Tail = newNode;
            }
            else
            {
                newNode.Next = Head;
                Head = newNode;
            }
            Count++;
        }

        public void AddLast(LegoData data)
        {
            Node newNode = new Node(data);
            if (Head == null)
            {
                Head = newNode;
                Tail = newNode;
            }
            else
            {
                Tail.Next = newNode;
                Tail = newNode;
            }
            Count++;
        }

        public void RemoveFirst()
        {
            if (Head == null)
            {
                return;
            }
            else if (Head == Tail)
            {
                Head = null;
                Tail = null;
            }
            else
            {
                Head = Head.Next;
            }
            Count--;
        }

        public void RemoveLast()
        {
            if (Head == null)
            {
                return;
            }
            else if (Head == Tail)
            {
                Head = null;
                Tail = null;
            }
            else
            {
                Node current = Head;
                while (current.Next != Tail)
                {
                    current = current.Next;
                }
                current.Next = null;
                Tail = current;
            }
            Count--;
        }

        public void Remove(LegoData data)
        {
            if (Head == null)
            {
                return;
            }
            else if (Head == Tail)
            {
                if (Head.Lego.Equals(data))
                {
                    Head = null;
                    Tail = null;
                    Count--;
                }
            }
            else
            {
                if (Head.Lego.Equals(data))
                {
                    Head = Head.Next;
                    Count--;
                }
                else
                {
                    Node current = Head;
                    while (current.Next != null)
                    {
                        if (current.Next.Lego.Equals(data))
                        {
                            current.Next = current.Next.Next;
                            Count--;
                            break;
                        }
                        current = current.Next;
                    }
                }
            }
        }

        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        //create QuickSort method
        public void QuickSortMethodCustom<T>(T[] array, int left, int right) where T : IComparable
        {
            int i = left;
            int j = right;
            T pivot = array[(left + right) / 2];
            while (i <= j)
            {
                while (array[i].CompareTo(pivot) < 0)
                {
                    i++;
                }
                while (array[j].CompareTo(pivot) > 0)
                {
                    j--;
                }
                if (i <= j)
                {
                    T tmp = array[i];
                    array[i] = array[j];
                    array[j] = tmp;
                    i++;
                    j--;
                }
            }
            if (left < j)
            {
                QuickSortMethodCustom(array, left, j);
            }
            if (i < right)
            {
                QuickSortMethodCustom(array, i, right);
            }
        }

        //bubble sort method
        public void BubbleSortMethodCustom<T>(T[] array) where T : IComparable
        {
            int n = array.Length;
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 1; i < n; i++)
                {
                    if (array[i - 1].CompareTo(array[i]) > 0)
                    {
                        T temp = array[i - 1];
                        array[i - 1] = array[i];
                        array[i] = temp;
                        swapped = true;
                    }
                }
            } while (swapped == true);
        }

        //linear search method
        public int LinearSearchMethodCustom<T>(T[] array, T value) where T : IComparable
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(value))
                {
                    return i;
                }
            }
            return -1;
        }

        //create binary search method
        public int BinarySearchMethodCustom<T>(T[] array, T value) where T : IComparable
        {
            int min = 0;
            int max = array.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (array[mid].Equals(value))
                {
                    return mid;
                }
                else if (array[mid].CompareTo(value) < 0)
                {
                    min = mid + 1;
                }
                else
                {
                    max = mid - 1;
                }
            }
            return -1;
        }

       

    }
}

*/