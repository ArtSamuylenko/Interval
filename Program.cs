namespace interval
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Подходящие числа: ");
            if (a >= 1 && a <= 3)
            {
                Console.WriteLine(a);
            }
            if (b >= 1 && b <= 3)
            {
                Console.WriteLine(b);
            }
            if (c >= 1 && c <= 3)
            {
                Console.WriteLine(c);
            }
            Console.Read();
        }
    }
}