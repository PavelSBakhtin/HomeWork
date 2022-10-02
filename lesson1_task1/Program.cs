int secret_number = new Random().Next(1, 10);
int attempt = 3;
Console.WriteLine("Вы попали в игру - Угадай число!");
Console.WriteLine("У вас есть " + attempt + " попытки");
bool Win = false;

while (attempt > 0)
{
    Console.WriteLine("Введите число от 1 до 9");
    int user_number = int.Parse(Console.ReadLine()??"0");

        if (user_number > secret_number)
    {
        Console.WriteLine("Секретное число меньше");
        attempt--;
    }
    else if (user_number < secret_number)
    {
        Console.WriteLine("Секретное число больше");
        attempt--;
    }
    else if (user_number == secret_number)
    {
        Console.WriteLine("Вы угадали секретное число!");
        Win = true;
        break;
    }
    Console.WriteLine("Осталось попыток: " + attempt);
}
if (Win)
{
    Console.WriteLine("Вы выйграли! Приходите снова :)");
    Console.WriteLine("Осталось попыток " + (attempt-1));
}
else
{
    Console.WriteLine("Вы проиграли :( Секретное число было: " + secret_number);
    Console.WriteLine("Попробуйте ещё раз :)");
}

Console.WriteLine("Goodbye");
Console.WriteLine("press any key to exit");
string user_key = Console.ReadLine()??"0";
