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
    }
}