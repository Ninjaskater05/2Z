float height;

Console.Write("Input your height (in cm): ");
height = Convert.ToInt32(Console.ReadLine());

if (height < 160)
{
    Console.WriteLine("This person a dwarf");
}
else if (height >= 160 && height < 210)
{
    Console.WriteLine("This person a normal height");
}
else 
{
    Console.WriteLine("WTF?");
}