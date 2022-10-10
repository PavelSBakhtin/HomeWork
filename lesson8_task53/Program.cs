int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
            Console.Write(result[i, j] + "\t");
        }
        Console.WriteLine();
    }
    return result;
}

int[] GoodArray(int[,] matrix, int[] array)
{
    int[] arrOut = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        for (int x = 0; x < matrix.GetLength(0); x++)
        {
            for (int y = 0; y < matrix.GetLength(1); y++)
            {
                if (array[i] == matrix[y, x]) arrOut[i]++;
            }
        }
    }
    return arrOut;
}

int[] array = Console.ReadLine()!.Split(" ").Select(x => int.Parse(x)).ToArray();

int[] good = GoodArray(GetArray(6, 6, -10, 11), array);

for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"Число {array[i]} = {good[i]}");
}
