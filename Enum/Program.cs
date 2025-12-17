internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(Days.FRIDAY);
        Console.WriteLine((int)Days.SATURDAY);
        int heat = 32;

        if (heat <= (int)weather.cold)
        {
            Console.WriteLine("it's too cold.");
        }
        else if (heat <= (int)weather.sunny)
        {
            Console.WriteLine("The weather is getting warmer.");
        }
        else
        {
            Console.WriteLine("Don't forget to wear your hat.");
        }

    }
    enum Days
    {
        MONDAY=1,
        TUESDAY,
        WEDNESDAY,
        THURSDAY,
        FRIDAY,
        SATURDAY,
        SUNDAY

    }

    enum weather
    {
        cold = 5,
        sunny = 10,
        hot=25
    }
}