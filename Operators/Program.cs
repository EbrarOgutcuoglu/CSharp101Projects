internal class Program
{
    static void Main(string[] args)
    {
        //Assigment
        int x = 5;
        int y = 6;
        Console.WriteLine(y);
        y += 2;
        Console.WriteLine(y);
        y *= 3;
        Console.WriteLine(y);
        x /= 5;
        Console.WriteLine(x);

        //logical operators

        bool isSuccess = true;
        bool isCompleted = false;

        if (isSuccess && isCompleted)
            Console.WriteLine("perfect");
        if (isSuccess || isCompleted)
            Console.WriteLine("great");
        if (isSuccess && !isCompleted)
            Console.WriteLine("fine");

        //< > <= >= == !=
        int a = 4;
        int b = 5;
        bool result = a < b;
        Console.WriteLine(result);
        result = a > b;
        Console.WriteLine(result);
        result = a >= b;
        Console.WriteLine(result);
        result = a != b;
        Console.WriteLine(result);

        //aritmethic
        int num1 = 10;
        int num2 = 12;
        int result2 = num1 + num2;
        Console.WriteLine(result2);
        result2 = num2 / num1;
        Console.WriteLine(result2);
        result2 = num2 - num1;
        Console.WriteLine(result2);
        result2 = 2 * ++num1;
        Console.WriteLine(result2);

        // % mod
        int result3 = 20 % 6;
        Console.WriteLine(result3);






    }
}