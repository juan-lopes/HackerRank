using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;



class Solution
{
    public static void Main(string[] args)
    {
        int N = Convert.ToInt32(Console.ReadLine().Trim());

        if (N >= 2 && N <= 5 && N % 2 == 0)
            NotWeird();
        else if (N >= 6 && N <= 20 && N % 2 == 0)
            Weird();
        else if (N > 20 && N % 2 == 0)
            NotWeird();
        else if (N % 2 != 0)
            Weird();
    }

    public static void Weird()
    {
        Console.WriteLine("Weird");
    }
    public static void NotWeird()
    {
        Console.WriteLine("Not Weird");
    }
}
