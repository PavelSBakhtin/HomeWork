int ReadData(string msg)
{
    Console.Write(msg);
    int number = int.Parse(Console.ReadLine() ?? "0"); // конструкция ??"0" нивелирует ошибку NULL
    return number;
}

void PrintData(string msg, double value) // для value не забыть сменить тип данных
{
    Console.WriteLine(msg + value);
}

long Factorial(int num)
{
    long res = 1;
    for (int i = 1; i <= num; i++)
    {
        res = res * i;
    }
    return res;
}

int num = ReadData("Enter number N: ");
long outResult = Factorial(num);
PrintData("Factorial of number " + num + " equals: ", outResult);
