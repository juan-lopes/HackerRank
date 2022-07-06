using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    static void Main(String[] args) {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";

        int a;
        double b;
        string c;

        // Read and save an integer, double, and String to your variables.
        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToDouble(Console.ReadLine());
        c = Console.ReadLine();

        // Print the sum of both integer variables on a new line.
        Console.WriteLine(a + i);


        // Print the sum of the double variables on a new line.
        Console.WriteLine("{0:F1}", b + d);
        // Concatenate and print the String variables on a new line
        // The 's' variable above should be printed first.
        Console.WriteLine(s + c);
    }
