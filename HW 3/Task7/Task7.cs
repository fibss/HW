int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int tmp;

if (b > a)
{
    tmp = b;
    b = a;
    a = tmp;
}
while (b != 0)
{
    tmp = b;
    b = a % b;
    a = tmp;
}
    Console.WriteLine(a);