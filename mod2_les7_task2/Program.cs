namespace mod2_les7_task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 15;
            if (a % 2 == 0)
            {
                Console.WriteLine($"Variable {a} is even");
            }
            else
            {
                Console.WriteLine($"Variable {a} is odd");
            }
        }
    }
}