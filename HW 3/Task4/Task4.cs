int a = Convert.ToInt32(Console.ReadLine());
int divider = a-1;

if (a % 2 == 0)
{
    divider = a / 2;
}
else
{
    while (a%divider != 0)
    {
        divider--;
    }
}
Console.WriteLine(divider);