using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number and the kTh permutation num: ");
        
        string input = Console.ReadLine();
        string[] inputArray = input.Split(' ');

        int n = int.Parse(inputArray[0]);
        int k = int.Parse(inputArray[1]);

        // Generate the list of numbers from 1 to n
        int[] numbers = Enumerable.Range(1, n).ToArray(); // linq required

        // Generate kth permutation and print each one
        PrintPermutations(numbers, k);
    }

    static void PrintPermutations(int[] numbers, int k)
    {
        int[] result = numbers;
        for (int i = 1; i < k; i++)
        {
            result = NextPermutation(result);
        }
        Console.WriteLine(string.Join("", result));
    }

    static int[] NextPermutation(int[] array)
    {
        // Find the rightmost element smaller than its next element
        int i = array.Length - 1;
        while (i > 0 && array[i - 1] >= array[i])
        {
            i--;
        }

        Console.WriteLine("i = : " + i);
        // if it's the last permutation
        if (i <= 0)
        {
            return array;
        }
        
        // Find the smallest element to the right of i-1 that is larger than i-1
        int j = array.Length - 1;
        while (array[j] <= array[i - 1])
        {
            j--;
        }
        Console.WriteLine("j = " + j);

        // Swap values at positions i-1 and j
        int temp = array[i - 1];
        array[i - 1] = array[j];
        array[j] = temp;

        // Reverse the suffix
        j = array.Length - 1;
        while (i < j)
        {
            temp = array[i];
            array[i] = array[j];
            array[j] = temp;
            i++;
            j--;
        }

        return array;
    }
}