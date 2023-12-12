int checkLeap;

Console.WriteLine("Input a year, to check if leap year or not: ");
checkLeap = Convert.ToInt32(Console.ReadLine());

if (checkLeap % 4 == 0)
{
    Console.WriteLine("{0} is a leap year", checkLeap);
}
else
{
    Console.WriteLine("{0} is not a leap year", checkLeap);
}