using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

class Program
{
    static void Main()
    {
        BigInteger number = BigInteger.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        List<BigInteger> sumList = new List<BigInteger>();
        for (int i = 0; i < n; i++)
        {
            sumList.Add(number);
        }
        BigInteger sum = 0;
        foreach (BigInteger num in sumList)
        {
            sum += num;
        }
        Console.WriteLine(sum);
    }
}

