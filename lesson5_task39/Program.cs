string[,] matrix = {
    {" "," "," "," "," "," "," "},
    {" "," "," "," "," "," "," "},
    {" ","@ "," "," "," "," "," "},
    {" "," "," "," "," "," "," "},
    {" "," "," "," "," "," "," "},
    {" "," "," "," "," "," "," "},
    {" "," "," "," "," "," "," "}};

int X = 1;
int Y = 2;
void WriteArrayMatrix(string[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void Game(string[,] matrix, int X, int Y)
{
    while (true)
    {
        matrix[Y, X] = " ";
        ConsoleKeyInfo user_keyTab = Console.ReadKey();
        if (user_keyTab.Key == ConsoleKey.W) Y--;
        if (user_keyTab.Key == ConsoleKey.S) Y++;
        if (user_keyTab.Key == ConsoleKey.A) X--;
        if (user_keyTab.Key == ConsoleKey.D) X++;
        matrix[Y, X] = "@";
        Console.Clear();
        WriteArrayMatrix(matrix);
    }
}

WriteArrayMatrix(matrix);
Game(matrix, X, Y);
