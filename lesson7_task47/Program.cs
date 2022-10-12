int ReadData(string msg)
{
    Console.Write(msg);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

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

int y = ReadData("Enter the number of lines: ");
int x = ReadData("Enter the number of columns: ");
double[,] matrix = new double[y, x];
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
