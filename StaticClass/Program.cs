internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Count of employee: {0}", Employee.CountOfEmployee);

        Employee employee = new Employee("Ayşe", "Yılmaz", "IK");

        Console.WriteLine("Count of employee: {0}", Employee.CountOfEmployee);
        Employee employee1 = new Employee("Ebrar", "Nisa", "IK");
        Employee employee2 = new Employee("Elif", "Güneş", "IK");

        Console.WriteLine("Result of sum: {0}",Operations.Sum(100,200));
        Console.WriteLine("Result of substraction: {0}", Operations.Substraction(400, 50));


    }


}
class Employee
{
    private static int countOfEmployee;

    public static int CountOfEmployee { get => countOfEmployee; }

    private string Name;
    private string Surname;
    private string Department;

    // Static Kurucu Metot (Sınıfa ilk erişildiğinde bir kez çalışır)
    static Employee()
    {
        countOfEmployee = 0;
    }

    // Parametreli Kurucu Metot
    public Employee(string Name, string Surname, string Department)
    {
        this.Name = Name;
        this.Surname = Surname;
        this.Department = Department;
        countOfEmployee++; // Her nesne oluştuğunda static sayacı artır
    }

    
}
static class Operations // Static sınıf örneği (Görselde sınıf başlığı yok, bu sadece örnek)
{
    // Static metot: Sınıf adı üzerinden doğrudan çağrılır.
    public static long Sum(int sayi1, int sayi2)
    {
        return sayi1 + sayi2;
    }

    public static long Substraction(int sayi1, int sayi2)
    {
        return sayi1 - sayi2;
    }
}