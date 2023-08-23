using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var isOn = true;
            while (isOn)
            {
                Console.WriteLine("Input the string : ");
                var input = Console.ReadLine().ToLower().Replace(" ", "");
                var output = IsPalindrome(input);
                Console.WriteLine($"Is the input is palindrome? : {output}");
                Console.WriteLine("Again?: (y/n)");
                var termination = Console.ReadLine().ToLower().Replace(" ", "");
                if (termination == "n")
                {
                    isOn = false;
                    Console.WriteLine("Bye");
                }
            }

            Console.ReadKey();
        }

        private static bool IsPalindrome(string _input)
        {
            bool isPalindrome = true;
            var length = _input.Length;
            var halfLength = _input.Length / 2;

            for (int i = 0; i < halfLength; i++)
            {
                if (_input[i] != _input[length-1])
                {
                    isPalindrome = false;
                }
                length--;
            }

            return isPalindrome; 
        }
    }
}
