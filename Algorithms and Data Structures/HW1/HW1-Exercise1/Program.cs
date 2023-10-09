using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the number of strings: ");
        int numberOfStrings = int.Parse(Console.ReadLine());
        
        List<int> results = new List<int>();

        for (int i = 0; i < numberOfStrings; i++)
        {
            Console.WriteLine("Enter the length of the string: ");
            int length = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the string: ");
            string input = Console.ReadLine();
            
            results.Add(FindShortestValidSubstringLength(length, input));
        }
        
        Console.WriteLine("Results:");
        foreach (int result in results)
        {
            Console.WriteLine(result);
        }
    }
    
    static int FindShortestValidSubstringLength(int length, string input)
    {
        int shortestValidSubStringLength = -1;

        // Check all substrings
        for (int start = 0; start < length; start++)
        {
            for (int subLength = 2; start + subLength <= length; subLength++)
            {
                string substring = input.Substring(start, subLength);
                int countA = 0, countB = 0, countC = 0;
                
                // Count of A, B, C
                for (int k = 0; k < subLength; k++)
                {
                    if (substring[k] == 'a')
                        countA++;
                    else if (substring[k] == 'b')
                        countB++;
                    else if (substring[k] == 'c')
                        countC++;
                }

                // Check the conditions for the substring
                if (countA > countB && countA > countC)
                {
                    // Valid substring found
                    if (shortestValidSubStringLength == -1 || subLength < shortestValidSubStringLength)
                    {
                        shortestValidSubStringLength = subLength;
                    }
                }
            }
        }
        
        return shortestValidSubStringLength;
    }
}
