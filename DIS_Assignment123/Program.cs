using System;namespace Assignment1_F19{    class Program    {        static void Main(string[] args)        {










            /*			int a = 1, b = 22;                        printSelfDividingNumbers(a, b);                        int n2 = 5;                        printSeries(n2);            */
            int n3 = 5;            printTriangle(n3);

            /*			int[] J = new int[] { 1, 3 };                        int[] S = new int[] { 1, 3, 3, 2, 2, 2, 2, 2 };                        int r4 = numJewelsInStones(J, S);                        Console.WriteLine(r4);                        int[] arr1 = new int[] { 1, 2, 5, 6, 7, 8, 9 };                        int[] arr2 = new int[] { 1, 2, 3, 4, 5 };                        int[] r5 = getLargestCommonSubArray(arr1, arr2);                        Console.WriteLine(r5);                        solvePuzzle(); */
        }


        /*	public static void printSelfDividingNumbers(int x, int y)            {                try                {                    public IList<int> SelfDividingNumbers(int left, int right)                    {                        var retList = new List<int>();                        for (int i = left; i <= right; i++)                        {                            if (IsSelfDividingNo(i))                                retList.Add(i);                        }                        return retList;                    }                    private static bool IsSelfDividingNo(int i)                    {                        var num = i;// eg 128                        while (num > 1)// > 1, as 1 is always self dividing num.                        {                            var reminder = num % 10; // 128%10 = 8                            if (reminder == 0 || i % reminder != 0) // if reminder is 0 or 128%8!=0  then its not self dividing                            {                                return false;                            }                            num = num / 10;// cropping last digit .                        }                        return true;                    }                }                catch                {                    Console.WriteLine("Exception occured while computing printSelfDividingNumbers()");                }            }            public static void printSeries(int n)            {                try                {                }                catch                {                    Console.WriteLine("Exception occured while computing printSeries()");                }            }    */
        public static void printTriangle(int n3)        {            try            {                for (int i = n3; i >= 1; i--)                {                    for (int j = n3; j > i; j--)                    {                        Console.Write("  ");                    }                    for (int k = 1; k < 2 * i; k++)                    {                        Console.Write("* ");                    }                    Console.WriteLine();                }                Console.ReadLine();            }            catch            {                Console.WriteLine("Exception occured while computing printTriangle()");            }        }    }}