void Mission19()
{
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
}
void Mission21()
{
    // task 21
}
void Mission23()
{
    // task 23
}

Console.WriteLine("Enter the number of task:");
while (true)
{
    int user_number = int.Parse(Console.ReadLine());
    if (user_number == 1)
    {
        Mission19();
    }
    if (user_number == 2)
    {
        Mission21();
    }
    if (user_number == 3)
    {
        Mission23();
    }
    break;
}
