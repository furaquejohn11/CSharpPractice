using System;
using System.Numerics;

namespace GithubCsharp;
class Program
{    
    static void Main(string[] args)
    {
        int input;
        BigInteger num = 1;
        do
        {
            Console.Write("Input Number From 1-100: ");
            input = int.Parse(Console.ReadLine());
        } while (input <= 0 || input > 100);
              
        while (input != 0)
        {
            num *= input;
            input--;
        }
        
        Console.WriteLine(num);
    }
    
}
