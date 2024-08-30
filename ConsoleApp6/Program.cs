using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static int  SumOfDigits(int number) // Function to return the sum of the Digits
        {
            int sum=0; //declare int varible sum setting it to 0 
            while (number > 0) // while the number is greater than zero
            {
                int digit = number % 10;// This line extracts the last digit of number using oprator "%" to store the "digit" variable 
                sum += digit;// adds the digit to th sum variable 
                number /= 10;// Removes the lsat digit to sum variable
            }
            return sum;// Once the loop has finished, the function returns the "sum" varible which contains the calculated sum of the digits.
        }
        static void Main()// This is the entry point of the program.
        {
            Console.Write("Enter an integer: ");// This ask user for user integer input.
            int number = int.Parse(Console.ReadLine());//reading user input and switching it to a int and storing it in the number variable

            int result = SumOfDigits(number);// SumOfDigits assigns it return value to the result variable
            Console.Write("The sum of the digits is: " + result);// this display the final sum of Digits.
            Console.ReadLine();// Readline keeps the console window open until the user presses enter
        }
    }
}