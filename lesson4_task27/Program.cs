int ReadData(string msg)
{
    Console.Write(msg);
    int number = int.Parse(Console.ReadLine() ?? "0"); // конструкция ??"0" нивелирует ошибку NULL
    return number;
}

void PrintData(string msg, int value)
{
    Console.WriteLine(msg + value);
}

int DigitCount(int num)
{
    int result = 0;
    while (num > 0)
    {
        result = result + num % 10;
        num /= 10;
    }
    return result;
}

int num = ReadData("Enter any integer: ");
int sum = DigitCount(num);
PrintData($"The sum of the digits in integer {num} = ", sum);
