void FillArray(double[,] matrixNew)
{
    for (int i = 0; i < matrixNew.GetLength(0); i++)
    {
        for (int j = 0; j < matrixNew.GetLength(1); j++)
        {
            matrixNew[i, j] = Math.Round(new Random().NextDouble() * new Random().Next(-10, 11), 1);
        }
    }
}

void PrintArray(double[,] matrixNew)
{
    for (int i = 0; i < matrixNew.GetLength(0); i++)
    {
        for (int j = 0; j < matrixNew.GetLength(1); j++)
        {
            Console.Write("{0,5}", $"{matrixNew[i, j]} ");
        }
        Console.WriteLine();
    }
}

double[,] matrix = new double[3, 4];
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
