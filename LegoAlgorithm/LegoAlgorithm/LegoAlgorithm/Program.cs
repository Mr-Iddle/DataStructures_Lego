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
            /*Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());*/
            LinkedListTest<int> list = new LinkedListTest<int>();
            list.AddFirst(1);
            list.AddFirst(22);
            list.AddFirst(4);
            list.AddFirst(43);
            list.AddFirst(21);
            list.AddFirst(9);

            list.QuickSort(0,5);
            Console.WriteLine(list.ToString());

        }
    }
}
