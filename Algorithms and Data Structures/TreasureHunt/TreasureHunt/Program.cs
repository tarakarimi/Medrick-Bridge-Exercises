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
        
        while (true)
        {
            Console.WriteLine($"Moves left: {player.Moves}");
            grid.PrintMap(player.Row, player.Col, false);

            Console.WriteLine("Enter direction (up/down/left/right) or 'cheat' to find the treasure:");
            string input = Console.ReadLine();

            if (input.ToLower() == "cheat")
            {
                Console.WriteLine($"Treasure is located at [{grid.TreasureRow},{grid.TreasureCol}]");
                
                // Also player gets to see the Treasure location visually on map
                grid.PrintMap(player.Row, player.Col, true);
                
                Console.WriteLine();
            }
            else
            {
                player.Move(input, rows, cols);

                // Check for game outcomes
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
    }
}