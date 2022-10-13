// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

void PrintData(string msg)
{
    Console.WriteLine(msg);
}

void FillArray(int[,] matrixNew)
{
    for (int i = 0; i < matrixNew.GetLength(0); i++)
    {
        for (int j = 0; j < matrixNew.GetLength(1); j++)
        {
            matrixNew[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] matrixNew)
{
    Console.WriteLine();
    for (int i = 0; i < matrixNew.GetLength(0); i++)
    {
        for (int j = 0; j < matrixNew.GetLength(1); j++)
        {
            if (j == 0) Console.Write($"{matrixNew[i, j]} ");
            else Console.Write("{0,3}", $"{matrixNew[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int SelectionNum(int[,] array)
{
    int num = 0;
    int max = 0;
    int[] maxRow = new int[0];

    for (int i = 0; i < array.GetLength(0); i++) // находит суммы по всем строкам
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++) // находит сумму в строке
        {
            sum = sum + array[i, j];
        }
        Array.Resize(ref maxRow, maxRow.Length + 1);
        maxRow[maxRow.Length - 1] = sum;
    }

    for (int k = 0; k < maxRow.Length; k++) // находит наибольшую сумму
    {
        if (maxRow[k] > max) max = maxRow[k];
    }

    while (num < maxRow.Length)
    {
        if (maxRow[num] == max)
        {
            num++;
            break;
        }
        num++;
    }

    return num;
}

int y = new Random().Next(4, 10);
int x = new Random().Next(3, 10);
while (y == x)
{
    x = new Random().Next(4, 10);
}
int[,] matrix = new int[y, x];
FillArray(matrix);
PrintArray(matrix);
PrintData($"Matrix format = {y}(y) * {x}(x)");
PrintData($"Row number with the smallest sum of elements: {SelectionNum(matrix)} row.");
