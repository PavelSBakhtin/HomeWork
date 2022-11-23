// Задача 64: Задайте значение N.
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.

int ReadData(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine() ?? "0");
}

void PrintData(string msg)
{
    Console.WriteLine(msg);
}

void Numbers(int A) // рекурсия для вывода всех натуральных от N до 1
{
    while (A > 0)
    {
        Console.WriteLine(A);
        Numbers(A - 1);
        break;
    }
}

int N = ReadData("Enter natural number N: ");
PrintData($"All natural numbers from {N} to 1: ");
Numbers(N);
