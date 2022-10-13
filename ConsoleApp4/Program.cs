using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{

    class Program
    {
        /// <summary>
        /// Return true if sum odd
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static bool TrySumIfOdd (int a, int b)
        {
            if ( (a+b) % 2 == 0)
                return true;

            else return false;
        }

        /// <summary>
        /// Return max value
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static int MaxValue(int a, int b)
        {

            if (a > b) return a;

            else if (a < b) return b;

            else return a;

        }

        static int MaxValue(int a, int b, int c)
        {
            int max = MaxValue(a,b);

            if (max > c) return max;

            else return c;
        }

        static int MaxValue(int a, int b, int c, int d)
        {
            int max = MaxValue(a, b, c);

            if (max > d) return max;

            else return d;

        }

        /// <summary>
        /// Return min value
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static int MinValue(int a, int b)
        {

            if (a < b) return a;

            else if (a > b) return b;

            else return a;

        }

        static int MinValue(int a, int b, int c)
        {
            int min = MinValue (a, b);

            if (min < c) return min;

            else return c;
            
        }


        static int MinValue(int a, int b, int c , int d)
        {
            int min = MinValue(a, b, c);

            if (min < d) return min;

            else return d;

        }


        static string reapeter(string x, int n) 
        {
            string str =x;
            for (int i = 1; i < n; i++) 
                str+=x;

            return str;
        }


        static void Main(string[] args)
        {
            Random random = new Random();
            int num1 = random.Next()% 100;
            int num2 = random.Next()% 100;
            int num3 = random.Next()% 100;
            int num4 = random.Next()% 100;


            Console.WriteLine($"Numbers: {num1}, {num2}, {num3}, {num4}");



            Console.WriteLine($"Max value is {MaxValue(num1, num2, num3, num4)}");
            Console.WriteLine($"Min value is {MinValue(num1, num2, num3, num4)}");





            Console.WriteLine($"Sum is odd ? {TrySumIfOdd(num1, num2)}");



            Console.WriteLine($"Input string: ");
            string str = Console.ReadLine();

            Console.WriteLine($"How much repeate?: ");
            string temp = Console.ReadLine();
            int n = Convert.ToInt32(temp);
            Console.WriteLine(reapeter(str,n));



        }
    }
}
