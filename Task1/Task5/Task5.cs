int a = Convert.ToInt32(Console.ReadLine());
int firstFigure;
int secondFigure;
string firstValue;
string secondValue;

firstFigure = a / 10;
secondFigure = a % 10;

if (firstFigure == 1)
{
    string value = secondFigure switch
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
    Console.WriteLine(value);
}
else if (firstFigure > 1 && firstFigure < 10)
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
    string answer = firstValue + " " + secondValue;
    Console.WriteLine(answer);
}
