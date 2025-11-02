internal class Program
{
    private static void Main(string[] args)
    {
        //Prints the odd numbers that are equal to the number entered on the screen.
        int num = Convert.ToInt32(Console.ReadLine());
        for(int i = 1; i<=num; i++)
        {
            if(i%2 == 1)
                Console.WriteLine(i);
        }

        //Sum of odd and even numbers from 1 to 1000
        int oddSum = 0, evenSum =0;

        for(int i = 0; i <= 1000; i++)
        {
            if (i % 2 == 0)
                evenSum += i;
            else
                oddSum += i;
        }

        Console.WriteLine("Sum of odd numbers : " + oddSum);
        Console.WriteLine("Sum of even numbers: " + evenSum);

        //break, continue
        for(int i =1; i <= 10; i++)
        {
            if (i == 4)
                break;
            Console.WriteLine(i);
        }

        for (int i = 1; i <= 10; i++)
        {
            if (i == 4)
                continue;
            Console.WriteLine(i);
        }
    }
}