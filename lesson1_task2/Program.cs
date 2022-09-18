Console.WriteLine("Введите два любых целых числа");
int user_numberA = int.Parse(Console.ReadLine());
int user_numberB = int.Parse(Console.ReadLine());

if (user_numberA > user_numberB)
{
    Console.Write("max = ");
    Console.WriteLine(user_numberA);
}
else
{
    Console.Write("max = ");
    Console.WriteLine(user_numberB);
}
