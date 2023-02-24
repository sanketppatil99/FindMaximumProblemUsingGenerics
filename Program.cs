namespace FindMaximumProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            double n = TestCase<float>.MaxNumber(50.5f, 45.6f, 48.5f);
            int a = TestCase<int>.MaxNumber(70, 60, 50);
            string c = TestCase<string>.MaxNumber("Peach", "Apple", "Banana");



            Console.WriteLine("Maximum int in is: {0}", a);
            Console.WriteLine("Maximum Number in float is: {0}", n);
            Console.WriteLine("Maximum value in string is: {0}", c);

        }
    }
}
