void Mission10()
{
    Console.WriteLine("Enter a three-digit number:");
    int num10 = int.Parse(Console.ReadLine());

    if (num10 > 99 && num10 < 1000)
    {
        Console.WriteLine(num10 / 10 % 10);
    }
    else
    {
        Console.WriteLine("You entered the wrong number!");
    }
}
void Mission13()
{
    Console.WriteLine("Enter a number with three or more digits");
    int num13 = int.Parse(Console.ReadLine());

    if (num13 > 99)
    {
        while (num13 > 999)
        {
            num13 /= 10;
        }
        Console.WriteLine(num13 % 10);
    }
    else
    {
        Console.WriteLine("There is no third digit in the entered number!");
    }
}
void Mission15()
{
    Console.WriteLine("Enter the number of the day of the week:");
    int num15 = int.Parse(Console.ReadLine());

    if (num15 < 8)
    {
        if (num15 < 6)
        {
            Console.WriteLine("No, it's not a weekday!");
        }
        else
        {
            Console.WriteLine("Yes, it's a weekday!");
        }
    }
    else
    {
        Console.WriteLine("There is no such day of the week!");
    }
}

Console.WriteLine("Enter the number of task:");
while (true)
{
    int user_number = int.Parse(Console.ReadLine());
    if (user_number == 1)
    {
        Mission10();
    }
    if (user_number == 2)
    {
        Mission13();
    }
    if (user_number == 3)
    {
        Mission15();
    }
    break;
}
