// Напишите программу, которая на вход принимает два числа A и B,
// и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

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

int PowAtoB(int A, int B) // рекурсия
{
    if (B == 0) return 1;
    return PowAtoB(A, B - 1) * A;
}

int numA = ReadData("Enter number A: ");
int numB = ReadData("Enter number B: ");

int result = PowAtoB(numA, numB);
PrintData($"{numA} ^ {numB} = ", result);
