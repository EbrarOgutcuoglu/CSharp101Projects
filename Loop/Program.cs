internal class Program
{
    private static void Main(string[] args)
    {
        
        //Prints the odd numbers that are equal to the number entered on the screen.
        /*int num = Convert.ToInt32(Console.ReadLine());
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
        }*/

        //WHILE
        // Prints the average of the numbers entered from 1 to n.
        Console.Write("Please sign a number");
        int num2 = int.Parse(Console.ReadLine());
        int counter = 1;
        double total= 0;
        while(counter <=num2)
        {
            total += counter;
            counter++;
        }
        Console.WriteLine("Average of numbers: " + total/num2);

        //print the all letters from 'a' to 'z'
        char letter = 'a';
        while(letter <= 'z')
        {
            Console.Write(letter);
            letter++;
        }

        //FOREACH

        String [] fruits = { "apple", "banana", "watermelon", "pineapple" };

        foreach (var fruit in fruits)
        {
            Console.Write(fruit + " ");
        }

        
    }
}