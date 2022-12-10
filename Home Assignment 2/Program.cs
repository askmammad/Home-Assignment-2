using System;
namespace Program
{
    class Program
    {
        public static void Main()
        {
            int a, b;
            int remainder;
            Console.Write("Birinci ededi daxil edin: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ikinci ededi daxil edin: ");
            b = Convert.ToInt32(Console.ReadLine());
            remainder = a % b;
            if (b == 0)
            {
                Console.WriteLine("Ikinci eded sifir ola bilmez! Sifira bolune bilmez!");
            }
            else if (a < b)
            {
                Console.WriteLine("Birinci eded bolunecek ikinci ededden az ola bilmez!");
            }
            else
            {
                Console.WriteLine("Qaliq beraberdir: {0}", remainder);
            }
        }
    }
}