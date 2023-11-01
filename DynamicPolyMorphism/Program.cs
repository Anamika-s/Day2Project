namespace InheritanceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Employee employee= new Employee();
            PartTimEmployee partTimEmployee= new PartTimEmployee();
            employee = partTimEmployee;
            employee.GetDetails();
            employee.DisplayDetails();
        }
    }
}