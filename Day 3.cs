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

class Solution {
    static void Main(string[] args) {
        int N = Convert.ToInt32(Console.ReadLine());
        string result;
        
        if(N % 2 == 0) {
            if (N < 6) {
                result = "Not Weird";
            } else if (N < 21) {
                result = "Weird";
            } else {
                result = "Not Weird";
            }
        } else {
            result = "Weird";
        }
        Console.WriteLine(result);
    }
}