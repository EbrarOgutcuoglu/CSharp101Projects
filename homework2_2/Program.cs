internal class Program
{
    private static void Main(string[] args)
    {
        int[] numbers = new int[20];

        for (int i = 0; i < 20; i++)
        { 
            Console.Write((i + 1) + ". number: ");
            int number = int.Parse(Console.ReadLine());
            numbers[i] = number;
        }

        Array.Sort(numbers);

        Console.WriteLine("The three smallest ones of numbers: " + numbers[0]+ " " + numbers[1] + " " + numbers[2]);
        Console.WriteLine("The three biggest ones of numbers: " + numbers[17] + " " + numbers[18] + " " + numbers[19]);

    }
}