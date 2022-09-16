Console.Clear();
Console.WriteLine("Введите число от 1 до 7");

int a = int.Parse(Console.ReadLine());
if (a > 1 && a < 7)

    switch (a)
    {
        case 1:
            Console.WriteLine("понедельник");
            break;
        case 2:
            Console.WriteLine("вторник");
            break;
        case 3:
            Console.WriteLine("среда");
            break;
        case 4:
            Console.WriteLine("четверг");
            break;
        case 5:
            Console.WriteLine("пятница");
            break;
        case 6:
            Console.WriteLine("суббота");
            break;
        case 7:
            Console.WriteLine("Воскресенье");
            break;
        default:
            Console.WriteLine("Неверное число...");
            break;
    }

