Console.WriteLine("Введите любое целое число");
int user_number = int.Parse(Console.ReadLine());
int x = 1;

Console.WriteLine("Все чётные числа от 1 до " + user_number + ":");
while (x <= user_number)
{
    if (x % 2 == 0)
    {
        Console.WriteLine(x);
    }
    x++;
}
// Console.WriteLine(x += 2); - или эта строка вместо алгоритма IF, но тогда int x = 0 (подсказка из мануала)
