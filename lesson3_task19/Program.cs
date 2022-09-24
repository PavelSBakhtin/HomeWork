int NumberOne(int num, int NumberOfFirstNumbers)
{
    while (num / Math.Pow(10, NumberOfFirstNumbers) > 1)
    {
        num /= 10;
    }
    return num;
}

Console.WriteLine("enter a five-digit number:");
int number = int.Parse(Console.ReadLine());
if (number < 0) number *= -1;
if (number > 9999 && number < 100000)
{
    int x = number % 100;
    int y = NumberOne(number, 2);
    
    if (x / 10 == y % 10 && x % 10 == y / 10)
    {
        Console.WriteLine("yes, the number is a palindrome");
    }
    else
    {
        Console.WriteLine("no, the number is not a palindrome");
    }
}
else
{
    Console.WriteLine("you entered the wrong number");
}
