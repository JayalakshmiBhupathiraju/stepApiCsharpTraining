using System;

namespace Deligates
{
    public delegate int operation(int x, int y);
    delegate void del(int x, int y);
    class Program
    {
        static int addition(int x,int y)
        {
            return x + y;
        }
        static void Main(string[] args)
        {
            operation a = new operation(addition);
            Console.WriteLine("addition is={0}",a(10,2));

            /*del[] obj1 =
            {
                new del(operation1.Add1),
                new del(operation1.Multiply)
            };*/
            del obj1 = operation1.Add1;
            obj1 = obj1 + operation1.Multiply;
            {
                obj1(1, 2);
                obj1(2, 2);
                obj1(3, 2);
            }
        }
    }
    //array of deligates
    public class operation1
    {
        public static void Add1(int p, int q)
        {
            Console.WriteLine("Addition is {0}",p + q);
        }
        public static void Multiply(int p, int q)
        {
            Console.WriteLine("Multiplication is {0}",p * q);
        }
    }
}
