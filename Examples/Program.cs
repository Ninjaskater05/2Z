int m, n;

Console.WriteLine("Input number");
m = Convert.ToInt32(Console.ReadLine());

if (m != 0)
{
    if (m > 0)
    {
        n = 1;
    }
    else
    {
        n = -1;
    }
}
else
{
    n = 0;
}

Console.WriteLine("{0} is m", m);
Console.WriteLine("{0} is n", n);