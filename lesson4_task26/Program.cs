int ReadData(string msg)
{
    Console.Write(msg);
    int number = int.Parse(Console.ReadLine());
    return number;
}

void PrintData(string msg, int value)
{
    Console.WriteLine(msg + value);
}

int CountDigitNum(int num)
{
    int count = 0;
    while (num > 0)
    {
        num /= 10;
        count++;
    }
    return count;
}

int CountDigitLog(int num)
{
    int countLog = (int)Math.Log10(num) + 1;
    return countLog;
}

int num = ReadData("Enter number N: ");
int resultSimple = CountDigitNum(num);
int resultLog = CountDigitLog(num);

DateTime t1 = DateTime.Now;
PrintData("Number of digits in number N equals: " + num + " = ", resultSimple);
Console.WriteLine(DateTime.Now - t1);

DateTime t2 = DateTime.Now;
PrintData("Number of digits in number N equals: " + num + " = ", resultLog);
Console.WriteLine(DateTime.Now - t2);
