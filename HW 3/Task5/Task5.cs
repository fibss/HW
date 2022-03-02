int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
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
   if (i%7 == 0)
    {
        sumOfNumbers += i;
    } 
}
Console.WriteLine(sumOfNumbers);