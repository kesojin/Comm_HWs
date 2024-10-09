// See https://aka.ms/new-console-template for more information
using System.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

#region Task1
Console.WriteLine("Please, enter the length of the array:");
int n = int.Parse(Console.ReadLine());

List<int> elements = new List<int>();

List<int> evenNumbers = new List<int>();
List<int> oddNumbers = new List<int>();

for (int i = 0; i < n; i++)
{
    elements.Add(i);
    Console.WriteLine(elements[i] + 1);
}

foreach (int number in elements)
{
    if (number % 2 == 0)
    {
        evenNumbers.Add(number);
    }
    else
    {
        oddNumbers.Add(number);
    }
}

// string.Join takes all the elements from array and prints them in one line
// how to not write 0 ?
Console.WriteLine("Even numbers: ");
Console.WriteLine(string.Join(" ", evenNumbers));

Console.WriteLine("Odd Numbers: ");
Console.WriteLine(string.Join(" ", oddNumbers));
#endregion

#region Task2
// couldn't connect voids to run properly
while (true)
{
    Console.WriteLine("Add a new contact");
    Console.WriteLine("Remove a contact");
    Console.WriteLine("Update a contact");

    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            AddContact();
            break;
        case "2":
            RemoveContact();
            break;
        case "3":
            UpdateContact();
            break;
        default:
            Console.WriteLine("Please, try again");
            break;
    }
}

static void AddContact()
{
    var contacts = new Dictionary<string, int>();
    Console.WriteLine("Enter contact name: ");
    string name = Console.ReadLine();
    Console.WriteLine("Enter contact phone number: ");
    int number;
    string phoneNumber = Console.ReadLine();
    bool isString = int.TryParse(phoneNumber, out number);

    if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(phoneNumber))
    {
        Console.WriteLine("Name or phone number cannot be empty");
        return;
    }

    if (contacts.ContainsKey(name))
    {
        Console.WriteLine("Contact already exists");
    }
    else
    {
        contacts.Add(name, number);
        Console.WriteLine("Contact added");
    }
}

static void RemoveContact()
{
    var contacts = new Dictionary<string, int>();
    Console.WriteLine("Type a name to remove a contact: ");
    string name = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(name))
    {
        Console.WriteLine("Name cannot be empty");
    }
    else if (contacts.Remove(name))
    {
        Console.WriteLine("Contact removed");
    }
    else
    {
        Console.WriteLine("Contact not found");
    }
}

static void UpdateContact()
{
    var contacts = new Dictionary<string, int>();
    Console.WriteLine("Type a contact name to update: ");
    string name = Console.ReadLine();

    if (contacts.ContainsKey(name))
    {
        Console.Write("Write a new phone number: ");
        string newNumber = Console.ReadLine();
        // contacts[name] = newNumber;   fix this error
        Console.WriteLine("Contact updated successfully");
    }
    else
    {
        {
            Console.WriteLine("Contact not found");
        }

    }
}
#endregion

#region Task3
//var numbersList = new List<int> { 1, 2, 3, 4, 5 };

//var frequency = from n in numbersList group n by n into amount select amount;

//foreach (var item in numbersList)
//{
//    // mistakes here; dunno what's the issue
//    Console.WriteLine($" {item.Key} Appears {item.Count()} times in your array and sum is: {item.Sum()} ");
//}
#endregion

#region Task4
//Console.WriteLine("Choose the amount of top students: ");
//int n = int.Parse(Console.ReadLine());
//int[] topResults = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
//int starter = topResults.Length - n;

//for (int i = 0; i < topResults.Length; i++)
//{
//    Console.WriteLine(topResults[i]);
//    // prints all results ?
//}
#endregion