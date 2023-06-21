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
                foreach (string field in fields)
                {
                    dll.AddLastNode(field.Trim());
                }
            }
        }
    }

    public int binarySearchCsv(string colorBs)
    {
        return dll.binarySearch(colorBs);
    }
}