namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 1, 2, 3 };

            Console.WriteLine($"Evvelki____" + string.Join(", ", ints));

            MenfiChange(ref ints);
            Console.WriteLine($"Sonraki____" + string.Join(", ", ints));
        }
        static void MenfiChange(ref int[] ints)
        {
            for (int i = 0; i < ints.Length; i++)
            {
                if (ints[i] > 0)
                {
                    ints[i] = -ints[i];
                }
            }
        }
    }

}
