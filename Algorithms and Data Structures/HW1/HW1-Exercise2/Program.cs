using System;

class Program
{
    private static int lineCounter;

    static void Main()
    {
        Console.Write("Enter a number: ");
        if (int.TryParse(Console.ReadLine(), out int input) && input >= 0 && input <= 100)
        {
            PrintInvertedTriangles(input);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a non-negative integer between 0 and 100.");
        }
    }

    static void PrintInvertedTriangles(int input)
    {
        DrawTopPart(input);
        DrawMiddlePart(input);
        PrintBottomPart(lineCounter);

        if (input == 1)
        {
            return;
        }

        lineCounter = 0;
        PrintInvertedTriangles(input - 1);
    }

    static void DrawTopPart(int n)
    {
        int topPartStars = (4 * n) - 1;
        PrintTopStarsRecurssively(topPartStars);
        lineCounter++;
        Console.WriteLine();
    }

    static void DrawMiddlePart(int rows)
    {
        if (lineCounter > rows * 2 - 2)
        {
            return;
        }

        // Calculate the number of spaces
        int spaces = lineCounter;
        PrintSpaces(spaces);

        // Print the first star
        Console.Write("*");

        // Calculate the number of spaces between stars
        int spacesBetweenStars = (4 * rows) - 1 - (2 * spaces) - 2;

        // Print the spaces between stars
        PrintSpaces(spacesBetweenStars);

        // Print the second star
        Console.Write("*");

        Console.WriteLine();
        lineCounter += 1;
        DrawMiddlePart(rows);
    }

    static void PrintBottomPart(int input)
    {
        PrintSpaces(input);
        Console.WriteLine('*');
        Console.WriteLine();
    }

    static void PrintSpaces(int count)
    {
        if (count > 0)
        {
            Console.Write(" ");
            PrintSpaces(count - 1);
        }
    }

    static void PrintTopStarsRecurssively(int count)
    {
        if (count > 0)
        {
            Console.Write("*");
            PrintTopStarsRecurssively(count - 1);
        }
    }
}
