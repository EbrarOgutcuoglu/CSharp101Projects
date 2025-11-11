internal class Program
{
    private static void Main(string[] args)
    {
        Student student = new Student("Elif","yılmaz",134);
        student.ınfoStudent();
        
    }
}

class Student
{
    private string name, surname;
    private int no;

    public string Name { get => name; set => name = value; }
    public string Surname { get => surname; set=> surname = value; }
    public int No { get=> no ; set=> no = value; }

    public Student(string name , string surname,int no)
    {
        this.name = name;
        this.surname = surname;
        this.no = no;
    }

    public Student() { }

    public void ınfoStudent()
    {
        Console.WriteLine("Name {0} , Surname {1} , No:{2}" ,name,surname,no);
    }


}