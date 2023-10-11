using System;

class Exercise3
{
    static void Main()
    {
        Random random = new Random();
        int randNum = 13;//random.Next();
        GenerateQolatzSequence(randNum);

    }

    static bool IsPrime(int num, int divisor = 2)
    {
        if (num < 2)
            return false;
        for (int i = 2; i <= num / 2; i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }
        return true;
    }


    static bool IsPrimePrime(int num)
    {
        if (IsPrime(num) && IsPrime(CalculateSumOfDigits(num)))
        {
            return true;
        }
        return false;
    }
    
    static int CalculateSumOfDigits(int num)
    {
        int sum = 0;
        while (num > 0)
        {
            sum += num % 10;
            num /= 10;
        }
        return sum;
    }

    static void GenerateQolatzSequence(int num)
    {
        ResultForNumber(num);
        while (num != 1)
        {
            if (num % 2 == 0)
            {
                num = num / 2;
                ResultForNumber(num);
            }

            else
            {
                num += 1;
                ResultForNumber(num);
            }
        }
    }

    static void ResultForNumber(int num)
    {
        if (IsPrimePrime(num))
        {
            Console.WriteLine(num + "Y");
        }
        else
        {
            Console.WriteLine(num + "N");
        }
    }
    
}