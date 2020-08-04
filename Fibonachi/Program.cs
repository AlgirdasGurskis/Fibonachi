using System; 

namespace Fibonachi
{
    class Program
    {
        static int p1 = 0, p2 = 1, p3;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some number to stop the fibonacci sequence.");
            int num = int.Parse(Console.ReadLine());
            int first = 1;
            Console.Write("{0},", first);
            int second = 1;
            Console.Write("{0},", first);
            int sum = 0;

            while (sum <= num)
            {
                sum = first + second;
                 Console.Write("{0},", sum);

                first = second;
                second = sum;
            }
            Console.WriteLine("\n\n");
            Fibonacci(num - 2);
            Console.WriteLine("\n\nIt done, please enter any key!");
            Console.ReadKey();
        }
        private static void Fibonacci(int count)
        {
            if (count>0)
            {
                p3 = p1 + p2;
                Console.Write("  " + p3);
                p1 = p2;
                p2 = p3;
                Fibonacci(count - 1);
            }
        }
    }
}
