int NumberOne(int num, int NumberOfFirstNumbers)
{
    while (num / Math.Pow(10, NumberOfFirstNumbers) > 1)
    {
        num /= 10;
    }
    return num;
}

int number = int.Parse(Console.ReadLine()??"0");
if (number < 0) number *= -1;
if (number > 99)
{
    int x = number % 100;
    Console.WriteLine(NumberOne(number, 2));
    Console.WriteLine(x);
}
else if (number > 9)
{
    int x = number % 10;
    Console.WriteLine(NumberOne(number, 1));
    Console.WriteLine(x);
}
else
{
    Console.WriteLine("Enter number more 9");
}
