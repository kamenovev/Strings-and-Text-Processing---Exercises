using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        
        var chars = input.Select(c => (int)c).Select(c => $@"\u{c:x4}");

        string result = string.Concat(chars);

        Console.WriteLine(result);
    }
}

