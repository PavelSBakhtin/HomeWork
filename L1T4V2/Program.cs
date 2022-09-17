int a = 44;
int b = 5;
int c = 78;
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
