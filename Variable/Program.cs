internal class Program
{
    private static void Main(string[] args)
    {
        int value = 15;

        String name = "ebrar";

        byte b = 5;         // 1 byte 
        sbyte sB = -5;      // 1 byte

        short s = 4;        //2 byte
        ushort us = 4;     //2 byte 

        Int16 i16 = 2;      //2 byte
        int i = 2;          //4 byte
        Int32 i32 = 2;      //4 byte
        Int64 i64 = 2;      //8 byte
        uint ui = 2;        //4 byte

        long l = 3;         //8  byte
        ulong ul = 3;       //8 byte


        float f = 8.4f;        //4 byte
        double d = 5.5;     //8 byte
        decimal de = 5.8m;   //16 byte

        char c = 'c';       //2 byte
        String word = "word";

        bool b1 = true;

        DateTime dt = DateTime.Now;

        //object

        object o1 = "object";
        object o2 = 4;
        object o3 = true;

        //String expressions
        String firstName = "ebrar";
        String secondName = "Nisa";
        String fullName = firstName + " " + secondName;

        //integer expressions
        int num1 = 3;
        int num2 = 4;
        int total = num1 + num2;

        //boolean
        bool b2 = 10 < 2;

        //type casting
        String str20 = "20";
        int int20 = 20;
        String result = str20 + int20.ToString();
        int int40 = int20 + Convert.ToInt32(str20);

        int int20_2 = int.Parse(str20);

        String time = DateTime.Now.ToString("dd.MM.yyyy");
        String hour = DateTime.Now.ToString("HH:mm");


        Console.WriteLine(time);
    }
}