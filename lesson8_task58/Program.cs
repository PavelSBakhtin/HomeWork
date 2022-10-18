// Задача 58: Задайте две матрицы.
// Напишите программу, которая будет находить произведение двух матриц.

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

int[,] Multiplication(int[,] array1, int[,] array2) // перемножение двух матриц
{
    int[,] newArray = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int k = 0; k < array2.GetLength(0); k++)
            {
                newArray[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }
    return newArray;
}

int y = new Random().Next(2, 6);
int x1 = new Random().Next(2, 6);
int[,] matrix1 = new int[y, x1];
PrintData("The first matrix:");
FillArray(matrix1);
PrintArray(matrix1);
int x2 = new Random().Next(2, 6);
int[,] matrix2 = new int[x1, x2];
PrintData("The second matrix:");
FillArray(matrix2);
PrintArray(matrix2);
PrintData("Multiplication of two matrices:");
PrintArray(Multiplication(matrix1, matrix2));
