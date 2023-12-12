int checkAge;

Console.WriteLine("Input a age to check if eligible to vote: ");
checkAge = Convert.ToInt32(Console.ReadLine());

if (checkAge >= 21)
{
    Console.WriteLine("{0} is a eligible year to vote", checkAge);
}
else
{
    Console.Write("{0} is not a eligible year to vote", checkAge);
}