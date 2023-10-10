using System;

public class Program
{
    private static int[] bottomUp;
    public static void Main()
    {
        Console.WriteLine("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        int result = Fibonacci(number);
        Console.Write($"Fibonacci of {number} is {result}");
    }

    public static int Fibonacci(int num)
    {
        if (num == 1 || num == 2)
        {
            return 1;
        }
        
        bottomUp = new int[num + 1];
        bottomUp[1] = 1;
        bottomUp[2] = 1;

        for (int i = 3; i <= num; i++)
        {
            bottomUp[i] = bottomUp[i - 1] + bottomUp[i - 2];
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
        int num1 = 1, num2 = 1, sum = 0, numOfElements;
        Console.Write("Enter the number of elements: ");
        numOfElements = int.Parse(Console.ReadLine());
        //Console.Write(num1 + " " + num2 + " ");
        
        for (int i = 2; i < numOfElements; ++i)
        {
            sum = num1 + num2;
            num1 = num2;
            num2 = sum;
        }    
        Console.Write(sum + " ");
    }  
}*/