using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    static void Main(String[] args) {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";

        
        // Declare second integer, double, and String variables.
        int intVarTwo; double doubleVarTwo; string stringVarTwo;
        
        // Read and save an integer, double, and String to your variables.
        intVarTwo = Convert.ToInt32(Console.ReadLine());
        doubleVarTwo = Convert.ToDouble(Console.ReadLine());;
        stringVarTwo = Console.ReadLine();
        
        // Print the sum of both integer variables on a new line.
        Console.WriteLine(i + intVarTwo);
        
        // Print the sum of the double variables on a new line.
        Console.WriteLine(String.Format("{0:0.0}", (d + doubleVarTwo)));
    
        
        // Concatenate and print the String variables on a new line
        // The 's' variable above should be printed first.
        Console.WriteLine(s + stringVarTwo);

    }
}
