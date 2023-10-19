// See https://aka.ms/new-console-template for more information
int number, hunder, ten , one, a,b, c , d, f;
Console.WriteLine("Enter your number three digit number");
number = int.Parse(Console.ReadLine());
hunder = number / 100;
ten = number % 100 / 10;
one = number % 100 % 10;
a = (ten * 100 + one * 10 + hunder);
b = ten * 100 + hunder * 10 + one;
c = hunder * 100 + one * 10 + ten;
d = one * 100 + hunder * 10 + ten;
f = one * 100 + ten * 10 + hunder;


if (a > number & a > b & a > c & a > d & a > f)
{
    Console.WriteLine($"{a} > {number}");
}
else if (b > number & b > a & b > c & b > d & b > f)
{
    Console.WriteLine($"{b} > {number}");
}
else if (c > number & c > b & c > a & c > d & c > f)
{
    Console.WriteLine($"{c} > {number}");
}
else if (d > number & d > b & d > c & d > a & d > f)
{
    Console.WriteLine($"{d} > {number}");
}
else if (f > number & f > b & f > c & f > d & f > a)
{
    Console.WriteLine($"{f} > {number}");
}
else
{
    Console.WriteLine($"Max is {number}");
}