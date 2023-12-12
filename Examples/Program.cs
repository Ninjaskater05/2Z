int int1, int2;

Console.Write("input first number: ");
int1 = Convert.ToInt32(Console.ReadLine());

Console.Write("input second number: ");
int2 = Convert.ToInt32(Console.ReadLine());

if (int1 == int2)
{
    Console.WriteLine("{0} and {1} are equal", int1, int2);
}   

else
{
    Console.WriteLine("{0} is not equal to {1}", int1, int2);
}