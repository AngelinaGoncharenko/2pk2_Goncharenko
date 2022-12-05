namespace pz_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вариант 8
            //Задание 1
            //for (int i = 20; i <= 80; i += 5)
            //{
            //    Console.WriteLine(i);
            //}

            //Задание 2
            //char sym = 'G';
            //int i = 0;
            //while (i != 5)
            //{
            //    Console.WriteLine(sym);
            //    sym++;
            //    i++;
            //}

            //Задание 3
            //for (var i = 0; i < 6; i++)
            //{
            //    for (var j = 0; j < 5; j++)
            //    {
            //        Console.Write('#');
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadKey();

            //Задание 4
            //for (int i = 1; i <= 100; i *= 6)
            //    Console.WriteLine(i);

            //Задание 5
            int i = 1;
            int j = 5;
            int difference = 2;
            for (; ; i++, j--)
            {
                if (i - j > difference)
                {
                    Console.WriteLine($"i={i} \nj={j}");
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}