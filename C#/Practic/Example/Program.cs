Console.Clear();
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());
int b = 0;
if (a > 0)
{
    b = -a;
}
else
{
    b = a;
    a = a * -1;
}
while (b <= a)
{
    Console.Write(b + ",");
    b = b + 1;
}
Console.WriteLine();

