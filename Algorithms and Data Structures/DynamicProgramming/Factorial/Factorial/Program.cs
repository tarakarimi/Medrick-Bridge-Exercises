using System;

public class Program
{
    private static int[] bottomUp;
    public static void Main()
    {
        Console.WriteLine("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        int result = Factorial(number);
        Console.Write($"Factorial of {number} is {result}");
    }

    public static int Factorial(int num)
    {
        bottomUp = new int[num+1];
        bottomUp[1] = 1;

        for (int i = 2; i <= num; i++)
        {
            bottomUp[i] = i * bottomUp[i - 1];
        }

        return bottomUp[num];
    }
}


/*
 // Non Dynamic approach
 using System;  

public class Program 
{  
    public static void Main()
    {
        int i, factorial = 1, number;
        Console.Write("Enter a Number: ");
        number = int.Parse(Console.ReadLine());     
        for(i = 1; i <= number; i++)
        {
            factorial = factorial * i;
        }

        Console.Write($"Factorial of {number} is {factorial}");
    }  
}*/