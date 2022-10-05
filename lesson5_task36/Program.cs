int ReadData(string msg)
{
    Console.Write(msg);
    int number = int.Parse(Console.ReadLine() ?? "0"); // конструкция ??"0" нивелирует ошибку NULL
    return number;
}

int[] Fill1DArray(int length, int lowBord, int highBord)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(lowBord, highBord + 1);
    }
    return array;
}

void Print1DArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine(array[array.Length - 1] + "]");
}

void PrintSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum = sum + array[i];
        }
    }
    Console.WriteLine(sum);
}

int arrayLength = ReadData("Enter the length of the array: ");
int min = new Random().Next(-10, 10);
int max = new Random().Next(10, 100);
int[] array = Fill1DArray(arrayLength, min, max);
Print1DArray(array);
Console.WriteLine("Sum of elements in odd positions: ");
PrintSum(array);
