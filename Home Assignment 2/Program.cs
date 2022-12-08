using System;
namespace Program
{
    class Demo
    {
        public int RemainderFunc(int a, int b)
        {
            if (b == 0)
                throw new Exception("Ikinci eded sifir ola bilmez! Sifira bolune bilmez!");
            if (a < b)
                throw new Exception("Birinci eded bolunecek ikinci ededden az ola bilmez!");
            else
                return (a % b);
        }
        public static void Main()
        {
            int a, b;
            int remainder;
            Console.Write("Birinci ededi daxil edin: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ikinci ededi daxil edin: ");
            b = Convert.ToInt32(Console.ReadLine());
            Demo d = new Demo();
            remainder = d.RemainderFunc(a, b); ;
            Console.WriteLine("Qaliq beraberdir: {0}", remainder);
        }
    }
}