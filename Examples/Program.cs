int num;

Console.WriteLine("Enter number to check if positive or negative: " );
num = Convert.ToInt32(Console.ReadLine());

if (num >= 0)
{
    Console.WriteLine("{0} is a positive number", num);
}
else
{
    Console.WriteLine("{0} is a negative number", num);
}