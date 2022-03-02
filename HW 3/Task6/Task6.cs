int n = Convert.ToInt32(Console.ReadLine());
int a = 1;
int b = 1;
int nextNumber = 0;

for (int i = 1; i < n; i++)
{
    nextNumber = a + b;
    a = b;
    b = nextNumber;
}
Console.WriteLine(nextNumber);