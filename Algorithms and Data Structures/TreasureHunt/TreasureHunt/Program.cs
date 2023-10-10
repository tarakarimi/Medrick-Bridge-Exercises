using System;

class Program
{
    static void Main()
    {
        int rows = 5;
        int cols = 8;
        int moves = 10;
        bool isGameOver = false;

        Grid grid = new Grid(rows, cols);
        Player player = new Player(grid, moves);
        
        Console.WriteLine("***Welcome to Treasure Hunt!***");
    }
}