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
            // Для преподавателя:
            // Ничего более интересней конструкции я не придумал,
            // подозреваю, что существует, но - не додумался.
            // Технически условие задачи выполнено в полном объеме,
            // но смущает тот факт, что числа преимущественно от -1 до 1.
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

int y = ReadData("Enter the number of lines: "); // for example 3
int x = ReadData("Enter the number of columns: "); // for example 4
double[,] matrix = new double[y, x];
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
