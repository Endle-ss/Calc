Console.WriteLine("Выберите программу которую хотите запустить:");
int prog = 0;
while (prog != 4)
{
    Console.WriteLine();
    Console.WriteLine("1 - Угадай число ");
    Console.WriteLine("2 - Таблица умножения ");
    Console.WriteLine("3 - Вывести делители числа ");
    Console.WriteLine("4 - Закрыть программу ");
    prog = Convert.ToInt32(Console.ReadLine());
    if (prog == 1)
    {
        Console.WriteLine("Попробуй угадать число");
        Random rand = new Random();
        int a = rand.Next(100);
        int b = 0;
        while (a != b)
        {
            b = Convert.ToInt32(Console.ReadLine());
            if (b > 0 && b < 101);
            {
                if (b < a)
                {
                    Console.WriteLine("Надо больше");
                }
                if (b > a)
                {
                    Console.WriteLine("Надо меньше");
                }
                if (b == a)
                {
                    Console.WriteLine("Угадал!");
                    Console.WriteLine();
                }
            }
        }
    }
    if (prog == 2)
    {
        var mat = new int[10, 10];
        for (int i = 0; i < 10; ++i)
        {
            for (int j = 0; j < 10; ++j)
            {
                mat[i, j] = i * j;
            }
        }
        for (int i = 0; i < 10; ++i)
        {
            for (int j = 0; j < 10; ++j)
            {
                Console.Write("{0, 10}", mat[i, j]);
            }
            Console.WriteLine();
        }
    }
    if (prog == 3)
    {
        Console.WriteLine("Введите число:");
        int numer = Convert.ToInt32(Console.ReadLine());
        int delitel = 0;
        Console.Write("Делители: ");
        while (delitel != numer)
        {
            delitel++;
            if (numer % delitel == 0)
            {
                Console.Write(delitel + ", ");
            }
        }
    }
}