Console.WriteLine("Please, input the first integer number!");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please, input the second integer number!");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please, input the theird integer number!");
int n3 = Convert.ToInt32(Console.ReadLine());
int max = n1;

if (max < n2)
{
    max = n2;
}
if (max < n3)
{
    max = n3;
}
Console.WriteLine($"The maximum number from {n1}, {n2}, {n3} is number {max} !");