// Задача 54: Задайте двумерный массив.
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

void PrintData(string msg, string averages)
{
    Console.WriteLine(msg + averages);
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

string Average(int[,] getMatrix, int row, int column)
{
    double sum = 0;
    double average = 0;
    string result = string.Empty;
    for (int j = 0; j < row; j++)
    {
        for (int i = 0; i < column; i++)
        {
            sum += getMatrix[i, j];
        }
        average = sum / row;
        average = Math.Round(average, 1);
        if (j != row - 1) result += $"{average.ToString()}; ";
        else result += $"{average.ToString()}. ";
        // result += String.Join("", $"{average.ToString()}; "); - первое решение.
        average = 0;
        sum = 0;
    }
    return result;
}

int y = new Random().Next(3, 10);
int x = new Random().Next(4, 10);
int[,] matrix = new int[y, x];
FillArray(matrix);
PrintArray(matrix);
PrintData("Average of each column: ", Average(matrix, x, y));
