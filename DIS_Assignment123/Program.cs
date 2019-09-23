using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
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
            Console.WriteLine("The number of Jewels in Stones is: {0}",r4);

            Console.WriteLine("Question 5");
            int[] arr1 = new int[] { 1, 2, 5, 6, 7, 8, 9 };
            int[] arr2 = new int[] { 1, 2, 3, 4, 5 };
            int[] r5 = getLargestCommonSubArray(arr1, arr2);
            Console.Write("The Largest Common SubArray is: ");
            Console.WriteLine("[{0}]", string.Join(", ", r5));

            Console.WriteLine("Question 6");
            solvePuzzle();
            Console.ReadKey();

        }
        public static void printSelfDividingNumbers(int x, int y)
        {
            try
            {
                
                /* This is to find Self Dividing Numbers in the range x to y when we run a for loop
                   Staring from x till y to call isSelfDiving function which checks if the number is Self Dividing */
                for (int i = x; i <= y; i++)
                {
                    SelfDivisionTest(i);
                }
            }

            catch
            {
                Console.WriteLine("Exception occured while computing printSelfDividingNumbers()");
                
            }
        }
        public static void SelfDivisionTest(int x)
        {
            try
            {
                int number = x;
                while (number != 0)
                {
                    int left_digit = number % 10;
                    if (left_digit == 0 || x % left_digit != 0)// if the remainder comes 0 or 128%8!=0  then its not a self dividing number
                    {
                        break;
                    }
                    number = number / 10;// cropping/removing the last digit 
                    if (number == 0)
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
                        Console.Write(i+" ");
                    }
                }
                Console.WriteLine();

            }
            catch
            {
                Console.WriteLine("Error in printSeries()");
            }
        }
        public static void printTriangle(int n3)
        {
            {                for (int i = n3; i >= 1; i--)                {                    for (int j = n3; j > i; j--)                    {                        Console.Write("  ");                    }                    for (int k = 1; k < 2 * i; k++)                    {                        Console.Write("* ");                    }                    Console.WriteLine();                }                Console.ReadLine();            }
        }
        public static int numJewelsInStones(int[] J, int[] S)
        {
            int count = 0;
            for(int i=0;i<J.Length;i++)
            {
                for(int j=0;j<S.Length;j++)
                {
                    if ( S[j]== J[i])
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        public static int[] getLargestCommonSubArray(int[] smaller, int[] larger)
        {
            try
            {
                if (smaller.Length > larger.Length)
                {
                    int[] buf = larger;
                    larger = smaller;
                    smaller = buf;
                }
                List<int> return_val = new List<int>();
                int len_s = smaller.Length;
                int len_l = larger.Length;
                for (int i = 0; i < len_s; i++)
                {
                    List<int> buf1 = new List<int>();
                    for (int j = 0; j < len_l; j++)
                    {
                        if (smaller[i] == larger[j])
                        {
                            for (int k = 0; k < (len_s - i); k++)
                            {
                                if (smaller[i + k] == larger[j + k])
                                {
                                    buf1.Add(smaller[i + k]);
                                }
                                else
                                {
                                    break;
                                }
                            }
                            if (buf1.ToArray().Length >= return_val.ToArray().Length)
                            {
                                return_val = buf1;
                                buf1 = new List<int>();
                            }
                        }
                    }
                }
                return return_val.ToArray();
            }
            catch
            {
                Console.WriteLine("Exception occured while computing getLargestCommonSubArray()");
            }

            return null; 
        }

        public static void solvePuzzle()
        {
            try
            {
                Console.WriteLine("Enter First String : ");
                string str1 = Console.ReadLine();
                str1 = str1.ToLower();
                int str1len = str1.Length;
                Console.WriteLine("Enter Second String : ");
                string str2 = Console.ReadLine();
                str2 = str2.ToLower();
                int str2len = str2.Length;
                Console.WriteLine("Enter Third String : ");
                string str3 = Console.ReadLine();
                str3 = str3.ToLower();
                int str3len = str3.Length;
                string concatstr = str1.ToLower() + str2.ToLower() + str3.ToLower();
                var set_unique = new HashSet<char>(concatstr.ToArray());

                char[] unique_all = set_unique.ToArray();
                
                int infi = 1;
                
                while (infi == 1)
                {

                    int[] assign = genRandom(unique_all);
                    while (assign[Array.IndexOf(unique_all, str1[0])] == 0 || assign[Array.IndexOf(unique_all, str2[0])] == 0)
                    {
                        assign = genRandom(unique_all);
                    }
                    double val1 = SumofAssigned(str1.ToLower(), unique_all, assign);
                    double val2 = SumofAssigned(str2.ToLower(), unique_all, assign);
                    double val3 = SumofAssigned(str3.ToLower(), unique_all, assign);
                    if (val1 + val2 == val3)
                    {
                        Console.WriteLine("[{0}]", string.Join(", ", unique_all));
                        Console.WriteLine("[{0}]", string.Join(", ", assign));
                        Console.Write("Assigned value of {0}: ",str1); Console.Write(val1); Console.WriteLine();
                        Console.Write("Assigned value of {0}: ", str2); Console.Write(val2); Console.WriteLine();
                        Console.Write("Assigned value of {0}: ", str3); Console.Write(val3); Console.WriteLine();
                        break; // breaks the loop when finds the value
                    }
                }
                Console.ReadKey();

            }
            catch (Exception e)
            {

                Console.WriteLine(e);
                Console.ReadLine();
            }
        }
        
        public static int[] genRandom(char[] unique)
        {
            Random random = new Random();
            HashSet<int> randomAssignments = new HashSet<int>();
            for (int i = 0; i < unique.Length; i++) // Found it on stack overflow
            {
                while (!randomAssignments.Add(random.Next(0, 10))) ;
            }
            return randomAssignments.ToArray();
        }

        public static double SumofAssigned(string s, char[] unique, int[] assignment)
        {

            try
            {
                int len = s.Length;
                double sum = 0;
                for (int i = 0; i < len; i++)
                {

                    sum += assignment[Array.IndexOf(unique, s[i])] * Math.Pow(10, len - 1 - i);
                }

                return sum;
            }
            catch
            {
                Console.WriteLine("Error Occured ");
                return 0
            }



        }
    }

}
/*
Self Reflection:This coding exercise was really exhaustive and made me more comfortable with the C# syntax and error handling. The following aspects of coding was comprehensively covered:1.	Local & Global Parameters2.	Object Oriented Programming3.	Use of Arrays and Lists4.	Using Loops5.	Try and Catch cases for exception handling6.	DebuggingQuestion 6 was a real challenge and the puzzle took multiple iterations of re-coding and debugging
*/
