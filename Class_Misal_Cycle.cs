namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

    }




    class Car
    {
        public int DoorsNum;
        public int doorsnum
        {
            get
            {
                return DoorsNum;
            }
            set
            {
                if (doorsnum > 0 && doorsnum < 5) { DoorsNum = doorsnum; }
                else { Console.WriteLine("doorsnum duz qeyd edin"); }
            }
        }
    }



    class Bicycle
    {
        int WheelNum;
        string Brand;
        string Model;
        double Mile;
        public string brand
        {
            get
            {
                return Brand;
            }
            set
            {
                if (brand.Length > 3 && brand.Length < 30) { Brand = brand; }
                else { Console.WriteLine("Brand duz qeyd edin"); }
            }
        }
        public string model
        {
            get
            {
                return Model;
            }
            set
            {
                if (brand.Length > 3 && brand.Length < 30) { Model = model; }
                else { Console.WriteLine("Model duz qeyd edin"); }

            }
        }
        public double mile
        {
            get
            {
                return Mile;
            }
            set
            {
                if (mile > 0) { Mile = mile; }
                else { Console.WriteLine("Mile duz qeyd edin"); }
            }
        }
    }
}
