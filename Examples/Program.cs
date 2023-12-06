// See https://aka.ms/new-console-template for more information
int number1, number2, temp;

Console.Write("\nWrite the first number: ");
number1 = int.Parse(Console.ReadLine());

Console.Write("\nWrite the second number: ");
number2 = int.Parse(Console.ReadLine());

temp = number1;
number1 = number2;
number2 = temp;

Console.Write("\nAfter Swapping: ");
Console.Write("\nFirst Number : " + number1);
Console.Write("\nSecond Number : " + number2);

Console.Read();