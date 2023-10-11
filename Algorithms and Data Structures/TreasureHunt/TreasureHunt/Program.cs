using System;

class Program
{
    static void Main()
    {
        int rows = 5;
        int cols = 8;
        int moves = 10;

        Grid grid = new Grid(rows, cols);
        Player player = new Player(grid, moves);
        
        Console.WriteLine("***Welcome to Treasure Hunt!***");
        
        // The game loop
        while (true)
        {
            PrintGameInfo(player, grid);
            
            string input = Console.ReadLine();
            
            if (input.ToLower() == "cheat")
            {
                HandleCheatCommand(player,grid);
            }
            else
            {
                player.Move(input, rows, cols);

                CheckGameOutcomes(player, grid);
            }
        }
    }
    
    static void PrintGameInfo(Player player, Grid grid)
    {
        Console.WriteLine($"Moves left: {player.Moves}");
        grid.PrintMap(player.Row, player.Col, false);
        Console.WriteLine("Enter direction (up/down/left/right) or 'cheat' to find the treasure:");
    }
    
    static void HandleCheatCommand(Player player, Grid grid)
    {
        Console.WriteLine($"Treasure is located at [{grid.TreasureRow},{grid.TreasureCol}]");
                
        // Also player gets to see the Treasure location visually on map
        grid.PrintMap(player.Row, player.Col, true);
                
        Console.WriteLine();
    }
    
    static void CheckGameOutcomes(Player player, Grid grid)
    {
        if (player.Row == grid.TreasureRow && player.Col == grid.TreasureCol)
        {
            Console.WriteLine("***Congratulations! You found the treasure!***");
            Environment.Exit(0);
        }

        if (player.Row == grid.DeathTrapRow && player.Col == grid.DeathTrapCol)
        {
            Console.WriteLine("***You stepped on a trap and died!***");
            Environment.Exit(0);
        }

        if (player.Moves == 0)
        {
            Console.WriteLine("***You ran out of moves and died!***");
            grid.PrintMap(player.Row, player.Col, true);
            Environment.Exit(0);
        }
    }
}