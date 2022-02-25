string a = Console.ReadLine();
string b = Console.ReadLine();
string tmp;

tmp = a;
a = b;
b = tmp;
Console.WriteLine($"a={a}");
Console.WriteLine($"b={b}");
