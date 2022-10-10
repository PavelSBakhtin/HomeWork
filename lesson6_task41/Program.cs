string ReadData(string msg)
{
    Console.Write(msg);
    string numbers = Console.ReadLine() ?? "0"; // конструкция ??"0" нивелирует ошибку NULL
    return numbers;
}

// string Numbers(string nums) // не получилось сделать красиво...
// {
//     string noSpaces = nums.Replace(" ", "");
//     string toArray = noSpaces.Replace(",", " "); 
//     return toArray;
// }



int[] array = Array.ConvertAll(ReadData("Enter some numbers separated by spaces: ").Split(), int.Parse);
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if(array[i] > 0) count++;
}

Console.WriteLine($"Numbers greater than 0: {count}");


