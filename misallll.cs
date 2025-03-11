namespace ConsoleApp1
{
    internal class Program
    {
        static long Factorial(int n)
        {
            if (n == 0 || n == 1)
                return 1;
            else
                return n*Factorial(n-1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("ededini daxil edin:");
            int num = int.Parse(Console.ReadLine());

            long result = Factorial(num);
            Console.WriteLine($"{num} ededin faktoriali: {result}");
        }
    }
}
