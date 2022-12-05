namespace pz_13
{
    internal class Program
    {
        /// <summary>
        /// Задает массив вещественных чисел
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static double[,] GetDoubleArray(int a, int b)
        {
            Random rnd = new Random();

            double[,] array = new double[a, b];
            for (int i = 0; i < a; ++i)
            {
                for (int j = 0; j < b; ++j)
                {
                    array[i, j] = rnd.NextDouble();
                }
            }
            return array;
        }

        static void Main()
        {
            Console.WriteLine("Введите размерность массива: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            double[,] array = GetDoubleArray(a, b);

            for (int i = 0; i < a; ++i)
            {
                for (int j = 0; j < b; ++j)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}