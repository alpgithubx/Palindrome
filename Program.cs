using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 1000000; i++) {
                string str = Convert.ToString(i);
                string rev = "";
                for (int j = str.Length - 1; j >= 0; j--) {
                    string sub = str.Substring(j, 1);
                    rev = rev + sub;
                }
                if (rev == str) {
                    Console.WriteLine($"{str} bir palindrom!");
                }

            }
            Console.ReadLine();
        }
    }
}
