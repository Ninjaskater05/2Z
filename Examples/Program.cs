float num1, num2, num3;

Console.Write("Input first number: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second number: ");
num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input third number: ");
num3 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    if (num1 > num3)
    {
        Console.WriteLine("{0} is the biggest number", num1);
    }
    else
    {
        Console.WriteLine("{0} is the biggest number", num3);
    }
}
else
{
    Console.WriteLine("{0} is the biggest number", num2);
}