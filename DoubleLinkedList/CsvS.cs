using System.ComponentModel;

namespace DoubleLinkedList;

public class CsvS<T>
{
    private DLL<T> dll;

    public CsvS()
    {
        this.dll = new DLL<T>();
    }

    public DLL<T> getDll()
    {
        return this.dll;
    }

    public void nodeBuilder(string pathCsv)
    {
        using (StreamReader reader = new StreamReader(pathCsv))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] fields = line.Split(','); //check here
                if(fields.Length>=2)
                {
                    T fieldValue = tConverter<T>(fields[1].Trim());
                    dll.AddLastNode(fieldValue);
                }
            }
        }
    }

    public int sentinelLinearSearchCsv(T colorSLs)
    {
        return dll.sentinelLinearSearch(colorSLs);
    }

    public int linearSearchCsv(T colorLs)
    {
        return dll.linearSearch(colorLs);
    }

    private static T tConverter<T>(string value)
    {
        TypeConverter conv = TypeDescriptor.GetConverter(typeof(T));
        return (T)conv.ConvertFromString(value);
    }
}