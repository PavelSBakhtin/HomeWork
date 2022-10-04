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

void PrintEven(int[] array)
{
    int count = 0;
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j] % 2 == 0)
        {
            count++;
        }
    }
    Console.WriteLine(count);
}

int arrayLength = ReadData("Enter the length of the array: ");
int min = 100;
int max = 999;
int[] array = Fill1DArray(arrayLength, min, max);
Print1DArray(array);
Console.WriteLine("Number of even numbers in array: ");
PrintEven(array);
