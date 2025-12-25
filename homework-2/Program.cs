using System;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        List<int> primeNumbers = new List<int>();
        List<int> nonPrimeNumbers = new List<int>();
        List<int> allNumbers = new List<int>();

        Console.WriteLine("Please enter 20 positive numbers:");

        for (int i = 0; i < 20; i++)
        {
            int number;
            do
            {
                Console.Write((i + 1) + ". number: ");
                number = int.Parse(Console.ReadLine());
            } while (number <= 0);

            allNumbers.Add(number);
        }

        foreach (int num in allNumbers)
        {
            if (IsPrime(num))
                primeNumbers.Add(num);
            else
                nonPrimeNumbers.Add(num);
        }
        primeNumbers.Sort();
        nonPrimeNumbers.Sort();
        double sum1 = 0;
        double sum2 = 0;

        Console.WriteLine(primeNumbers.Count + "\nPrime Numbers:");
        foreach (int n in primeNumbers)
        {
            Console.Write(n + " ");
            sum1 += n;
        }
        Console.WriteLine("\nNumbers of prime numbers: " + primeNumbers.Count );
        Console.WriteLine("Average of prime numbers: " + sum1/primeNumbers.Count);
            

        Console.WriteLine("\n\nNon-Prime Numbers:");
        foreach (int n in nonPrimeNumbers)
        {
            Console.Write(n + " ");
            sum2 += n;
        }
        Console.WriteLine("\nNumbers of non-prime numbers: " + nonPrimeNumbers.Count);
        Console.WriteLine("Average of non-prime numbers: " + sum2 / nonPrimeNumbers.Count);


    }

    static bool IsPrime(int num)
    {
        if (num <= 1)
            return false;

        for (int i = 2; i * 2 <= num; i++)
        {
            if (num % i == 0)
                return false;
        }

        return true;
    }
}
