Console.WriteLine("Please, input the positive integer number!");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0)
{
    Console.WriteLine("You inputed the negative number!!! Please, input the positive integer number!");
}
else if (number < 2)
{
    Console.WriteLine($"There is NOT even numbers between 1 and {number}!");
}
else
{
    Console.Write($"The list of even numbers between 1 and {number} is: 2");
    int currentNumber = 3;
    while (currentNumber <= number)
    {
        if (currentNumber % 2 == 0)
        {
            Console.Write($", {currentNumber}");
        }
        currentNumber++;
    }
}


