/* Напишите программу по замене элементов массива: положительные 
элементы замените на соответствующие отрицательные, и наоборот. */

int[] CreatorArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
    return array;
}

int[] NumberArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
    return array;
}

bool FindNumber(int number, int[] array)
{
    // foreach (var item in array)
    // {
    //     if (item == number)
    //     {
    //         return true;
    //     }
    // }
    // return false;
    return array.Contains(number); // эта строка делает тоже, что и цикл foreach
}

int[] array = CreatorArray(8, -10, 11);
Console.WriteLine(String.Join(" ", array));
array = NumberArray(array);
Console.WriteLine(String.Join(" ", array));
Console.WriteLine(FindNumber(1, array));
