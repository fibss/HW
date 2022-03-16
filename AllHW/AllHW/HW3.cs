using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllHW
{
    static class HW3
    {
        public static double RaiseANumberToAPower(double a, double b)
        {
            if (b <= 0)
            {
                throw new Exception("B should be > 0");
            }

            double result = 1;
            if (b < 0)
            {
                a = 1 / a;
                b *= -1;
            }

            for (int i = 1; i <= b; i++)
            {
                result *= a;
            }
            return result;
        }

        public static int[] FindNumbersThatAreDivisibleByTheNumberEnteredByTheUserFromTheRangeFrom1To1000(int a)
        {
            int count = 0;
            int tmp = 0;

            if (a <= 0)
            {
                throw new Exception(" A must be > 0");
            }
            else for (int i = 1; i <= 1000; i++)
            {
                if (a % i == 0)
                {
                    count++; 
                }
            }
            int [] array = new int[count];
            for (int i = 1; i < 1000; i++)
            {
                if (a%i== 0)
                {
                    array[tmp] = i;
                    tmp++;
                }

            }
            return array;
        }

        public static int FindTheNumberOfNumbersWhoseSquareIsLessThanA(int a)
        {
            if (a <= 0)
            {
                throw new Exception(" A must be > 0");
            }

            int tmp = 1;

            while (tmp * tmp < a)
            {
                tmp++;
            }
            return tmp;
        }

        public static int FindTheLargestDivisor (int a)
        {
            if (a <= 0)
            {
                throw new Exception(" A must be > 0");
            }

            int divider = a - 1;

            if (a % 2 == 0)
            {
                divider = a / 2;
            }
            else
            {
                while (a % divider != 0)
                {
                    divider--;
                }
            }
            return divider;
        }

        public static int FindTheSumOfElementsThatAreDivisibleBySeven(int a, int b)
        {
            int sumOfNumbers = 0;
            if (b < a)
            {
                int tmp;
                tmp = a;
                a = b;
                b = tmp;
            }

            for (int i = a; i <= b; i++)
            {
                if (i % 7 == 0)
                {
                    sumOfNumbers += i;
                }
            }
            return sumOfNumbers;
        }

        public static int FindTheNthNumberOfTheFibonacciSeries(int n)
        {
            if (n <= 0)
            {
                throw new Exception("N must be > 0");
            }

            int a = 1;
            int b = 1;
            int nextNumber = 0;

            for (int i = 1; i < n; i++)
            {
                nextNumber = a + b;
                a = b;
                b = nextNumber;
            }
            return nextNumber;
        }

        public static int FindGCDUsingEuclideanAlgorithm(int a, int b)
        {
            if (a <= 0 || b <= 0)
            {
                throw new Exception("A and B should be > 0");
            }

            int gcd;

            while (a != 0 && b != 0)
            {
                if (a > b)
                {
                    a %= b;
                }
                else
                {
                    b %= a;
                }
            }
            gcd = a + b;
            return gcd;
        }

        public static int FindRootOfANamberUsingTheHalfDivisionMetod(int number) 
        {
            if (number <= 0)
            {
                throw new Exception(" number must be > 0");
            }

            int a = 0;
            int b = number;
            int half = 0;

            while (half * half * half != number)
            {
                half = (a + b) / 2;
                if (half * half * half < number)
                {
                    a = half;
                }
                else
                {
                    b = half;
                }
            }
            return half;
        }

        public static int FindNumberOfOddDigits(int a)
        {
            if (a <= 0)
            {
                throw new Exception("A must be > 0");
            }

            int tmp;
            int count = 0;
            while (a != 0)
            {
                tmp = a % 10;
                if (tmp % 2 != 0)
                {
                    count++;
                }
                a /= 10;
            }
            return count;
        }

        public static int PrintNumberInReverse(int a)
        {
            if (a <= 0)
            {
                throw new Exception("A must be > 0");
            }

            int tmp;
            int NewNum = 0;

            while (a != 0)
            {
                tmp = a % 10;
                NewNum *= 10;
                NewNum += tmp;
                a /= 10;
            }
            return NewNum;
        }
        public static int FindEvenNumber(int n)
        {
            int decade;
            int countEven = 0;

            for (int i = 0; i < n; i++)
            {
                int tmp = i;
                int summEven = 0;
                int summOdd = 0;

                while (tmp != 0)
                {
                    decade = tmp % 10;
                    if (tmp % 2 == 0)
                    {
                        summEven += decade;
                    }
                    else
                    {
                        summOdd += decade;
                    }
                    tmp /= 10;
                }

                if (summEven > summOdd)
                {
                    countEven++;
                }
            }
            return countEven;
        }

        public static int[] GetNumWithMostEvenDigits(int n)
        {
            if (n < 0)
            {
                throw new Exception("N must be > 0");
            }

            int countEven = FindEvenNumber(n);
            int decade;
            int[] array = new int[countEven];
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                int tmp = i;
                int summEven = 0;
                int summOdd = 0;

                while (tmp != 0)
                {
                    decade = tmp % 10;
                    if (tmp % 2 == 0)
                    {
                        summEven += decade;
                    }
                    else
                    {
                        summOdd += decade;
                    }
                    tmp /= 10;
                }
                if (summEven > summOdd)
                {
                    array[count] = i;
                    count++;
                }
            }
            return array;
        }

        public static bool FindOutIdenticalNum(int a, int b)
        {
            if (a <= 0 || b <= 0)
            {
                throw new Exception("A and B should be >0");
            }

            int tmp1 = 0;
            int tmp2 = 0;
            bool res = false;

            while (a != 0)
            {
                tmp1 = a % 10;

                for (int i = b; i != 0; i /= 10)
                {
                    tmp2 = i % 10;
                    if (tmp1 == tmp2)
                    {
                        res = true;
                    }
                }
                a /= 10;
            }
            return res;
        }
    }
}

