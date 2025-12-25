

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Please sign a sentence.");

        string sentence = Console.ReadLine();

        int length = sentence.Length;

        string[] vowel = new string[length];

        string vowels = "aeiouAEIOU";

        int j = 0;
        for (int i = 0; i < sentence.Length; i++)
        {
           
            if (vowels.Contains(sentence[i]))
            {
                vowel[j] = sentence[i].ToString();
                j++;
            }
        }

        Array.Sort(vowel);
        foreach (var letter in vowel)
        {
            if(letter != null)
            {
                Console.Write(letter + " ");
            }
            
        }

    }

   
       
    
}