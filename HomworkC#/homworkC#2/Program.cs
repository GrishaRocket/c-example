Console.Clear();
Console.WriteLine("Введите число А");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B");
int b = int.Parse(Console.ReadLine());
if (a < b)
{
    Console.WriteLine("Число" + a + ("Меньшее число"));
    Console.WriteLine("Число" + b + ("Большее число"));
};
if (b < a)
{
    Console.WriteLine("Число" + b + ("Меньшее число"));
    Console.WriteLine("Число" + a + ("Большее число"));
};
