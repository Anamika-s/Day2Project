namespace LinqDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[] {1,2,3,4,5,6,7,8,9,10};
            // LINQ to iterate
            // Query syntax
            // from rangevariable in collection / array
            // where 
            // select

           var list =  from x in num
            select x;  // Lazy Loading

            foreach (int temp in list)
                Console.WriteLine(temp);


            var evenList = (from x in num
                           where x%2==0
                           select x).ToList();

            Console.WriteLine("Even numbers");
            foreach (int temp in evenList)
                Console.WriteLine(temp);

            int sum = (from x in num
                       select x).Sum();


            Console.WriteLine(sum);

            double avg = (from x in num
                         select x).Average();

            Console.WriteLine(avg);


            List<string> names = new List<string>()
            {
                 "ajay",
                 "deepak",
                 "sagar",
                 "pawan",
                 "lalit"
            };

            var nameslist = (from x in names
                             select x).ToList();

            var nameslist1 = (from x in names
                              where x.Contains("sagar")
                              select x).ToList();




        }
    }
}