using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoAlgorithm
{
    public class CsvS<T>
    {
        //innitiate a new linked list
        private LinkedListTest<T> mylist;
        

        public CsvS()
        {
            this.mylist = new LinkedListTest<T>();
            var startindex = mylist.GetFirst();
            var endindex = mylist.GetLast();

        }


        public LinkedListTest<T> getLinkedList()
        {
            return this.mylist;
        }

        public void nodeBuilder(string pathCsv)
        {
            using (StreamReader reader = new StreamReader(pathCsv))
            {
                reader.ReadLine();

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] fields = line.Split(','); //check here
                    if (fields.Length >= 2)
                    {
                        T fieldValue = tConverter<T>(fields[1].Trim());
                        mylist.AddLast(fieldValue);
                    }
                }
            }
        }
            
        public int linearSearchCSV(T colorSLs)
        {
            

            mylist.LinearSearch(colorSLs,0, mylist.Count - 1);
            return 1;
        }

        public int binarySearchCsv(T colorLs)
        {

            mylist.BinarySearch(colorLs,0,mylist.Count-1);
            return 1;
        }



        private static T tConverter<T>(string value)
        {
            TypeConverter conv = TypeDescriptor.GetConverter(typeof(T));
            return (T)conv.ConvertFromString(value);
        }
    }
}
