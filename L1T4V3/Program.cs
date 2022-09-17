int a = 22;
int b = 3;
int c = 9;
int max = a;

Console.WriteLine("We have: " + a + " and " + b + " and " + c);
Console.WriteLine("Which of these max ?");

if (b > max)
{
    max = b;
}
if (c > max)
{
    max = c;
}

Console.WriteLine(max);
