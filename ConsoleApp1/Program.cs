Console.WriteLine("Выберите операцию:");
int oper = 0;
    while (oper != 9)
{
    Console.WriteLine("Сложение двух чисел - 1");
    Console.WriteLine("Вычесть из первого числа второе - 2");
    Console.WriteLine("Перемножить два числа - 3");
    Console.WriteLine("Деление первого числа на второе - 4");
    Console.WriteLine("Возвести в степень N первое число - 5");
    Console.WriteLine("Найти квадратный корень числа - 6");
    Console.WriteLine("Найти 1 процент числа - 7");
    Console.WriteLine("Найти факториал числа - 8");
    Console.WriteLine("Чтоб выйти из программы введите - 9");
    oper = Convert.ToInt32(Console.ReadLine());
    if (oper == 1)
    {
        Console.WriteLine("Ведите первое число:");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ответ:");
        Console.WriteLine(a + b);
        Console.WriteLine();
        Console.WriteLine("Выберите операцию:");
    }
    if (oper ==2)
    {
        Console.WriteLine("Ведите первое число:");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ответ:");
        Console.WriteLine(a - b);
        Console.WriteLine();
        Console.WriteLine("Выберите операцию:");
    }
    if (oper == 3) 
    {
        Console.WriteLine("Ведите первое число:");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ответ:");
        Console.WriteLine(a * b);
        Console.WriteLine();
        Console.WriteLine("Выберите операцию:");
    }
    if (oper == 4) 
    {
        Console.WriteLine("Ведите первое число:");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число");
        int b = Convert.ToInt32(Console.ReadLine());
        if (b == 0)
        {
            Console.WriteLine("Делить на 0 нельзя");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Ответ:");
            Console.WriteLine(a / b);
            Console.WriteLine();
        }
        Console.WriteLine("Выберите операцию:");
    }
    if (oper == 5) 
    {
        Console.WriteLine("Ведите первое число:");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите N");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ответ:");
        Console.WriteLine(Math.Pow(a, n));
        Console.WriteLine();
        Console.WriteLine("Выберите операцию:");
    }
    if (oper == 6)
    {
        Console.WriteLine("Ведите первое число:");
        int a = Convert.ToInt32(Console.ReadLine());
        if (a < 0)
        {
            Console.WriteLine("Нет решения");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Ответ:");
            Console.WriteLine(Math.Sqrt(a));
            Console.WriteLine();
            Console.WriteLine("Выберите операцию:");
        }
    }
    if (oper == 7) 
    {
        Console.WriteLine("Ведите первое число:");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ответ:");
        Console.WriteLine(a / 100);
        Console.WriteLine();
        Console.WriteLine("Выберите операцию:");
    }
    if (oper == 8)
    {
        Console.WriteLine("Ведите первое число:");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = 0;
        int c = 1;
        while (b != a)
        {
            b++;
            c *= b;
        }
        Console.WriteLine("Ответ:");
        Console.WriteLine(c);
        Console.WriteLine();
        Console.WriteLine("Выберите операцию:");
    }
}