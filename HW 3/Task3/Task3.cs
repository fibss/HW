int a = Convert.ToInt32(Console.ReadLine());
int tmp = 1;

while (tmp * tmp < a)
{
    tmp++;
}
Console.WriteLine(tmp - 1);