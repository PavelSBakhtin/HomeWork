Console.WriteLine("Введите три любых целых числа");
int user_numberA = int.Parse(Console.ReadLine()??"0");
int user_numberB = int.Parse(Console.ReadLine()??"0");
int user_numberC = int.Parse(Console.ReadLine()??"0");
int max = user_numberA;

if (user_numberB > max)
{
    max = user_numberB;
}
if (user_numberC > max)
{
    max = user_numberC;
}
Console.WriteLine("max = " + max);
