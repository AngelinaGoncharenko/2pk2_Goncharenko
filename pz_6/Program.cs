namespace pz_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            do
            {

                if (N % 3 == 0)
                {
                    Console.WriteLine(true);
                    break;
                }
                else
                {
                    Console.WriteLine(false);
                    break;
                }
            }
            while (true);
        }
    }
}