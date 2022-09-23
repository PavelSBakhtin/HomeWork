Console.WriteLine("Enter first and last numbers to create an array:");
int user_number = int.Parse(Console.ReadLine());
int[] CreaterArrayNumber(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = i + 1;
    }
    return array;
}
void WriteArray(int[] array)
{
    for (int i = (user_number - 1); i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
int[] numbers = CreaterArrayNumber(int.Parse(Console.ReadLine()));
WriteArray(numbers);

// Создание массива от 1 до n
// Число n будет size

// Console.WriteLine("Enter last number (n) to create an array from 1 to n:");
// int[] CreaterArrayNumber(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = i + 1;
//     }
//     return array;
// }
// void WriteArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
// }
// int[] numbers = CreaterArrayNumber(int.Parse(Console.ReadLine()));
// WriteArray(numbers);
