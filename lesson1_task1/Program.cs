// Console.WriteLine("Введите число a");
// int a = int.Parse(Console.ReadLine());

Console.WriteLine("Вы попали в игру - Угадай число!");
int secret_number = 5;
while (true)
{
    Console.WriteLine("Введите число от 1 до 9");
    int user_number = int.Parse(Console.ReadLine());
    Console.WriteLine(user_number);
    if (user_number > secret_number)
    {
        Console.WriteLine("Секретное число меньше");
    }
    else if (user_number < secret_number)
    {
        Console.WriteLine("Секретное число больше");
    }
    else if (user_number == secret_number)
    {
        Console.WriteLine("Вы угадали секретное число!");
    }
}

