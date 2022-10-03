string[,] matrix = {
    {" "," "," "," "," "," "," "},
    {" "," "," "," "," "," "," "},
    {" ","@"," "," "," "," "," "},
    {" "," "," "," "," "," "," "},
    {" "," "," "," ","*"," "," "},
    {" "," "," "," "," "," "," "},
    {" "," "," "," "," "," "," "}};

int X = 1;
int Y = 2;
int count = 0;

void WriteArrayMatrix(string[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++) // 0 - y, 1 - x, 2 - z = имена координатных
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // 0 - y, 1 - x, 2 - z = имена координатных
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void WriteCoordinates(int X, int Y, int count)
{
    Console.WriteLine($"X = {X}; Y = {Y}; Bonus = {count}");
}

int BonusCreator(string[,] matrix, int X, int Y, int count)
{
    while (matrix[Y, X] == "*")
    {
        count++;
        matrix[Y, X] = " ";
        int newCoorBonusY = new Random().Next(0, matrix.GetLength(0) - 1);
        int newCoorBonusX = new Random().Next(0, matrix.GetLength(1) - 1);
        matrix[newCoorBonusY, newCoorBonusX] = "*";
    }
    return count;
}

void Game(string[,] matrix, int X, int Y, int count)
{
    while (true)
    {
        matrix[Y, X] = " ";
        ConsoleKeyInfo user_keyTab = Console.ReadKey();
        if (user_keyTab.Key == ConsoleKey.W) Y--;
        if (user_keyTab.Key == ConsoleKey.S) Y++;
        if (user_keyTab.Key == ConsoleKey.A) X--;
        if (user_keyTab.Key == ConsoleKey.D) X++;
        if (Y < 0) Y = 0;
        if (X < 0) X = 0;
        if (Y > matrix.GetLength(0) - 1) Y = matrix.GetLength(0) - 1;
        if (X > matrix.GetLength(1) - 1) X = matrix.GetLength(1) - 1;

        count = BonusCreator(matrix, X, Y, count);
        matrix[Y, X] = "@";
        Console.Clear();
        WriteArrayMatrix(matrix);
        WriteCoordinates(X, Y, count);
    }
}

WriteArrayMatrix(matrix);
Game(matrix, X, Y, count);
