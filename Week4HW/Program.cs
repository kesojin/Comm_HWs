// See https://aka.ms/new-console-template for more information

#region Task1
Console.WriteLine("Please, input number");
int number1 = int.Parse(Console.ReadLine());
if (number1 % 5 == 0)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}
#endregion

#region Task2
Console.WriteLine("Insert the first number");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Insert the second number");
int y = int.Parse(Console.ReadLine());

int result;

result = x + y;
Console.WriteLine(result);

result = x * y;
Console.WriteLine(result);

if (x > y)
{
    result = x - y;
    Console.WriteLine(result);
}
else if (y > x)
{
    result = y - x;
    Console.WriteLine(result);
}

if (x > y)
{
    result = x / y;
    Console.WriteLine(result);
}
else if (y == 0)
{
    Console.WriteLine("Not Allowed to Devide by Zero");
}
else if (y > x)
{
    result = y / x;
    Console.WriteLine(result);
}
else if (x == 0)
{
    Console.WriteLine("Not Allowed to Devide by Zero");
}
#endregion

#region Task3
Console.WriteLine("Input 5 or 12");
int number3 = int.Parse(Console.ReadLine());

if (number3 == 5)
{
    Console.WriteLine(12);
}
else if (number3 == 12)
{
    Console.WriteLine(5);
}
else
{
    Console.WriteLine("Try again");
}
#endregion

#region Task4
Console.WriteLine("Please, enter a number");
int number2 = int.Parse(Console.ReadLine());

for (int i = 1; i < 10; i++)
{
    int x;
    x = (number2 * i);
    Console.WriteLine($"{number2} * {i} = {x}");
}
#endregion

#region Task5
Console.WriteLine("Please, enter a number");
int number5 = int.Parse(Console.ReadLine());

for (int i = 1; i < number5; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i * i);
    }
}
#endregion