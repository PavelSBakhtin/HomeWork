// Задача 54: Задайте двумерный массив.
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

int[,] SelectionSort(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++) // все следующие циклы построчно
    {
        for (int j = 0; j < array.GetLength(1); j++) // все следующие циклы в каждом столбце одной строки
        {
            for (int count = 0; count < array.GetLength(1); count++) // счетчик чисел в строке
            {
                for (int k = 0; k < array.GetLength(1) - 1; k++) // сдвигает меньшее число вправо
                {
                    if (array[i, k] < array[i, k + 1]) // сравнение текущего числа с правым
                    {
                        int temporary = array[i, k]; // меняет местами текущее число с правым
                        array[i, k] = array[i, k + 1];
                        array[i, k + 1] = temporary;
                    }
                }
            }
        }
    }
    return array;
}

int y = new Random().Next(3, 10);
int x = new Random().Next(4, 10);
int[,] matrix = new int[y, x];
FillArray(matrix);
PrintArray(matrix);
PrintData("The elements of each row are sorted in descending order:");
int[,] newMatrix = SelectionSort(matrix);
PrintArray(newMatrix);
