double x = Convert.ToInt32(Console.ReadLine());
double y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0)
{
    Console.WriteLine("Точка находится в первой чертверти");
}
if (x < 0 && y > 0)
{
    Console.WriteLine("Точка находится во второй четверти");
}
if (x < 0 && y < 0)
{
    Console.WriteLine("Точка находится в третьй четверти");
}
if (x > 0 && y < 0)
{
    Console.WriteLine("Точка находится в четвертой четверти");
}