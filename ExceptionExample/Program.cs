internal class Program
{
    public static void Main(string[] args)
    {
        /* try
         {
             Console.WriteLine("please sign a number: ");
             int num1 = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("number : " + num1);
         }
         catch (Exception ex)
         {
             Console.WriteLine(ex.Message.ToString());
         }
         finally
         {
             Console.WriteLine("Completed");
         }*/

        try
        {
            //int a = int.Parse(null);
            // int b = int.Parse("test");
            int a = int.Parse("-2392837332929");
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine("null");

        }
        catch (FormatException ex)
        {
            Console.WriteLine("Invalid data type");
        }
        catch (OverflowException ex) 
        {
            Console.WriteLine("Inavlid data");
        }
    }
}