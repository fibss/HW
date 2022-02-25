int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

if (a == 0 || b == 0 || c == 0)
{
    Console.WriteLine("Введите числа, отличные от нуля");
}
else
{
    double x = (double)(c - b) / a;
    Console.WriteLine(x);
}