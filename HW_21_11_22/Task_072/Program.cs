Console.WriteLine("Please, input the integer number!");
int number = Convert.ToInt32(Console.ReadLine());
int numberAbs = Math.Abs(number);


if (numberAbs < 100)
{
    Console.WriteLine("Inputing number has no the theird digital!");
}
else {
    int result = 0;
    while (numberAbs > 999)
    {
        numberAbs = numberAbs / 10;
        result = numberAbs  % 10;        
    }
Console.WriteLine($"The inputing number has the theird digital is {result}!");
}