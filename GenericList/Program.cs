internal class Program
{
    private static void Main(string[] args)
    {
        // List<T> class
        // //System.Collections.Generic
        // // T-> object türündedir.

        List<int> numbers = new List<int>();
        numbers.Add(23);
        numbers.Add(10);
        numbers.Add(4);
        numbers.Add(5);
        numbers.Add(92);
        numbers.Add(34);

        List<string> colors = new List<string>();
        colors.Add("red");
        colors.Add("blue");
        colors.Add("orange");
        colors.Add("yellow");
        colors.Add("green");

        //Count
        Console.WriteLine(colors.Count);
        Console.WriteLine(numbers.Count);

        //Foreach ve List.ForEach ile elemanlara erişim
        foreach (var num in numbers)
        {
            Console.WriteLine(num);
        }

        foreach (var color in colors)
        {
            Console.WriteLine(color);
        }

        numbers.ForEach(num => Console.WriteLine(num));
        colors.ForEach(color => Console.WriteLine(color));

        // Listeden eleman çıkarma
        numbers.Remove(4); // Değeri 4 olan elemanı siler
        colors.Remove("green"); // Değeri "Yeşil" olan elemanı siler

        numbers.RemoveAt(0); // 0. (ilk) indeksteki elemanı siler
        colors.RemoveAt(1); // 1. indeksteki elemanı siler

        // Kalan elemanları yazdırma (Önceki koddan gelen numbers ve colors listeleri varsayılmıştır)
        numbers.ForEach(num => Console.WriteLine(num));
        colors.ForEach(color => Console.WriteLine(color));


        // Liste içerisinde Arama
        if (numbers.Contains(10))
        {
            Console.WriteLine("10 is founded in list!");
        }

        // Eleman ile index'e erişme
        // Not: BinarySearch metodu, doğru sonuç vermesi için listenin sıralı olmasını gerektirir.
        // Görseldeki kod çalışsa da, bu listenin sıralı olmadığı unutulmamalıdır.
        Console.WriteLine(colors.BinarySearch("yellow"));

        // Diziyi List'e çevirme
        string[] animals = { "cat", "dog", "bird" };
        List<string> animalList = new List<string>(animals);

        // Listeyi nasıl temizleriz?
        animalList.Clear();
        //List içerisinde nesne tutmak
        List<users> users = new List<users>();

        users user1 = new users();
        user1.Name = "Ayşe";
        user1.Surname = "Yılmaz";
        user1.Age = 26;

        users user2 = new users();
        user2.Name = "Özcan";
        user2.Surname = "Çalışkan";
        user2.Age = 26;

        users.Add(user1);
        users.Add(user2);

        // Object Initializer ile liste elemanı ekleme
        List<users> yeniListe = new List<users>();
        yeniListe.Add(new users()
        {
            Name = "Deniz",
            Surname = "Arda",
            Age = 24
        });

        // foreach döngüsü ile listeye erişim
        foreach (var user in users)
        {
            Console.WriteLine("user name: " + user.Name);
            Console.WriteLine("user surname: " + user.Surname);
            Console.WriteLine("user age: " + user.Age);
        }

        // Listeyi temizleme
        yeniListe.Clear();
    }
    public class users
    {
        private string name;
        private string surname;
        private int age;

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public int Age { get => age; set => age = value; }
    }
}