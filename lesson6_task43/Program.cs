int ReadData(string msg)
{
    Console.Write(msg);
    int number = int.Parse(Console.ReadLine() ?? "0"); // конструкция ??"0" нивелирует ошибку NULL
    return number;
}

void PrintData(string msg, string point)
{
    Console.WriteLine(msg + point);
}

string IntersectionPoint(double numA1, double numB1, double numA2, double numB2)
{
    double x = ((numB2 - numB1) / (numA1 - numA2));
    double y = (numA1 * ((numB2 - numB1) / (numA1 - numA2)) + numB1);
    return $"({x}; {y})";
}

int numA1 = ReadData("Enter number A1: ");
int numB1 = ReadData("Enter number B1: ");
int numA2 = ReadData("Enter number A2: ");
int numB2 = ReadData("Enter number B2: ");

string point = IntersectionPoint(numA1, numB1, numA2, numB2);
PrintData("Point of intersection of two straight lines: ", point);
