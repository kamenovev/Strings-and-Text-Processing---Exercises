using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        char[] first = input.Split().First().ToCharArray();
        char[] second = input.Split().Last().ToCharArray();

        int minLenght = Math.Min(first.Length, second.Length);

        int sum = 0;

        for (int i = 0; i < minLenght; i++)
        {
            sum += first[i] * second[i];
        }
        if (first.Length > second.Length)
        {
            
            for (int i = second.Length; i < first.Length; i++)
            {
                sum += first[i];
            }
        }
        if (first.Length < second.Length)
        {
            for (int i = first.Length; i < second.Length; i++)
            {
                sum += second[i];
            }
        }

            Console.WriteLine(sum);
    }
}

