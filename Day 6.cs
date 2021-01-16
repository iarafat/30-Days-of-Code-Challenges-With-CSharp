using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int T = int.Parse(Console.In.ReadLine());
        for (int i = 0; i < T; i++) {
            string S = Console.ReadLine();
            string eventString = "", oddString = "";
            
            
            for (int j = 0; j < S.Length; j++) {
                if (j == 0) {
                    eventString += S[j];
                } else {
                    if (j % 2 == 0) {
                        eventString += S[j];
                    } else {
                        oddString += S[j];
                    }
                }
            }
            
            Console.WriteLine($"{eventString} {oddString}");
        }
    }
}
