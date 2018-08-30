using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fizzbuzz
{
    class Program
    {
        //from 1 to 100 
        //print fizz for any multiple of 3
        //print buzz for and multiple of 5
        //and fizzbuzz for any multiple of 3 & 5
        //perhaps later return to make it multiples of A & B

        static void Main(string[] args)
        {
            string f = "fizz";
            string b = "buzz";

            for (int i = 1; i <= 100; i++)
            {
                string res = "";
                if (i % 3 == 0) { res += f; }
                if (i % 5 == 0) { res += b; }
                Console.WriteLine(i + " " + res);
            }
        }
    }
}
