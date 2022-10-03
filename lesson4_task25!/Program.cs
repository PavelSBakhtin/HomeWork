double ReadData(string msg)
{
    Console.Write(msg);
    double number = double.Parse(Console.ReadLine()); // конструкция ??"0" нивелирует ошибку NULL
    return number;
}

string ReadSing(string msg)
{
    Console.Write(msg);
    string sing = Console.ReadLine();
    return sing;
}

void PrintData(string msg, double value)
{
    Console.Write(msg);
    Console.WriteLine(value);
}

double Calculator(double a, string sing, double b)
{
    double result = 0;
    if (sing == "+")
    {
        result = a + b;
    }
    if (sing == "-")
    {
        result = a - b;
    }
    if (sing == "*")
    {
        result = a * b;
    }
    if (sing == "/")
    {
        result = a / b;
    }
    if (sing == "^")
    {
        result = Math.Pow(a, b);
    }
    return result;
}

double numA = ReadData("Enter number A: ");
string sing = ReadSing("Enter operation sing: ");
double numB = ReadData("Enter number B: ");

double result = Calculator(numA, sing, numB);
PrintData($"{numA} {sing} {numB} = ", result);
