internal class Program
{
    public static void Main(string[] args)
    {
        //implicit conversion
        byte a = 3;
        short b = 4;
        sbyte c = 5;

        int d = a + b + c;
        Console.WriteLine("d: " + d);

        String e = "ebra";
        char f = 'r';
        object o = e + f;
        Console.WriteLine(o);

        //explicit conversion
        int x = 4;
        byte y = (byte)x;
        Console.WriteLine("y: " + y);

        //** ToString method
        string xx = 6.ToString();
        string yy = 12.5f.ToString();
        Console.WriteLine(xx + yy);

        //System.Convert
        string s1 = "10", s2 = "20";
        int num1, num2, result;

        num1 = Convert.ToInt32(s1);
        num2 = Convert.ToInt32(s2);
        result = num1 + num2;
        Console.WriteLine(result);

        //parse
        parseMethod();


    }
    public static void parseMethod()
    {
        string s1 = "10";
        string s2 = "10.25";
        int num;
        double num2;

        num = Int32.Parse(s1);
        num2 = Double.Parse(s2);
        Console.WriteLine("number : " + num);
        Console.WriteLine("number2 : " + num2);
    }
}