string ReadData(string msg)
{
    Console.Write(msg);
    string numbers = Console.ReadLine() ?? "0";
    return numbers;
}

void PrintData(string msg, int value)
{
    if (value == 0) Console.WriteLine(msg);
    else Console.WriteLine(msg + value);
}

void FillArray(int[,] matrixNew)
{
    for (int i = 0; i < matrixNew.GetLength(0); i++)
    {
        for (int j = 0; j < matrixNew.GetLength(1); j++)
        {
            matrixNew[i, j] = new Random().Next(-9, 10);
        }
    }
}

void PrintArray(int[,] matrixNew)
{
    for (int i = 0; i < matrixNew.GetLength(0); i++)
    {
        for (int j = 0; j < matrixNew.GetLength(1); j++)
        {
            Console.Write("{0,3}", $"{matrixNew[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

string index = ReadData("Enter the index of number: ");
int y = new Random().Next(3, 10);
int x = new Random().Next(4, 10);
int[,] matrix = new int[y, x];
FillArray(matrix);
PrintArray(matrix);
string[] array = index.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
int yNew = int.Parse(array[0]);
int xNew = int.Parse(array[1]);

if (yNew < y && xNew < x)
{
    PrintData("Number in array by user index: ", matrix[yNew, xNew]);
}
else
{
    int q = 0;
    PrintData("User index is incorrect", q);
}
