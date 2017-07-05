using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        BigInteger n = BigInteger.Parse(input.Split().First());
        BigInteger number = BigInteger.Parse(input.Split().Skip(1).First()); // can be bigger number!!
        BigInteger current = 1;

        string result = "";

        while (current!=0)
        {
            current = number / n;

            BigInteger remainder = number % n;
            number = current;
            result = result.Insert(0, remainder.ToString());

        }

        Console.WriteLine(result);

    }
}

