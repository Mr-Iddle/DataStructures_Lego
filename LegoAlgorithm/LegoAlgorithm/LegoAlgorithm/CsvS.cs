using System.Collections.Concurrent;
using System.ComponentModel;
using System.IO;

namespace LegoAlgorithm
{
    public class CsvS<T>
    {
        private ChrisArrayList<T> ArrayList;
        //CorvinLinkedList<T> LinkedList;
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

        /*public void nodeBuilder(string pathCsv)
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
                        dll.AddLastNode(fieldValue);
                    }
                }
            }
        }*/

        /*public int sentinelLinearSearchCsv(T colorSLs)
        {
            return dll.sentinelLinearSearch(colorSLs);
        }

        public int linearSearchCsv(T colorLs)
        {
            return dll.linearSearch(colorLs);
        }*/



        private static T tConverter<T>(string value)
        {
            TypeConverter conv = TypeDescriptor.GetConverter(typeof(T));
            return (T)conv.ConvertFromString(value);
        }
    }
}