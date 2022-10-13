// 1. пользователь вводит несколько чисел.
// 2. создаётся некий двумерный массив.
// 3. программа считает - сколько в массиве встречается чисел, введённых пользователем.

int[,] GetArray(int m, int n, int min, int max) // метод создаёт массив
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
            if (j == 0) Console.Write("{0,3}", result[i, j]);
            else Console.Write("{0,5}", result[i, j]);
            // Console.Write(result[i, j] + "\t");
        }
        Console.WriteLine();
    }
    return result;
}

int[] GoodArray(int[,] matrix, int[] array) // метод ищет и считает количество введённых чисел в массиве
{
    int[] arrOut = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        for (int x = 0; x < matrix.GetLength(0); x++)
        {
            for (int y = 0; y < matrix.GetLength(1); y++)
            {
                if (array[i] == matrix[y, x]) arrOut[i]++;
            }
        }
    }
    return arrOut;
}

int[] array = Console.ReadLine()!.Split(" ").Select(x => int.Parse(x)).ToArray(); // ввод чисел

int[] good = GoodArray(GetArray(6, 6, -10, 11), array); // вызов методов (стр.5, стр.22)

for (int i = 0; i < array.Length; i++) // печать на экран результата
{
    Console.WriteLine($"Число {array[i]} = {good[i]}");
}
