using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    private static void Main(string[] args)
    {
         Console.WriteLine("1)---------");
         evenNumbers();
         Console.WriteLine();
         Console.WriteLine();
         Console.WriteLine("2)-------");
             printNumbersDivisible();
        
        Console.WriteLine("3)----------");
        printWordsReverse();
        
        Console.WriteLine("4)------------");
        countWordLetter();



    }
    public static void evenNumbers()
    {
        Console.Write("Sign a positive a number : ");
        int count = Convert.ToInt32(Console.ReadLine());

        int[] evenNumbers = new int[count];
        int index = 0; 

        Console.WriteLine($"enter {count} numbers ");

        for (int i = 0; i < count; i++)
        {
            int number = Convert.ToInt32(Console.ReadLine());

            if (number > 0 && number % 2 == 0)
            {
                evenNumbers[index] = number;
                index++;
            }
        }

        Console.Write("Even Numbers: ");

        for (int i = 0; i < index; i++)
        {
            Console.Write(evenNumbers[i] + " ");
        }
    }

    public static void printNumbersDivisible()
    {
        Console.WriteLine("Sign a positive number");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.Write("Sign a positive number");
        int m = Convert.ToInt32(Console.ReadLine());

        int[] numbers = new int[n];
        int index = 0;

        Console.WriteLine($"enter {n} numbers ");

        for (int i = 0; i < n; i++)
        {
            int number = Convert.ToInt32(Console.ReadLine());

            if (number > 0 && number % m == 0 || number == m)
            {
                numbers[index] = number;
                index++;
            }
        }

        Console.Write("Divisible or equals to {0} : ",m);

        for (int i = 0; i < index; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    }

    public static void printWordsReverse()
    {
        Console.Write("Sign a positive a number : ");
        int count = Convert.ToInt32(Console.ReadLine());

        string [] words = new string[count];
       

        Console.WriteLine($"enter {count} words ");

        for (int i = 0; i < count; i++)
        {
            string word = Console.ReadLine();
               words[i] = word;
               
            
        }

        Console.WriteLine("reverse order in words: ");

        for (int i = words.Length - 1; i >= 0; i--)
        {
            Console.Write(words[i] + " ");
        }
    }

    public static void countWordLetter()
    {
        Console.WriteLine("please sign a sentence");
        string sentence = Console.ReadLine();
        string[] words = sentence.Split(" ");
        int number = 0;

        foreach (var item in words)
        {
            number += item.Length;
        }
        Console.WriteLine("word count : " + words.Length);
        Console.WriteLine("numbers of letters : " + number);
    }



}