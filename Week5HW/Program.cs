// See https://aka.ms/new-console-template for more information
using System.Linq;

#region Task1
Console.WriteLine("Please, enter the length of the array:");
int n = int.Parse(Console.ReadLine());

List<int> elements = new List<int>();

List<int> evenNumbers = new List<int>();
List<int> oddNumbers = new List<int>();

for (int i = 0; i < n; i++)
{
    elements.Add(i);
    Console.WriteLine(elements[i]+1);
}

foreach (int number in elements)
{
    if (number % 2 == 0)
    {
        evenNumbers.Add(number);
    } else
    {
        oddNumbers.Add(number);
    }
}

// string.Join takes all the elements from array and prints them in one line
Console.WriteLine("Even numbers: ");
Console.WriteLine(string.Join(" ", evenNumbers));

Console.WriteLine("Odd Numbers: ");
Console.WriteLine(string.Join(" ", oddNumbers));
#endregion

#region Task2

#endregion