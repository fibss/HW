﻿namespace AllHW
{
    static class HW1
    {
        public static void FindResultofDivision(int dividend, int divider, out int resultOfDivision, out int remainderOfTheDivision)
        {
            resultOfDivision = dividend / divider;
            remainderOfTheDivision = dividend % divider;
        }
       public static double DivisionCalculation(double a, double b)
        {
            double result = (5 * a + b * b) / (b - a);
            return result;
        }
        public static void SwapStringValues(string a, string b, out string result1, out string result2)
        {
            result1 = b;
            result2 = a;
        }
        public static double SolveALinearEquation(double a, double b, double c)
        {
            if (a == 0 || b == 0 || c == 0)
            {
                 throw new Exception("Ошибка. Введите числа, отличные от нуля");
            }    
            return (double) (c - b) / a;
        }
        public static string DeriveTheEquationOfAStraightLinePassingThroughTwoPoints(double x1, double x2, double y1, double y2)
        {
            double a = (x2 - x1) / (y2 - y1);
            double b = y2 - a * x2;
            string answer = $"y = {a} * x + { b}";
            return answer;
        }
    }   
}