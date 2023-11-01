namespace InheritanceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("WHat tyoe of em");
            int c = 1;
          
            if(c == 1)
            {
                A a = new A();
                Employee employee1 = new PartTimEmployee();
                a.Check(employee1);
            }
            Employee employee = new Employee();
            //Employee employee = new PartTimEmployee();
            //PartTimEmployee p = new Employee();
            PartTimEmployee partTimEmployee = new PartTimEmployee();
            employee = partTimEmployee;
            employee.GetDetails();
            employee.DisplayDetails();
           
        }
    }
    class A
    {
        public void Check(Employee emp)
        {
            if (emp is PartTimEmployee)
                Foo((PartTimEmployee)emp);

            else if (emp is FullTimEmployee)
                Foo((FullTimEmployee)emp)

            else
                Foo(emp);
        }
        

    public void Foo(Employee obj)
    {
        //Do something for parent
    }

    public void Foo(PartTimEmployee obj)
    {
            obj.A();
            obj.GetDetails();
            obj.DisplayDetails();
            
         
    }

    public void Foo(FullTimEmployee obj)
    {
        //Do something for B
    }
}
}