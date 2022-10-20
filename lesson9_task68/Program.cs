// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

int ReadData(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine() ?? "0");
}

void PrintData(string msg, int res)
{
    Console.WriteLine(msg + res);
}

int Ackerman(int a, int b)
{
    if (a == 0)
    {
        return b + 1;
    }
    if (a > 0 && b == 0)
    {
        return Ackerman(a - 1, 1);
    }
    return Ackerman(a - 1, Ackerman(a, b - 1));
}

int m = ReadData("Enter a number M greater than 0: ");
if (m < 1)
{
    m = 0;
    Console.WriteLine("Invalid value entered, now M = 0");
}
int n = ReadData("Enter a number N greater than 0: ");
if (n < 1)
{
    n = 0;
    Console.WriteLine("Invalid value entered, now N = 0");
}
int result = Ackerman(m, n);
PrintData($"A(m,n) = ", result);
