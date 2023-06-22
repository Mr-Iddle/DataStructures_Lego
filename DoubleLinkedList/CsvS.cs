namespace DoubleLinkedList;

public class CsvS
{
    private DLL dll;

    public CsvS()
    {
        this.dll = new DLL();
    }

    public DLL getDll()
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
                    string fieldValue = fields[1].Trim();
                    dll.AddLastNode(fieldValue);
                }
            }
        }
    }

    public int sentinelLinearSearchCsv(string colorSLs)
    {
        return dll.sentinelLinearSearch(colorSLs);
    }

    public int linearSearchCsv(string colorLs)
    {
        return dll.linearSearch(colorLs);
    }
}