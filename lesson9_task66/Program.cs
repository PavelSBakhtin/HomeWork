// Задача 66: Задайте значения M и N.
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int ReadData(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine() ?? "0");
}

void PrintData(string msg, int res)
{
    Console.WriteLine(msg + res);
}

int Numbers(int A, int B)
{
    int sum = 0;
    if (A > B)
    {
        int a = (A * (A + 1)) / 2;
        int b = (B * (B + 1)) / 2;
        sum = a - b + B;
        return sum;
    }
    else
    {
        int a = (B * (B + 1)) / 2;
        int b = (A * (A + 1)) / 2;
        sum = a - b + A;
        return sum;
    }
}

int M = ReadData("Enter the number M: ");
int N = ReadData("Enter the number N: ");
int result = Numbers(M, N);
PrintData($"Sum of all natural numbers from {M} to {N}: ", result);
