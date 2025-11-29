using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        ArrayList list = new ArrayList();
        list.Add("Ebrar");
        list.Add(true);
        list.Add('H');

        Console.WriteLine("***** ArrayList *****");
        Console.WriteLine(list[1]);

        foreach (var item in list)
        {
            Console.WriteLine(item);
        }

        //AddRange
        Console.WriteLine("**** Add Range ****");

        string[] colors = { "kırmızı", "sarı", "yeşil" };

        List<int> numbers = new List<int>() { 1, 11, 3, 7, 9, 92, 5 };

        list.AddRange(colors);
        list.AddRange(numbers);

        foreach (var item in list)
        {
            Console.WriteLine(item);
        }

        //Sort
        Console.WriteLine("**** Sort ****");

        List<int> orderedlist = new List<int>() { 1, 8, 3, 7, 9, 92, 5 };
        orderedlist.Sort();

        foreach (var item in orderedlist)
        {
            Console.WriteLine(item);
        }

        
        //Binary Search
        Console.WriteLine("**** Binary Search ****");

        int index = orderedlist.BinarySearch(9);

        Console.WriteLine(index);

        //Reverse
        Console.WriteLine("***Reverse****");
        orderedlist.Reverse();

        foreach (var item in orderedlist)
        {
            Console.WriteLine(item);
        }


        //clear
        Console.WriteLine("****Clear****");
        orderedlist.Clear();
        foreach (var item in orderedlist)
        {
            Console.WriteLine(item);
        }
    }
}
