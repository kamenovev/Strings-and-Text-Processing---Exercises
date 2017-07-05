using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        double n = double.Parse(input.Split().First());
        BigInteger number = BigInteger.Parse(input.Split().Skip(1).First()); // can be bigger number!!
        string numberStr = number.ToString();
       
        List<BigInteger> sumList = new List<BigInteger>();

        for (int i = number.ToString().Length-1; i >=0; i--)
        {
            int num = int.Parse(new string(numberStr[i], 1));

            sumList.Add((BigInteger)(num * Math.Pow(n, Math.Abs(i + 1 - numberStr.Length))));
            //Console.WriteLine(Math.Pow(n, Math.Abs(i + 1 - numberStr.Length)));
        }
        BigInteger sum = new BigInteger(0);
        foreach (BigInteger item in sumList)
            sum += item;
        Console.WriteLine(sum);

    }
}

