using System;
using System.IO;
using DoubleLinkedList;

CsvS<string> csv = new CsvS<string>();
csv.nodeBuilder("colors.csv");

string searchColor = "Black";
int positionSls = csv.sentinelLinearSearchCsv(searchColor);
int positionLs = csv.linearSearchCsv(searchColor);
int positionBs  = csv.binarySearch(searchColor);

if (positionSls != -1 && positionLs != -1)
{
    //$ is string inerpolation {} are bindings. String interpolation allows us to bind the variables to the string.
    Console.WriteLine($"Position (sentinel linear search) of '{searchColor}' is {positionSls}");
    Console.WriteLine($"Position (linear search) of '{searchColor}' is {positionLs}");
    Console.WriteLine($"Position (binary search) of '{searchColor}' is {positionBs}");
}
else
{
    Console.WriteLine($"'{searchColor}' not found !");
}

Console.WriteLine("Traversing forward:");
//csv.getDll().trFwd();

Console.WriteLine("Traversing backward:");
//csv.getDll().trBwd();

//Quicksort
//csv.getDll().quickSort();

//Console.WriteLine("QUICKSORT ! After sorting ALPHABETICALLY:");
//csv.getDll().trFwd();

//Bubblesort
//csv.getDll().bubbleSort();

Console.WriteLine("BUBBLE SORT ! After sorting with Bubble sort ALPHABETICALLY BACKWARDS:");
//csv.getDll().trBwd();
