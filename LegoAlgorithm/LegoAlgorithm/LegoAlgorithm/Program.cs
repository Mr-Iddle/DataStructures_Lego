using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LegoAlgorithm
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ChrisArrayList<int> myList = new ChrisArrayList<int>();

            myList.Add(5);
            myList.Add(8);
            myList.Add(3);
            myList.Add(2);
            myList.Add(1);
            myList.Add(4);
            myList.Add(5);
            myList.Add(6);
            myList.Add(7);

            
            myList.BinarySearch(7, 0, 8);

            myList.BubbleSort(0, 8);
            Console.WriteLine(myList.ToString());
            myList.Clear();
            Console.WriteLine(myList.ToString());

            myList.Add(5);
            myList.Add(8);
            myList.Add(3);
            myList.Add(2);
            myList.Add(1);
            myList.Add(4);
            myList.Add(5);
            myList.Add(6);
            myList.Add(7);
            myList.QuickSort(0, 8);
            Console.WriteLine(myList.ToString());
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
        }
    }
}
