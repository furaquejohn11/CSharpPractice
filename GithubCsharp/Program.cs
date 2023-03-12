using System;
using System.Numerics;

namespace GithubCsharp;
class Program
{
    static void Main(string[] args)
        { 
            Console.WriteLine("Make sure to type coefficient especially if it is 0 or 1!");
            int[,] polynomials = new int[3 , 3];
            Console.WriteLine("Enter first polynomial: "); 
            Console.Write("Value of coefficent of x^2: ");
            polynomials[0,0]  = int.Parse(Console.ReadLine());


            Console.Write("Value of coefficent of x: ");
            polynomials[0,1]  = int.Parse(Console.ReadLine());

            Console.Write("Value of last term : ");
            polynomials[0,2]  = int.Parse(Console.ReadLine());


            Console.WriteLine();

            Console.WriteLine("Enter Second polynomial: "); 
            Console.Write("Value of coefficent of x^2: ");
            polynomials[1,0]  = int.Parse(Console.ReadLine());

            Console.Write("Value of coefficent of x: ");
            polynomials[1,1]  = int.Parse(Console.ReadLine());

            Console.Write("Value of last term : ");
            polynomials[1,2]  = int.Parse(Console.ReadLine());
            
            Console.WriteLine(Answer(polynomials));
            
        }
        static string Answer(int[,] polynomials)
        {
            int[] result = new int[3];
            string[] variables = {"x^2", "x", ""};
            string formatted = null;

            for (int i = 0; i < 3; i++)
            {
                result[i] = polynomials[0, i] + polynomials[1, i];
            }

            for (int i = 0; i < 3; i++)
            {
                if (result[i] != 0)
                {
                    if (result[i] > 0 && i >= 1 && i < 3)
                    {
                        formatted += "+" + result[i].ToString() + variables[i];
                    }
                    else
                    {
                        formatted += result[i].ToString() + variables[i];
                    }
                    
                }
            }

            return formatted.Replace("1x", "x");


        }
    
}
