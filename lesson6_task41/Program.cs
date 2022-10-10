string ReadData(string msg)
{
    Console.Write(msg);
    string numbers = Console.ReadLine() ?? "0";
    return numbers;
}

void PrintData(string msg, int value)
{
    Console.WriteLine(msg + value);
}

string numbers = ReadData("Enter some numbers: ");
string[] array = numbers.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
// // // Если в условиях Split убрать создание нового массива и оставить только ','
// // // - то тогда, при перечислении чисел через пробел, программа выдаст ошибку.
int sum = 0;
foreach (var item in array)
{
    if (int.Parse(item) > 0) sum++;
}
PrintData($"Sum of numbers greater than 0 = ", sum);


// // Изначальное решение:
// int[] array = Array.ConvertAll(ReadData("Enter some numbers separated by spaces: ").Split(), int.Parse);
// int count = 0;

// for (int i = 0; i < array.Length; i++)
// {
//     if(array[i] > 0) count++;
// }

// Console.WriteLine($"Numbers greater than 0: {count}");
