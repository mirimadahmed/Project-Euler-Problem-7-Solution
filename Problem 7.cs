//Rextester.Program.Main is the entry point for your code. Don't change it.
//Compiler version 4.0.30319.17929 for Microsoft (R) .NET Framework 4.5

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int count = 0;
            int num = 2;
            while(true){
                if(isPrime(num)) count++;
                if(count == 10001) break;
                num++;
            }
            Console.WriteLine(num);
            //Your code goes here
            Console.WriteLine("Hello, world!");
        }
        
        static bool isPrime(int num){
            for (int i = 2; i < num; i++){
                if(num % i == 0) return false;
            }
            return true;
        }
    }
}