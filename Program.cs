using System.Media;
Console.WriteLine("Переключение между октавами F5 F6 F7");
Console.WriteLine("Белые клавишы - символы от a по j");
Console.WriteLine("Чёрные клавишы - символы от q по t");
Console.WriteLine("Выход - эскейп");
ConsoleKeyInfo key = Console.ReadKey();
static void forhz(int hz)
{
    Console.Beep(hz, 200);
}
static int[] smenaOct(int oct)
{
    int[] fifth = new int[]
    {
         523, 554, 578, 623, 659, 698, 740, 784, 830, 880, 932, 987
    };
    int[] sixth = new int[]
    {
        1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976
    };
    int[] seventh = new int[]
    {
         2093, 2217, 2349, 2489, 2637, 2794, 2960, 3136, 3322, 3520, 3729, 3951
    };

    if (oct == 5)
    {
        return fifth;
    }
    else if (oct == 6)
    {
        return sixth;
    }
    else if (oct == 7)
    {
        return seventh;
    }
    return fifth;
    
}

ConsoleKeyInfo note;
int[] oct = smenaOct(5);
do
{
    note = Console.ReadKey(true);
    switch (note.Key)
    {
        case ConsoleKey.F5:
            oct = smenaOct(5); break;
        case ConsoleKey.F6:
            oct = smenaOct(6); break;
        case ConsoleKey.F7:
            oct = smenaOct(7); break;
        case ConsoleKey.A:
            forhz(oct[0]);
            break;
        case ConsoleKey.Q:
            forhz(oct[1]);
            break;
        case ConsoleKey.S:
            forhz(oct[2]);
            break;
        case ConsoleKey.W:
            forhz(oct[3]);
            break;
        case ConsoleKey.D:
            forhz(oct[4]);
            break;
        case ConsoleKey.F:
            forhz(oct[5]);
            break;
        case ConsoleKey.E:
            forhz(oct[6]);
            break;
        case ConsoleKey.G:
            forhz(oct[7]);
            break;
        case ConsoleKey.R:
            forhz(oct[8]);
            break;
        case ConsoleKey.H:
            forhz(oct[9]);
            break;
        case ConsoleKey.T:
            forhz(oct[10]);
            break;
        case ConsoleKey.J:
            forhz(oct[11]);
            break;
    }
} while (note.Key != ConsoleKey.Escape);
