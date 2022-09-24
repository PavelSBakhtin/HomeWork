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
    Console.WriteLine("enter values for point A:");
    int Xa = int.Parse(Console.ReadLine());
    int Ya = int.Parse(Console.ReadLine());
    int Za = int.Parse(Console.ReadLine());

    Console.WriteLine("enter values for point B:");
    int Xb = int.Parse(Console.ReadLine());
    int Yb = int.Parse(Console.ReadLine());
    int Zb = int.Parse(Console.ReadLine());

    double result = Math.Sqrt(Math.Pow((Xa - Xb), 2) + Math.Pow((Ya - Yb), 2) + Math.Pow((Za - Zb), 2));
    result = Math.Round(result, 2);
    Console.WriteLine("distance AB is: " + result);
}
void Mission23()
{
    Console.WriteLine("Enter any integer greater than 1:");
    int user_num = int.Parse(Console.ReadLine());

    if (user_num > 0)
    {
        Console.WriteLine("sheet of cubes of numbers from 1 to " + user_num);
        for (int a = 1; a <= user_num; a++)
        {
            Console.WriteLine(Math.Pow(a, 3));
        }
    }
    else
    {
        Console.WriteLine("you entered the wrong number");
    }
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
