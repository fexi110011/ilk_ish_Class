namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;

            int b = 20;

            Console.WriteLine($"Evvelki a ededi {a}");
            Console.WriteLine($"Evvelki b ededi {b}");

            ChangeNum(ref a,ref b );
            Console.WriteLine($"Sonraki a ededi {a}");
            Console.WriteLine($"Sonraki b ededi {b}");
        }
        static void ChangeNum(ref int a, ref int b)
        {
            a = 20;
            b = 10;
        }
    }
}
