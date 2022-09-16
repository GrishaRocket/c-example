Console.Clear();
Console.WriteLine("Введите число А");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число Б");
int b = int.Parse(Console.ReadLine());

if (a == (b * b))
{
    Console.WriteLine("Число " + b + " является квадратом " + a);
}
else
{
    Console.WriteLine("Число " + b + " не является квадратом " + a);
}


