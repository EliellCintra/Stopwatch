
Menu();

static void Menu()
{
    Console.Clear();

    Console.WriteLine("\n\tWELCOME!\n");
    Console.WriteLine("1 = Stopwatch");
    Console.WriteLine("2 = Countdown");
    Console.WriteLine("0 = Exit");
    Console.WriteLine("-----------------------------");
    Console.WriteLine("Select an option:");
    int option = int.Parse(Console.ReadLine());

    switch (option)
    {
        case 1: Stopwatch(); break;
        case 2: Countdown(); break;
        case 0:
            {
                Console.Clear();
                Environment.Exit(0);
            }; break;
        default:
            {
                Console.WriteLine("\nSelect a valid option (0, 1 or 2)...\n");
                Thread.Sleep(2000);
                Console.Clear();
                Menu();
                break;
            }
    }


}

static void Countdown()
{
    Console.Clear();

    Console.WriteLine("\n\tCountdown\n");
    Console.WriteLine("s = Seconds (example: 5s)");
    Console.WriteLine("m = Minutes (example: 3m)");
    Console.WriteLine("0 = Exit");
    Console.WriteLine("-----------------------------");
    Console.WriteLine("Set the time:");
    string data = Console.ReadLine().ToLower();

    if (data == "0")
        Menu();

    char type = char.Parse(data.Substring(data.Length - 1, 1));
    int time = int.Parse(data.Substring(0, data.Length - 1));

    if (type == 'm')
        time *= 60;

    PreStart(time, false);
}

static void PreStart(int time, bool Stopwatch)
{
    Console.Clear();

    Console.WriteLine("Ready?...");
    Thread.Sleep(1000);
    Console.WriteLine("Set...");
    Thread.Sleep(1000);
    Console.WriteLine("Go!...");
    Thread.Sleep(1000);

    if (Stopwatch)
        StartStopwatch(time);
    else
        StartCountdown(time);
}

static void StartCountdown(int time)
{
    while (time != 0)
    {
        Console.Clear();
        Console.WriteLine(time);
        time--;
        Thread.Sleep(1000);
    }

    Console.Clear();
    Console.WriteLine("Contdown finished!");
    Thread.Sleep(2000);
    Console.Clear();
    Countdown();
}

static void Stopwatch()
{
    Console.Clear();

    Console.WriteLine("\n\tStopwatch\n");
    Console.WriteLine("s = Seconds (example: 5s)");
    Console.WriteLine("m = Minutes (example: 3m)");
    Console.WriteLine("0 = Exit");
    Console.WriteLine("-----------------------------");
    Console.WriteLine("Set the time:");
    string data = Console.ReadLine().ToLower();

    if (data == "0")
        Menu();

    char type = char.Parse(data.Substring(data.Length - 1, 1));
    int time = int.Parse(data.Substring(0, data.Length - 1));

    int multiplier = 1;

    if (type == 'm')
        multiplier = 60;

    PreStart(time * multiplier, true);
}

static void StartStopwatch(int time)
{
    int currentTime = 0;

    while (currentTime != time)
    {
        Console.Clear();
        currentTime++;
        Console.WriteLine(currentTime);
        Thread.Sleep(1000);
    }

    Console.Clear();
    Console.WriteLine("Finished timer");
    Thread.Sleep(2000);
    Stopwatch();
}
