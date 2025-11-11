internal class Program
{
    private static void Main(string[] args)
    {
        //recursive
        Operations o = new Operations();
        Console.WriteLine(o.Expo(3,4));

        //extension
        string name = "Ebrar Nisa";
        bool result = name.CheckSpace();
        Console.WriteLine(result);

        if(result)
            Console.WriteLine(name.RemoveSpace());

        Console.WriteLine(name.UpperCase());
        Console.WriteLine(name.LowerCase());

        int[] numbers = { 9, 3, 5, 6, 2, };
        numbers.SortArray();
        numbers.print();

        Console.WriteLine();

        int num = 5;
        Console.WriteLine(num.isEven());

        Console.WriteLine(name.GetLastCharacter());
    }
}

public class Operations
{
    //recursive method
    public int Expo(int num, int expo)
    {
        if (expo < 2)
            return num;
        
        return Expo(num, expo - 1) * num;
    }
    

}

public static class Extension
{
    //extension method
    public static bool CheckSpace(this string data)
    {
        return data.Contains(" ");
    }

    public static string RemoveSpace(this string data)
    {
        string[] array = data.Split(" ");
        return string.Join("", array);
    }

    public static string UpperCase(this string data)
    {
        return data.ToUpper();
    }

    public static string LowerCase(this string data)
    {
        return data.ToLower();
    }

    public static int[] SortArray(this int[] param)
    {
        Array.Sort(param);
        return param;
    }

    public static void print(this int[] param)
    {
        foreach (var item in param)
        {
            Console.Write(item);
        }

    }

    public static bool isEven(this int param)
    {
        return param % 2 == 0;
    }

    public static string GetLastCharacter(this string param)
    {
        int num = param.Length - 1;
        return param.Substring(num, 1);
    }
}