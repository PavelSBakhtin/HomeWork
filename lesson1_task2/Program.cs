Console.WriteLine("Введите два любых целых числа");
int user_numberA = int.Parse(Console.ReadLine()??"0");
int user_numberB = int.Parse(Console.ReadLine()??"0");

if (user_numberA > user_numberB)
{
    Console.Write("max = ");
    Console.WriteLine(user_numberA);
    Console.Write("min = ");
    Console.WriteLine(user_numberB);
}
else
{
    Console.Write("max = ");
    Console.WriteLine(user_numberB);
    Console.Write("min = ");
    Console.WriteLine(user_numberA);
}
