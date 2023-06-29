using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoAlgorithm
{

    public class Dll<T>
    {
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
                newNode.PrevNode = this.tailNode;
                this.tailNode.NextNode = newNode;
                this.tailNode = newNode;
            }

            this.countNodes++;
        }

        private Node<T> GetNodeIndex(int i)
        {
            if (i < 0 || i >= this.countNodes)
            {
                throw new IndexOutOfRangeException();
            }

            Node<T> currNode = this.headNode;
            int currI = 0;

            while (currI < i)
            {
                currNode = currNode.NextNode;
                currI++;
            }

            return currNode;
        }

        public int LinearSearch(T colorLs)
        {
            var stopWatch = Stopwatch.StartNew();
            if (headNode == null)
            {
                return -1;
            }

            Node<T> currNode = headNode;
            int i = 0;

            while (currNode != null)
            {
                if (EqualityComparer<T>.Default.Equals(colorLs, currNode.Color))
                {
                    stopWatch.Stop();
                    Console.WriteLine($"Time elapsed for Linear Search: {stopWatch.Elapsed} seconds.");
                    return i;
                }

                currNode = currNode.NextNode;
                i++;
            }
            return -1;
        }

        private void MoveColors(Node<T> nOne, Node<T> nTwo)
        {
            T tempNodeOne = nOne.Color;
            nOne.Color = nTwo.Color;
            nTwo.Color = tempNodeOne;

        }

        private void QsRec(Node<T> l, Node<T> r)
        {
            if (l == null || r == null || l == r || l == r.NextNode)
            {
                return;
            }

            Node<T> p = DelimitN(l, r);
            QsRec(l, p.PrevNode);
            QsRec(p.NextNode, r);

        }

        private Node<T> DelimitN(Node<T> l, Node<T> r)
        {
            Node<T> i = l.PrevNode;
            for (Node<T> j = l; j != r; j = j.NextNode)
            {
                if (Comparer<T>.Default.Compare(j.Color, r.Color) <= 0)
                {
                    if (i == null)
                    {
                        i = l;
                    }
                    else
                    {
                        i = i.NextNode;
                    }

                    MoveColors(i, j);
                }
            }

            if (i == null)
            {
                i = l;
            }
            else
            {
                i = i.NextNode;
            }

            MoveColors(i, r);
            return i;
        }

        public TimeSpan QuickSort()
        {
            var stopWatch = Stopwatch.StartNew();
            QsRec(headNode, tailNode);
            stopWatch.Stop();
            return stopWatch.Elapsed;

        }

        public TimeSpan BubbleSort()
        {
            var stopWatch = Stopwatch.StartNew();
            if (headNode == null || headNode.NextNode == null)
            {
                return stopWatch.Elapsed;
            }

            bool isSwap;
            Node<T> currN;
            Node<T> lSortN = null;

            do
            {
                isSwap = false;
                currN = headNode;

                while (currN.NextNode != lSortN)
                {
                    if (Comparer<T>.Default.Compare(currN.Color, currN.NextNode.Color) > 0)
                    {
                        MoveColors(currN, currN.NextNode);
                        isSwap = true;
                    }
                    currN = currN.NextNode;
                }
                lSortN = currN;
            }
            while (isSwap);
            stopWatch.Stop();
            return stopWatch.Elapsed;

        }
        public int BSearch(T colorBs)
        {
            var stopWatch = Stopwatch.StartNew();
            if (headNode == null)
            {
                return -1;
            }

            int l = 0;
            int r = this.countNodes - 1;

            while (l <= r)
            {
                int m = l + (r - l) / 2;
                Node<T> mNode = GetNodeIndex(m);

                int compareStrings = Comparer<T>.Default.Compare(colorBs, mNode.Color);

                if (compareStrings == 0)
                {
                    stopWatch.Stop();
                    Console.WriteLine($"Time elapsed for Binary Search: {stopWatch.Elapsed} seconds.");
                    return m;
                }
                else if (compareStrings < 0)
                {
                    r = m - 1;
                }
                else
                {
                    l = m + 1;
                }
            }
            return -1;
        }

        public List<T> TrFwd()
        {
            Node<T> currNode = this.headNode;
            List<T> list = new List<T>();

            while (currNode != null)
            {
                list.Add(currNode.Color);
                currNode = currNode.NextNode;
            }
            return list;

        }

        public List<T> TrBwd()
        {
            Node<T> currNode = this.tailNode;
            List<T> list = new List<T>();

            while (currNode != null)
            {
                list.Add(currNode.Color);
                currNode = currNode.PrevNode;
            }
            return list;
        }
    }
}
