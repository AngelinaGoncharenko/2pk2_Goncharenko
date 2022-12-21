namespace pz_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите пример(допустимые операции: +, -, *, /)");

            int a = Convert.ToInt32(Console.Read());
            char c = Convert.ToChar(Console.Read());
            int b = Convert.ToInt32(Console.Read());
            if (c == '-')
            {
                Console.WriteLine("=" + (a - b));
            }
            else if (c == '+')
            {
                Console.WriteLine("=" + (a + b));
            }
            else if (c == '*')
            {
                Console.WriteLine("=" + (a * b));
            }
            else if (c == '/') ;
            {
                Console.WriteLine("=" + (a / b));
            }

        }
    }
}