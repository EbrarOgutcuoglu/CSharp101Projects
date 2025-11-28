internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(DateTime.Now);
        Console.WriteLine(DateTime.Now.Date);
        Console.WriteLine(DateTime.Now.Day);
        Console.WriteLine(DateTime.Now.Month);
        Console.WriteLine(DateTime.Now.Year);
        Console.WriteLine(DateTime.Now.Hour);
        Console.WriteLine(DateTime.Now.Minute);
        Console.WriteLine(DateTime.Now.Second);

        Console.WriteLine(DateTime.Now.DayOfWeek);
        Console.WriteLine(DateTime.Now.DayOfYear);

        Console.WriteLine(DateTime.Now.ToLongDateString());
        Console.WriteLine(DateTime.Now.ToShortDateString());
        Console.WriteLine(DateTime.Now.ToLongTimeString());
        Console.WriteLine(DateTime.Now.ToShortTimeString());

        Console.WriteLine(DateTime.Now.AddDays(2));
        Console.WriteLine(DateTime.Now.AddHours(3));
        Console.WriteLine(DateTime.Now.AddSeconds(30));
        Console.WriteLine(DateTime.Now.AddMonths(5));
        Console.WriteLine(DateTime.Now.AddYears(10));
        Console.WriteLine(DateTime.Now.AddMilliseconds(50));
    
        // DateTime Format
        Console.WriteLine(DateTime.Now.ToString("dd"));   // 28
        Console.WriteLine(DateTime.Now.ToString("ddd"));  // Fri 
        Console.WriteLine(DateTime.Now.ToString("dddd")); // Friday

        Console.WriteLine(DateTime.Now.ToString("MM"));   // 11
        Console.WriteLine(DateTime.Now.ToString("MMM"));  // Nov
        Console.WriteLine(DateTime.Now.ToString("MMMM")); // November

        Console.WriteLine(DateTime.Now.ToString("yy"));   // 25
        Console.WriteLine(DateTime.Now.ToString("yyyy")); // 2025

        // Math Library
        Console.WriteLine(Math.Abs(-25)); // 25
        Console.WriteLine(Math.Sin(30)); 
        Console.WriteLine(Math.Cos(30)); 
        Console.WriteLine(Math.Tan(30));

        Console.WriteLine(Math.Ceiling(22.3)); // Rounds up.
        Console.WriteLine(Math.Round(22.3)); // Rounds to nearest integer.
        Console.WriteLine(Math.Floor(22.7)); // Rounds down.
        Console.WriteLine(Math.Round(22.7)); // Rounds to nearest integer.
        Console.WriteLine(Math.Min(2, 6)); // Returns smaller value.
        Console.WriteLine(Math.Max(2, 6)); // Returns larger value.

        Console.WriteLine(Math.Pow(3, 4)); // Returns power (x^y).
        Console.WriteLine(Math.Log10(100)); // Base 10 logarithm.
        Console.WriteLine(Math.Sqrt(9)); // Square root.
        Console.WriteLine(Math.Exp(3)); // e raised to a power.
        Console.WriteLine(Math.Log(10)); // Natural logarithm (base e).
    }
}