using System;

class Program
    {
        static void Main(string[] args)
        {
            int start, end;
            string input = "";
            int operationNeeded = 0; 
            
            Console.Write("Enter the number of houses on the street: ");
            int housesOnStreet = int.Parse(Console.ReadLine());
            
            Console.Write("Enter the sequence for safe houses(P) and unsafe houses(H) : "); 
            
            while (input.Length < housesOnStreet)
            {
                char letter = char.ToUpper(Console.ReadKey().KeyChar);
                if (letter == 'P' || letter == 'H')
                {
                    input += letter;
                }
                else
                {
                    Console.WriteLine("The entered letter is invalid. Please try again.");
                }
            }
            
            Console.WriteLine();


            Console.Write("Please enter the start point (between 1 and {0}): ", housesOnStreet);
            start = int.Parse(Console.ReadLine()) - 1;
                
            Console.Write("Please enter the end point (between 1 and {0}): ", housesOnStreet);
            end = int.Parse(Console.ReadLine()) - 1;
                
            
            bool hFound = false;
            if (start <= end)
            {
                for (int i = start; i <= end; i++) 
                {
                    if (input[i] == 'H')
                    {
                        if (!hFound)
                        {
                            operationNeeded++;
                            hFound = true;
                        }
                    }
                    else
                    {
                        hFound = false;
                    }
                }
            }
            else
            {
                for (int i = start; i >= end; i--) 
                {
                    if (input[i] == 'H')
                    {
                        if (!hFound)
                        {
                            operationNeeded++;
                            hFound = true;
                        }
                    }
                    else
                    {
                        hFound = false;
                    }
                }
            }


            Console.WriteLine("Between the start point {0} and the end point {1}, there will be {2} operations needed.", start, end, operationNeeded);
        }
}
