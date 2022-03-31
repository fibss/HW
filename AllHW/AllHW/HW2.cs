namespace AllHW
{
    public static class HW2
    {
        public static int CompareAndCount(int a, int b)
        {
            if (a == b)
            {
                return a * b;
            }
            else if (a > b)
            {
                return a + b;
            }
            else
            {
                return a - b;
            }
        }
        public static string DetermineWhichQuarterAPointBelongsTo(double x, double y)
        {
            if (x > 0 && y > 0)
            {
                return "Точка находится в первой чертверти";
            }
            else if (x < 0 && y > 0)
            {
                return "Точка находится во второй четверти";
            }
            else if (x < 0 && y < 0)
            {
                return "Точка находится в третьей четверти";
            }
            else if (x > 0 && y < 0)
            {
                return "Точка находится в четвертой четверти";
            }
            else
            {
                return "Точка лежит на оси и не принадлежит ни одной из четырёх четвертей";
            }
        }
        public static string DisplayNumbersInAscendingOrder(int a, int b, int c)
        {
            if (a > b && b >= c)
            {
                return $"{c}, {b}, {a}";
            }
            else if (b > a && a >= c)
            {
                return $"{c}, {a}, {b}";
            }
            else if (c > a && a >= b)
            {
                return $"{b}, {a}, {c}";
            }
            else if (c > b && b >= a)
            {
                return $"{a}, {b}, {c}";
            }
            else if (b > c && c >= a)
            {
                return $"{a}, {c}, {b}";
            }
            else
            {
                return $"{b}, {c}, {a}";
            }
        }
        public static double FindTheDiscriminant(double a, double b, double c)
        {
            return b * b - 4 * a * c;
        }
        public static string SolveQuadraticEquation(double a, double b, double c)
        {
            double d;
            d = FindTheDiscriminant(a, b, c);
            if (d > 0)
            {
                double x1 = (-b + Math.Sqrt(d)) / 2 * a;
                double x2 = (-b - Math.Sqrt(d)) / 2 * a;
                return $"{x1}, { x2}";
            }
            else if (d == 0)
            {
                double x = (-b) / (2 * a);
                return $"{x}";
            }
            else
            {
                return "Нет действительных корней";
            }
        }

        public static string WriteATwoDigitNumberInWords(int a)
        {
            int firstFigure;
            int secondFigure;
            string firstValue;
            string secondValue;

            firstFigure = a / 10;
            secondFigure = a % 10;
            string answer;

            if (firstFigure == 1)
            {
                answer = secondFigure switch
                {
                    0 => "десять",
                    1 => "одиннадцать",
                    2 => "двенадцать",
                    3 => "тринадцать",
                    4 => "четырнадцать",
                    5 => "пятнадцать",
                    6 => "шестнадцать",
                    7 => "семнадцать",
                    8 => "восемнадцать",
                    9 => "девятнадцать",
                };
            }
            else
            {
                firstValue = firstFigure switch
                {
                    2 => "двадцать",
                    3 => "тридцать",
                    4 => "сорок",
                    5 => "пятьдесят",
                    6 => "шестьдетсят",
                    7 => "семдесят",
                    8 => "восемдесят",
                    9 => "девяносто",
                };
                secondValue = secondFigure switch
                {
                    1 => "один",
                    2 => "два",
                    3 => "три",
                    4 => "четыре",
                    5 => "пять",
                    6 => "шесть",
                    7 => "семь",
                    8 => "восемь",
                    9 => "девять",
                };
                answer = firstValue + " " + secondValue;
            }
                return answer;
        }














    }
}
