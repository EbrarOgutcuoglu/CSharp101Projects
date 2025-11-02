internal class Program
{
    public static void Main(string[] args)
    {
        //if statement
        int time = DateTime.Now.Hour;

        if(time>= 6 && time<=12)
            Console.WriteLine("good morning");
        else if(time<=18)
            Console.WriteLine("good afternoon");
        else
            Console.WriteLine("good evening");

        string result = time >= 6 && time <= 12 ? "good morning" : time <= 18 ? "good afternoon" : "good evening";
        Console.WriteLine(result);


        //Switch Statement

        int month = DateTime.Now.Month;

        switch (month)
        {
            case 1:
                Console.WriteLine("january");
                break;
            case 2:
                Console.WriteLine("february");
                break;
            default :
                Console.WriteLine("ınvalid input ");
                break;
            
        }

        switch (month)
        {
            case 12:
            case 1:
            case 2:
                Console.WriteLine("winter");
                break;
            case 3:
            case 4:
            case 5:
                Console.WriteLine("spring");
                break;
            case 6:
            case 7:
            case 8:
                Console.WriteLine("summer");
                break;
            case 9:
            case 10:
            case 11:
                Console.WriteLine("autumn");
                break;

        }


    }
}