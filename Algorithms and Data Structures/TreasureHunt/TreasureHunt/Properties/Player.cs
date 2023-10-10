using System;

class Player
{
    public int Row { get; private set; }
    public int Col { get; private set; }
    public int Moves { get; private set; }

    public Player(Grid grid, int moves)
    {
        Random random = new Random();
        
        // To make sure the player position isn't set to [0,0], I used do while instead of while.
        do
        {
            Row = random.Next(0, grid.Rows);
            Col = random.Next(0, grid.Cols);
        } while (Row == grid.TreasureRow && Col == grid.TreasureCol || Row == grid.DeathTrapRow && Col == grid.DeathTrapCol);
        
        Moves = moves;
    }

    public void Move(string direction, int mapRows, int mapCols)
    {
        switch (direction.ToLower())
        {
            case "up":
                if (Row > 0)
                {
                    Row--;
                    Moves--;
                }
                break;
            case "down":
                if (Row < mapRows - 1)
                {
                    Row++;
                    Moves--;
                }
                break;
            case "left":
                if (Col > 0)
                {
                    Col--;
                    Moves--;
                }
                break;
            case "right":
                if (Col < mapCols - 1)
                {
                    Col++;
                    Moves--;
                }
                break;
            default:
                Console.WriteLine("Enter a valid direction!!!!!!");
                break;
        }
    }
}