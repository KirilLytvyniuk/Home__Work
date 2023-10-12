// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введіть ціну зошита");
int x= int.Parse(Console.ReadLine());
Console.WriteLine(" Введіть ціну ручки");
int y = int.Parse(Console.ReadLine());
Console.WriteLine("Введіть кількість зошитів");
int n = int.Parse(Console.ReadLine());
Console.WriteLine(" Введіть кількість ручок");
int m = int.Parse(Console.ReadLine());
int notes = x * n;
int pencil = y * m;
int suma = notes + pencil;

Console.WriteLine($"Петрику потрібно {suma} гривень. Для  придбання {n} зошитів і {m} ручок. При ціні зошита {x} гривень і ручки {y} гривень");