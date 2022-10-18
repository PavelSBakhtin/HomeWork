// Задача 62. Напишите программу, которая заполнит спирально массив.

int ReadData(string msg)
{
    Console.Write(msg);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
    // return Convert.ToInt32(Console.ReadLine() ?? "0"); // или так, вместо двух строк (6,7).
}

int[,] ArraySpiral(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    int i = 0;
    int j = 0;
    int k = 1;
    int isrt = 0;
    int iend = 0;
    int jsrt = 0;
    int jend = 0;

    while (k <= rows * columns)
    {
        array[i, j] = k;
        if (i == isrt && j < columns - jend - 1) j++;
        else if (j == columns - jend - 1 && i < rows - iend - 1) i++;
        else if (i == rows - iend - 1 && j > jend) j--;
        else i--;
        if ((i == isrt + 1) && (j == jsrt) && (jsrt != columns - jend - 1))
        {
            isrt++;
            iend++;
            jsrt++;
            jend++;
        }
        k++;
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int rows = ReadData("Enter size of rows: ");
int columns = ReadData("Enter size of columns: ");
int[,] array = ArraySpiral(rows, columns);
PrintArray(array);
