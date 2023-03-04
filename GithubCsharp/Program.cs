using System;
//using System.Numerics;

namespace GithubCsharp;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter Num1: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Num2: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        NumberToArray(num1, num2);
    }

    static void NumberToArray(int num1, int num2)
    {
        int lengthNum1 = NumberLength(num1); 
        int lengthNum2 = NumberLength(num2);

        // Finding the max length for the max range of array.
        int maxLength = Math.Max(lengthNum1, lengthNum2);
        int[] arrNum1 = new int[maxLength];
        int[] arrNum2 = new int[maxLength];

        // Adding elements in array. Modulo to get the last number
        // and /= to make the number smaller until it become 0.
        for (int i = 0; i < lengthNum1; i++)
        {
            arrNum1[i] = num1 % 10;
            num1 /= 10;
        }

        for (int i = 0; i < lengthNum2; i++)
        {
            arrNum2[i] = num2 % 10;
            num2 /= 10;
        }
        Console.WriteLine("Sum: " + AdditionOfArray(arrNum1, arrNum2, maxLength));       
        
    }
    static int AdditionOfArray(int[] num1, int[]num2, int maxLength)
    {
        string sum = "";
        int[] arrSum = new int[maxLength];
        for (int i = 0; i < maxLength; i++)
        {
            // For carrying values. Use += to make sure all carry numbers will be added.
            // int array default value is 0 so it is safe to use +=.
            int total = num1[i] + num2[i];
            // Check the size and position to make sure all carry numbers and index range are utilized.
            if (total > 9 && i < maxLength - 1)
            {
                arrSum[i] += total % 10;
                arrSum[i + 1] += 1;
            }
            else
            {
                arrSum[i] += total;
            }
        }
        // Reversing the arrSum to print it in order.
        for (int i = maxLength - 1; i >= 0; i--)
        {
            // You can also use += in concatenating string but make sure to use .ToString() method.
            sum += arrSum[i].ToString();
        }
        return Convert.ToInt32(sum);
    }
    static int NumberLength(int num)
    {
        int count;
        for (count = 0; num != 0; count++)
        {
            num /= 10;
        }
        return count;
    }
   
    
}
