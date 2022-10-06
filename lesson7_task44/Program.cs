void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10); // [1; 10)
            // matr[i, j] = i + j; // создаст массив от 0 до 5, где каждое смещение по индексу будет +1
        }
    }
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int rows = 5;
int columns = 5;

int[,] matrix = new int[rows, columns];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();

for (int i = 1; i < rows; i++)
{
    for (int j = 1; j < columns; j++)
    {
        if (i % 2 == 0 && j % 2 == 0)
        {
            matrix[i, j] *= matrix[i, j];
        }
    }
}

Console.WriteLine("Result output:");
PrintArray(matrix);
