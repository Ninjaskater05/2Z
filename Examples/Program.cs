int int1, remainder1;

Console.Write("Input an integer to check whether number odd or even: ");
int1 = Convert.ToInt32(Console.ReadLine());

remainder1 = int1 % 2;

if (remainder1 == 0)
{
    Console.WriteLine ("{0} is an even integer", int1);
}
else
{
    Console.WriteLine ("{0} is an odd integer", int1);
}