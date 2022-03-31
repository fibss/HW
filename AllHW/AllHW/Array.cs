using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllHW
{
    internal class Array
    {
        public static int[] CreateAnArrayWithRandom(int count)
        {
            if (count < 0)
            {
                throw new Exception("lenght must be > 0");
            }

            Random random = new Random();
            int[] array = new int[count];

            for (int i = 0; i < count; i++)
            {
                array[i] = random.Next(-100, 100);
            }
            return array;
        }

        public static void OutputAnArrayToTheConsole(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }

        public static int[] CopyArray(int[] a)
        {
            int[] newArray = new int[a.Length];
            Array.Copy(a, newArray, a.Length);
            return newArray;
        }

        private static int Copy(int[] a, int[] newArray, int length)
        {
            throw new NotImplementedException();
        }


        public static int FindMinNumb(int count)
        {
            int[] arr = CreateAnArrayWithRandom(count);

            if (arr.Length == 0)
            {
                throw new Exception("array has no elements");
            }

            int min = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            return min;
        }

        public static int FindMaxNum(int count)
        {
            int[] arr = CreateAnArrayWithRandom(count);

            if (arr.Length == 0)
            {
                throw new Exception("array has no elements");
            }

            int max = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }

        public static int FindIndexMinNum(int count)
        {
            int[] arr = CreateAnArrayWithRandom(count);

            if (arr.Length == 0)
            {
                throw new Exception("array has no elements");
            }

            int indexMin = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < arr[indexMin])
                {
                    indexMin = i;
                }
            }
            return indexMin;
        }

        public static int FindIndexMaxNum(int count)
        {
            int[] arr = CreateAnArrayWithRandom(count);

            if (arr.Length == 0)
            {
                throw new Exception("array has no elements");
            }

            int indexMax = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > arr[indexMax])
                {
                    indexMax = i;
                }
            }
            return indexMax;
        }

        public static int CalculateSumNumWithOddIndex(int count)
        {
            int[] arr = CreateAnArrayWithRandom(count);

            if (arr.Length == 0)
            {
                throw new Exception("array has no elements");
            }

            int sum = 0;

            for (int i = 1; i < arr.Length; i+=2)
            {
                sum += arr[i];
            }
            return sum;
        }

    }
}
