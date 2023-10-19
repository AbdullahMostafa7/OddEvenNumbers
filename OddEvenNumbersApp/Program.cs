namespace OddEvenNumbersApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Print("Odd Numbers", arr.Where(n => n % 2 != 0));
            Console.WriteLine("===========================");
            Print("Even Numbers", arr.Where(n => n % 2 == 0));

        }
        public static void Print(string title, IEnumerable<int> numbers)
        {
            Console.Write($"{title}: [ ");
            foreach (int number in numbers)
            {
                Console.Write($"   {number}");
            }

            Console.WriteLine("   ]");
        }
    }
}