using System.Collections.Concurrent;
using System.ComponentModel;
using System.IO;

namespace LegoAlgorithm
{
    internal class CsvS<T>
    {
        private ChrisArrayList<T> ArrayList;
        //private CorvinLinkedList<T> LinkedList;
        //private DLL<T> dll;


        public CsvS()
        {
            this.ArrayList = new ChrisArrayList<T>();
            //this.LinkedList = new CorvinLinkedList<T>();
            //this.dll = new DLL<T>();
        }

        /*public DLL<T> getDll()
        {
            return this.dll;
        }*/

        public void NodeBuilder(string pathCsv)
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
                        T fieldValue = TConverter<T>(fields[1].Trim());
                        //dll.AddLastNode(fieldValue);
                    }
                }
            }
        }

        /*public int sentinelLinearSearchCsv(T colorSLs)
        {
            return dll.sentinelLinearSearch(colorSLs);
        }

        public int linearSearchCsv(T colorLs)
        {
            return dll.linearSearch(colorLs);
        }*/



        public static T TConverter<T>(string value)
        {
            TypeConverter conv = TypeDescriptor.GetConverter(typeof(T));
            return (T)conv.ConvertFromString(value);
        }
    }
}