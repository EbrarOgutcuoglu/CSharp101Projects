internal class Program
{
    private static void Main(string[] args)
    {
        string input = "Ebrar Nisa ";
        string input2 = "ogutcuoglu";
        string input3 = "gutcuoglu";

        //length
        Console.WriteLine(input.Length);

        //ToUpper,ToLower
        Console.WriteLine(input.ToLower());
        Console.WriteLine(input.ToUpper());

        //Concat
        Console.WriteLine(String.Concat(input,"Ogutcuoglu"));

        //Compare,CompareTo
        Console.WriteLine(input.CompareTo(input2)); //-1,0,1
        Console.WriteLine(String.Compare(input2,input3,true));
        Console.WriteLine(String.Compare(input2, input3, false));

        //Contains
        Console.WriteLine(input2.Contains(input3));
        Console.WriteLine(input.EndsWith("Nisa "));
        Console.WriteLine(input.StartsWith("Ebrar"));

        //IndexOf
        Console.WriteLine(input.IndexOf("N"));
        Console.WriteLine(input.LastIndexOf("E"));

        //Insert
        Console.WriteLine(input.Insert(0,"I am "));

        //PadRight,PadLeft
        Console.WriteLine(input + input2.PadLeft(15));
        Console.WriteLine(input + input2.PadLeft(15,'*'));
        Console.WriteLine(input.PadRight(20) + input2);
        Console.WriteLine(input.PadRight(20,'-') + input2);

        //Remove
        Console.WriteLine(input.Remove(5));
        Console.WriteLine(input.Remove(0,1));
        Console.WriteLine(input.Remove(3,6));

        //Replace
        Console.WriteLine(input.Replace(" ","-"));

        //Split
        Console.WriteLine(input.Split(" ")[1]);

        //Substring
        Console.WriteLine(input.Substring(2));
        Console.WriteLine(input.Substring(2,4));

    }
}