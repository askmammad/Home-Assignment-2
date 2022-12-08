using System;
namespace Program
{
    class Demo
    {
        public int RemainderFunc(int a, int b)
        {
            if (b == 0)
                throw new Exception("Second number cannot be zero! Cannot divide by zero!");
            if (a < b)
                throw new Exception("Number cannot be less than the divisor!");
            else
                return (a % b);
        }
        public static void Main()
        {
            int a, b;
            int remainder;
            Console.Write("Enter first number: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            b = Convert.ToInt32(Console.ReadLine());
            Demo d = new Demo();
            remainder = d.RemainderFunc(a, b); ;
            Console.WriteLine("Remainder is: {0}", remainder);
        }
    }
}