using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] codes = Regex.Split(input, @"\s+");
        double sum = 0;

        foreach (var code in codes)
        {
            int First = 0;
            switch (code[0].ToString().ToLower())
            {
                case "a": First = 1; break;
                case "b": First = 2; break;
                case "c": First = 3; break;
                case "d": First = 4; break;
                case "e": First = 5; break;
                case "f": First = 6; break;
                case "g": First = 7; break;
                case "h": First = 8; break;
                case "i": First = 9; break;
                case "j": First = 10; break;
                case "k": First = 11; break;
                case "l": First = 12; break;
                case "m": First = 13; break;
                case "n": First = 14; break;
                case "o": First = 15; break;
                case "p": First = 16; break;
                case "q": First = 17; break;
                case "r": First = 18; break;
                case "s": First = 19; break;
                case "t": First = 20; break;
                case "u": First = 21; break;
                case "v": First = 22; break;
                case "w": First = 23; break;
                case "x": First = 24; break;
                case "y": First = 25; break;
                case "z": First = 25; break;
                default:
                    break;
            }
            int middleNum = int.Parse(code.Remove(0, 1).Remove(code.Length - 2, 1));

            if (Char.IsUpper(code[0]))
            {
                sum += middleNum / First;
            }
            else
            {
                sum += middleNum * First;
            }
            int Last = 0;
            switch (code[0].ToString().ToLower())
            {
                case "a": Last = 1; break;
                case "b": Last = 2; break;
                case "c": Last = 3; break;
                case "d": Last = 4; break;
                case "e": Last = 5; break;
                case "f": Last = 6; break;
                case "g": Last = 7; break;
                case "h": Last = 8; break;
                case "i": Last = 9; break;
                case "j": Last = 10; break;
                case "k": Last = 11; break;
                case "l": Last = 12; break;
                case "m": Last = 13; break;
                case "n": Last = 14; break;
                case "o": Last = 15; break;
                case "p": Last = 16; break;
                case "q": Last = 17; break;
                case "r": Last = 18; break;
                case "s": Last = 19; break;
                case "t": Last = 20; break;
                case "u": Last = 21; break;
                case "v": Last = 22; break;
                case "w": Last = 23; break;
                case "x": Last = 24; break;
                case "y": Last = 25; break;
                case "z": Last = 25; break;
                default:
                    break;
            }

            if (Char.IsUpper(code[0]))
            {
                sum += (middleNum - Last);
            }
            else
            {
                sum += (middleNum + Last);
            }

            Console.WriteLine(sum);

            //foreach (var c in codes)
            //{
            //    Console.WriteLine(c);
            //}
        }
    }
}


