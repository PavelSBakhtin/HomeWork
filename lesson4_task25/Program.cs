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

int PowAtoB(int A, int B)
{
    int result = 1;
    for (int i = 0; i < B; i++)
    {
        result = result * A;
    }
    return result;
}

int numA = ReadData("Enter number A: ");
int numB = ReadData("Enter number B: ");

int result = PowAtoB(numA, numB);
PrintData($"{numA} ^ {numB} = ", result);

// Math.Pow() в данной задаче не используется, так как исходя из её условий - решение через цикл