int ReadData(string msg)
{
    Console.Write(msg);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

void PrintData(string msg, int value)
{
    Console.WriteLine(msg + value);
}

int SumDigitOneToA(int numA)
{
    int sum = 0;
    for (int i = 1; i <= numA; i++)
    {
        sum += i;
    }
    return sum;
}

int GaussMethod(int numA)
{
    int sum = numA * (numA + 1) / 2;
    return sum;
}

int numA = ReadData("Enter number A: ");

DateTime t1 = DateTime.Now;
int sum = SumDigitOneToA(numA);
Console.WriteLine(DateTime.Now - t1);
PrintData("Sum of numbers from 1 to A (simple): ", sum);

DateTime t2 = DateTime.Now;
int sumGauss = GaussMethod(numA);
Console.WriteLine(DateTime.Now - t2);
PrintData("Sum of numbers from 1 to A (Gauss): ", sumGauss);
