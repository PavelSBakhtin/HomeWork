// Задайте одномерный массив из 123 чисел.
// Найдите количество элементов массива, значения которых лежат в диапазоне [10, 99].

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

void FindNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 && array[i] >= 99)
        {
            count++;
        }
    }
    Console.WriteLine(count);
}

int[] array = Fill1DArray(123, -10, 150);
Print1DArray(array);
Console.Write("Number of elements in the array from 10 to 99: ");
FindNumber(array);
