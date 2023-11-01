namespace InheritanceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
           PartTimEmployee partTimEmployee = new PartTimEmployee();
            partTimEmployee.GetDetails();
            //partTimEmployee.GetPartTimeDetails();
            partTimEmployee.DisplayDetails();
            //partTimEmployee.DisplayPartTimeDetails();
        }
    }
}