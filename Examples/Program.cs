float cord1, cord2;

Console.Write("Input value for x: ");
cord1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input value for y: ");
cord2 = Convert.ToInt32(Console.ReadLine());

if (cord1 > 0)
{
    if (cord2 > 0)
    {
        Console.WriteLine("The coordinate point ({0}, {1}) lies in first quadrant", cord1, cord2);
    }
    else
    {
        Console.WriteLine("The coordinate point ({0}, {1}) lies in fourth quadrant", cord1, cord2);
    }
}
else if (cord1 < 0 && cord2 < 0)
{
    Console.WriteLine("The coordinate point ({0}, {1}) lies in third quadrant", cord1, cord2);
}
else
{
    Console.WriteLine("The coordinate point ({0}, {1}) lies in second quadrant", cord1, cord2);
}