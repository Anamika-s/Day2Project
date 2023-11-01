namespace ConstructorDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Def const
            Student student1= new Student();
            student1.GetDetails();
            student1.DisplayDetails();

            // para cons
            Student student2 = new Student(name:"deepak");
            student2.DisplayDetails();

            // para cons
            Student student3 = new Student(id:10);

            student3.DisplayDetails();

            // para cons
            Student student4 = new Student(id: 11, name: "jatin");
            student4.DisplayDetails();

            // fully para cons
            Student student5 = new Student(id: 12, name: "Parul", batch: "B001", marks: 90);
            student5.DisplayDetails();


            // copy const

            Student student6 = new Student(student4);

        }
    }
}