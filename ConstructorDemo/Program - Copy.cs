namespace StaticVDemo
{
    internal class Program1
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.GetDetails();
            //Student.batch = "B001";
            Student.DispplayBatch();
            student.DisplayDetails();
        }
    }
}