using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asgn
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 22;
            Console.WriteLine("Question 1");
            printSelfDividingNumbers(a, b);

            Console.WriteLine("Question 2");
            int n2 = 5;
            printSeries(n2);

            Console.WriteLine("Question 3");
            int n3 = 5;
            printTriangle(n3);

            Console.WriteLine("Question 4");
            int[] J = new int[] { 1, 3, 5 };
            int[] S = new int[] { 1, 3, 3, 5, 2, 2, 2, 2, 2 };
            int r4 = numJewelsInStones(J, S);
            Console.WriteLine(r4);

            Console.WriteLine("Question 5");
            int[] arr1 = new int[] { 1, 2, 5, 6, 7, 8, 9, 10, 11 };
            int[] arr2 = new int[] { 1, 2, 3, 4, 5, 8, 8, 9 };
            int[] r5 = getLargestCommonSubArray(arr1, arr2);
            Console.Write("The Largest Common SubArray is: ");
            Console.WriteLine("[{0}]", string.Join(", ", r5));

            Console.WriteLine("Question 6 .... \n");
            solvePuzzle();
            Console.ReadKey();

        }
        public static void printSelfDividingNumbers(int x, int y)
        {
            try
            {
                if (x > y)
                {
                    throw new Exception();
                }
                /* To find Self Dividing Numbers in the range x to y we run a for loop
                 * staring from x till y to call isSelfDiving function which checks if the number is Self Dividing */
                for (int i = x; i <= y; i++)
                {
                    isSelfDividing(i);
                }
            }

            catch
            {
                Console.WriteLine("Exception occured while computing printSelfDividingNumbers()");
                if (x > y)
                {
                    Console.WriteLine("Cannot Compute because x = " + x + " is greater than y = " + y);
                }
            }
        }
        public static void isSelfDividing(int x)
        {
            try
            {
                int num = x;
                while (num != 0)
                {
                    int ldigit = num % 10;
                    if (ldigit == 0 || x % ldigit != 0)
                    {
                        break;
                    }
                    num = num / 10;
                    if (num == 0)
                    {
                        Console.WriteLine("{0}", x);
                    }
                }
            }
            catch
            {
                Console.WriteLine("Error occured in isSelfDividing()");

            }
        }
        public static void printSeries(int x)
        {
            try
            {
                for (int i = 1; i <= x; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.WriteLine(i);
                    }
                }

            }
            catch
            {
                Console.WriteLine("Error in printSeries()");
            }
        }
        public static void printTriangle(int x)
        {
            int c = x;
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < (2 * c) - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                c--;
            }
        }
        public static int numJewelsInStones(int[] J, int[] S)
        {
            int count = 0;
            foreach (int number1 in J)
            {
                foreach (int number2 in S)
                {
                    if (number1 == number2)
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        public static int[] getLargestCommonSubArray(int[] a, int[] b)
        {
            try
            {
                if (a.Length > b.Length)
                {
                    int[] temper = b;
                    b = a;
                    a = temper;
                }
                List<int> final = new List<int>();
                for (int i = 0; i < a.Length; i++)
                {
                    List<int> temp = new List<int>();
                    for (int j = 0; j < b.Length; j++)
                    {
                        if (a[i] == b[j])
                        {
                            for (int k = 0; k < (a.Length - i); k++)
                            {
                                if (a[i + k] == b[j + k])
                                {
                                    temp.Add(a[i + k]);
                                }
                                else
                                {
                                    break;
                                }
                            }
                            if (temp.ToArray().Length >= final.ToArray().Length)
                            {
                                final = temp;
                                temp = new List<int>();
                            }
                        }
                    }
                }
                return final.ToArray();
            }
            catch
            {
                Console.WriteLine("Exception occured while computing getLargestCommonSubArray()");
            }

            return null; // return the actual array
        }

        public static void solvePuzzle()
        {
            try
            {
                Console.WriteLine("Enter First String : ");
                String str1 = Console.ReadLine();
                int str1len = str1.Length;

                Console.WriteLine("Enter Second String : ");
                String str2 = Console.ReadLine();
                int str2len = str2.Length;
                Console.WriteLine("Enter Third String : ");
                String str3 = Console.ReadLine();
                int str3len = str3.Length;
            }
            catch
            {
                Console.WriteLine("Error in solvePuzzle() Method");
            }

        }
    }
}