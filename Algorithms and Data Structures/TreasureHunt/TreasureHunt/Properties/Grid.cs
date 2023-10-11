using System;

class Grid
{
    private int[,] map;
    private Random random = new Random();
    public int Rows { get; private set; }
    public int Cols { get; private set; }
    public int TreasureRow { get; private set; }
    public int TreasureCol { get; private set; }
    public int DeathTrapRow { get; private set; }
    public int DeathTrapCol { get; private set; }

    public Grid(int rows, int cols)
    {
        Rows = rows;
        Cols = cols;
        Initialize();
    }

    private void Initialize()
    {
        map = new int[Rows, Cols];

        for (int row = 0; row < Rows; row++)
        {
            for (int col = 0; col < Cols; col++)
            {
                map[row, col] = random.Next(10, 100);
            }
        }

        FindTreasureAndTrapLocation();
    }

    private void FindTreasureAndTrapLocation()
    {
        int maxCellValue = -1;
        int minCellValue = 100;

        for (int row = 0; row < Rows; row++)
        {
            for (int col = 0; col < Cols; col++)
            {
                if (map[row, col] > maxCellValue)
                {
                    maxCellValue = map[row, col];
                    TreasureRow = row;
                    TreasureCol = col;
                }

                if (map[row, col] < minCellValue)
                {
                    minCellValue = map[row, col];
                    DeathTrapRow = row;
                    DeathTrapCol = col;
                }
            }
        }
    }
    
    public void PrintMap(int playerRow, int playerCol, bool cheatMode)
    {
        for (int i = 0; i < Rows; i++)
        {
            for (int j = 0; j < Cols; j++)
            {
                if (i == playerRow && j == playerCol)
                {
                    Console.Write("[P] ");
                }
                else
                {
                    if (cheatMode && i == TreasureRow && j == TreasureCol)
                    {
                        Console.Write("[T] ");
                    }
                    else
                    {
                        Console.Write("[*] ");
                    }
                }
            }

            Console.WriteLine();
        }
    }
}