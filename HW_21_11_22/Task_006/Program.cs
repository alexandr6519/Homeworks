Console.WriteLine("Please, input the integer number!");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine($"The inputing number {number} is the EVEN!");
}
else
{
    Console.WriteLine($"The inputing number {number} is the ODD!");
}