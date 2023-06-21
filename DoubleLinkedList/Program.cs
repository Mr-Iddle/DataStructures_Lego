using System;
using System.IO;
using DoubleLinkedList;

CsvS csv = new CsvS();
csv.nodeBuilder("colors.csv");

string searchColor = "Brown";
int position = csv.binarySearchCsv(searchColor);

if (position != -1)
{
    Console.WriteLine($"Position of '{searchColor}' is {position}");
}
else
{
    Console.WriteLine($"'{searchColor}' not found !");
}

Console.WriteLine("Traversing fwd:");
csv.getDll().trFwd();

Console.WriteLine("Traversing bwd:");
csv.getDll().trBwd();