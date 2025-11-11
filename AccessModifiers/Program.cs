internal class Program
{
    private static void Main(string[] args)
    {
        Employee employee = new Employee();
        employee.name = "Ebrar";
        employee.surname = "Nisa";
        employee.department = "Computer Engineering";
        employee.no = 12;
        employee.infoEmployee();

        Console.WriteLine("****employee 2***");
        Employee employee1 = new Employee("Açelya", "Yılmaz", "Sales", 13);
        employee1.infoEmployee();

    }
}

class Employee
{
    public string name;
    public string surname;
    public string department;
    public int no;

    public Employee(string name , string surname,string department,int no)
    {
        this.name = name;
        this.surname = surname;
        this.department = department;
        this.no = no;
    }

    public Employee() {}


    public void infoEmployee()
    {
        Console.WriteLine("Name :{0}",name);
        Console.WriteLine("Surname: {0}" , surname);
        Console.WriteLine("Department: {0} ",department);
        Console.WriteLine("Id:{0} ",no);
    }
 
}