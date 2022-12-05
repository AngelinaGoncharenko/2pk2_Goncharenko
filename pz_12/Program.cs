namespace pz_12
{
    internal class Program
    {
        // процедура -  SqlrtA234(A, B, C, D), 
        // А - входной параметр, В С D - выходные параметры

        static void SqlrtA234(double A, out double B, out double C, out double D)
        {
            B = Math.Pow(A, 1.0 / 2.0);
            C = Math.Pow(A, 1.0 / 3.0);
            D = Math.Pow(A, 1.0 / 4.0);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите число для возведения в степень: ");
            double A = Convert.ToDouble(Console.ReadLine());
            double B, C, D;

            SqlrtA234(A, out B, out C, out D);
            Console.WriteLine($"Квадратичный корень: {B}\nКубический корень: {C}\nКорень в 4 степени: {D} ");
        }
    }
}