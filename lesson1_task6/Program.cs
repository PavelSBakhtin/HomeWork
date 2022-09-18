Console.WriteLine("Введите любое целое число");
int user_number = int.Parse(Console.ReadLine());

if (user_number % 2 == 0)
{
    Console.WriteLine("This number is even ?");
    Console.WriteLine("YES");
}
if (user_number % 2 != 0)
{
    Console.WriteLine("This number is even ?");
    Console.WriteLine("NO");
}
