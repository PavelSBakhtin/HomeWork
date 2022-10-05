// Программа по нахождению рандомного слова из списка:

string words = Console.ReadLine() ?? "0";
string[] nums = words.Split(", ");
int index = new Random().Next(0,nums.Length);
Console.WriteLine(nums[index]);

Console.WriteLine(String.Join(" ",nums)); // Эта команда объединит все элементы (после удаления из строки ", ") и выведет через указанный элемент (в данном случае это " ").
