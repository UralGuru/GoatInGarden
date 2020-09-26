using System;

namespace GoatInGarden
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Длина веревки:  ");
            string lenghtString = Console.ReadLine();
            double LenghtDouble = Convert.ToDouble(lenghtString);

            Console.WriteLine("Размеры огорода:  ");
            string SizeString = Console.ReadLine();
            double SizeDouble = Convert.ToDouble(SizeString);

            Console.WriteLine(Calculate(LenghtDouble, SizeDouble));
        }

        static double Calculate(double LenghtDouble, double SizeDouble)
        {
            double s;
            if (LenghtDouble <= SizeDouble / 2)
            {
                s = Math.PI * LenghtDouble * LenghtDouble;
            }
            else if (LenghtDouble >= SizeDouble * Math.Sqrt(2) / 2)
            {
                s = SizeDouble * SizeDouble;
            }
            else
            {
                var acos = 2 * Math.Acos(SizeDouble / (2 * LenghtDouble));
                s = LenghtDouble * LenghtDouble * (Math.PI - 2 * ((Math.PI * acos)) / 180 - Math.Sin(acos));
            }

            return s;
        }
    }
}