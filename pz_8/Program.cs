namespace pz_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Найти максимальный элемент главной диагонали матрицы arr[5, 5] и вывести его индексы
            int i, j;
            int[,] A = new int[5, 5];
            Random r = new Random();
            Console.WriteLine("Массив A:  ");
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    A[i, j] = r.Next(0, 100);
                    Console.Write(A[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.Write("Главная диагональ: ");
            for (i = 0; i < A.GetLength(0); i++)
            {
                Console.Write($" {A[i, i]} ");
            }


            int maxValue = A[0, 0];
            for (i = 1; i < A.GetLength(0); i++)
            {
                if (A[i, i] > maxValue)
                {
                    maxValue = A[i, i];
                    Console.WriteLine(" ");
                    Console.Write("Максимальный элемент главной диагонали: " + A[i, i]);
                }

            }
        }
    }
}