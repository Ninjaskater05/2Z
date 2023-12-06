// See https://aka.ms/new-console-template for more information
int num1, num2, num3;

Console.Write("\nInput the first number to multiply: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("\nInput the second number to multiply: ");
num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("\nInput the third number to multiply: ");
num3 = Convert.ToInt32(Console.ReadLine());

int result = num1 * num2 * num3;

Console.WriteLine("Output: {0} * {1} * {2} = {3}", num1, num2, num3, result);