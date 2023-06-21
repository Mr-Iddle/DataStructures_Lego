using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoAlgorithm
{
    public class QuickSort
    {
        //create QuickSort method
        public static void QuickSortMethodCustom<T>(T[] array, int left, int right) where T : IComparable
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
    }
}
