namespace LinqDemo1
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            int[] num = new int[] {1,2,3,4,5,6,7,8,9,10};
            // LINQ to iterate
            // Method syntax


            var list = num.ToList();

            foreach (int temp in list)
                Console.WriteLine(temp);
            // Lambda exp
            // input => output

            var evenList = num.Where(x => x % 2 == 0).ToList();

            Console.WriteLine("Even numbers");
            foreach (int temp in evenList)
                Console.WriteLine(temp);
            int sum =  num.ToList().Sum();


            Console.WriteLine(sum);

            double avg = num.ToList().Average();

            Console.WriteLine(avg);


            List<string> names = new List<string>()
            {
                 "ajay",
                 "deepak",
                 "sagar",
                 "pawan",
                 "lalit"
            };

            var nameslist = names.ToList();

            var nameslist1 = names.Where(x => x.Contains("sagar")).ToList();









        }
    }
}