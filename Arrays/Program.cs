internal class Program
{
    private static void Main(string[] args)
    {
        // defining an array
        String[] animals = { "bird ", "dog", "cat", "rabbit" };
        int[] price;
        price = new int [5];

        //Value assigment and access
        price[0] = 4;
        Console.WriteLine(animals[2]);

        //Utilization of Loops in Arrays
        //Calculates the average of n numbers

        Console.Write("please sign a number: ");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        int total = 0;

        for (int i = 0;i<numbers.Length;i++)
        {
            Console.Write("please sign " + (i+1) + "th element ");
            int num  = int.Parse(Console.ReadLine());
            numbers[i] = num;
      
        }
        for (int i = 0; i < numbers.Length; i++)
        {
            total += numbers[i];

        }
        double average = total / numbers.Length;
        Console.WriteLine("Average: " + average);

    }
}