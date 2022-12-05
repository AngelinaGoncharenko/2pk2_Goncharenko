namespace pz_14
{
    internal class Program
    {
        //#1
        static int GetArithmeticProgression(int a1, int d, int n)
        {

            if (n == 1)
            {
                return a1;
            }
            else
            {
                return d + GetArithmeticProgression(a1, d, n - 1);
            }

        }

        // #2
        static double GetGeometricProgression(double b1, double q, int n)
        {
            if (n == 1)
            {
                return b1;
            }
            else
            {
                return q * GetGeometricProgression(b1, q, n - 1);
            }
        }

        // #3
        static int GetSubsequence(int A, int B)
        {

            Console.Write(A + " ");
            if (A < B)
            {
                GetSubsequence(A + 1, B);
            }
            else if (A > B)
            {
                GetSubsequence(A - 1, B);
            }
            return A;
        }

        // #5
        static int Power(int a, int n)
        {
            if (n == 0)
            {
                return a = 1;
            }
            else
            {

                Math.Pow(a, n);
                return a;
            }

        }



        static void Main(string[] args)
        {
            Console.WriteLine("Введите какой член арифметической прогрессии вы хотите найти: ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Арифметическая прогрессия равна: " + GetArithmeticProgression(55, -5, n1));

            Console.WriteLine("Геометрическая прогрессия равна: " + GetGeometricProgression(8, 0.3, n1));

            Console.WriteLine(GetSubsequence(7, 12));

            Console.WriteLine("Введите число которое будете возводить в степень: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите степень числа, с которого в порядке возрастания, число будет возводиться в степень: ");
            int n5 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Power(a, n5));



        }
    }
}