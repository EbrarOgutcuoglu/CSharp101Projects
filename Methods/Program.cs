internal class Program
{
    public static void Main(string[] args)
    {
        int a = 3 , b= 4;
        int result = addition(a, b);
        Console.WriteLine(result);

        //Method class 
        Method m = new Method();
        m.print(Convert.ToString(result));

        //İncrease and sum
        int result2 = m.increaseSum(a, b);
        Console.WriteLine(result2);

        //ref int example
        int result3 = m.increaseSumRef(ref a, ref b);
        Console.WriteLine(result3);
        Console.WriteLine("After ref int a : " + a + " after ref int b: " + b);

        //out parameter
        String num = "999";
        bool status = int.TryParse(num, out int numResult);
        if (status)
        {
            Console.WriteLine("completed");
            Console.WriteLine(numResult);
        }
        else
        {
            Console.WriteLine("failed");
        }

        m.substraction(a, b, out int resultSubstraction);
        Console.WriteLine(resultSubstraction);


        //method overloading 
        int number = 100;
        m.print(number);
        
    }

    public static int addition(int a , int b)
    {
        return a + b;
    }
}


class Method
{
    public void print(String data)
    {
        Console.WriteLine(data);
    }

    //method overloading
    public void print(int data)
    {
        Console.WriteLine(data);
    }

    public int increaseSum(int a , int b)
    {
        a++;
        b++;
        return a + b;
    }

    public int increaseSumRef(ref int a , ref int b)
    {
        a++;
        b++;
        return a + b;
    }

    //out parameter
    public void substraction(int a , int b , out int result)
    {
        result = a - b;
    }
}