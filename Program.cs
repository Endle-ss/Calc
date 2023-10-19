ConsoleKeyInfo key;
int days = 16;
DateTime date = new DateTime(2023, 10, 16);
Console.WriteLine(date.ToShortDateString());
int pos = 1;
do
{
    Console.SetCursorPosition(0, pos);
    Console.WriteLine("->");

    key = Console.ReadKey();

    Console.SetCursorPosition(0, pos);
    Console.WriteLine("  ");

    if (key.Key == ConsoleKey.UpArrow && pos != 1)
        pos--;
    else if (key.Key == ConsoleKey.DownArrow && pos != 2)
        pos++;
    if (key.Key == ConsoleKey.LeftArrow)
    {
        Console.SetCursorPosition(0, pos);
        Console.Clear();
        date = date.AddDays(-1);
        days--;
        Console.WriteLine(date.ToShortDateString());
    }
    if (key.Key == ConsoleKey.RightArrow)
    {
        Console.SetCursorPosition(0, pos);
        Console.Clear();
        date = date.AddDays(1);
        days++;
        Console.WriteLine(date.ToShortDateString());
    }
    if (days == 11)
    {
        Console.SetCursorPosition(0, 1);
        Console.WriteLine("   1. Не сделать практическую вовремя");
        Console.WriteLine("   2. Хотябы прийти на пары");
        if (pos == 1)
        {
            if (key.Key == ConsoleKey.Enter)
            {
                Console.Clear();
                Console.WriteLine("Я должен сделать практическую(по возможности)");
                Console.WriteLine(date);
                Console.WriteLine("Подробнее: НАПИСАТЬ ХОТЬ ЧТО ТО РАБОТАЮЩЕЕ(");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine(date.ToShortDateString());
            }
        }
        if (pos == 2)
        {
            if (key.Key == ConsoleKey.Enter)
            {
                Console.Clear();
                Console.WriteLine("Прийти на пары");
                Console.WriteLine(date);
                Console.WriteLine("Подробнее: хотябы на одну");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine(date.ToShortDateString());
            }
        }
    }
    if (days == 18)
    {
        Console.SetCursorPosition(0, 1);
        Console.WriteLine("   1. Поесть в 2 часа");
        if (pos == 1)
        {
            if (key.Key == ConsoleKey.Enter)
            {
                Console.Clear();
                Console.WriteLine("Суп в холодильнике");
                Console.WriteLine(date);
                Console.WriteLine("Подробнее: Разогреть в микроволновке, поесть, помыть за собой");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine(date.ToShortDateString());
            }
        }
    }
    if (days == 20)
    {
        Console.SetCursorPosition(0, 1);
        Console.WriteLine("   1. Поиграть");
        if (pos == 1)
        {
            if (key.Key == ConsoleKey.Enter)
            {
                Console.Clear();
                Console.WriteLine("Сыграть в игру");
                Console.WriteLine(date);
                Console.WriteLine("Забрать ежедневный подарок");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine(date.ToShortDateString());
            }
        }
    }
    if (days == 28)
    {
        Console.SetCursorPosition(0, 1);
        Console.WriteLine("   1. Погулять");
        Console.WriteLine("   2. Купить дошик в магазе");
        if (pos == 1)
        {
            if (key.Key == ConsoleKey.Enter)
            {
                Console.Clear();
                Console.WriteLine("Потрогать траву");
                Console.WriteLine(date);
                Console.WriteLine("Подробнее: Стать болле социальным(а хотя...)");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine(date.ToShortDateString());
            }
        }
    }
    if (days == 30)
    {
        Console.SetCursorPosition(0, 1);
        Console.WriteLine("   1. Сдать практос в последний день");
        if (pos == 1)
        {
            if (key.Key == ConsoleKey.Enter)
            {
                Console.Clear();
                Console.WriteLine("Если практос сделан то сдать");
                Console.WriteLine(date);
                Console.WriteLine("Подробнее: пушить в гитхаб");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine(date.ToShortDateString());
            }
        }
    }
    if (days == 14)
    {
        Console.SetCursorPosition(0, 1);
        Console.WriteLine("   1. Попрыгать на скакалке");
        if (pos == 1)
        {
            if (key.Key == ConsoleKey.Enter)
            {
                Console.Clear();
                Console.WriteLine("Скакалка");
                Console.WriteLine(date);
                Console.WriteLine("Подробнее: стать сильнее");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine(date.ToShortDateString());
            }
        }
    }
}
while (key.Key != ConsoleKey.Escape);