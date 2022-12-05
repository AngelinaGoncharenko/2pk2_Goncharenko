namespace pz_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = rnd.Next(-10, 10);

                Console.Write(num[i] + " ");
            }
            int[] part1 = new int[5];
            int[] part2 = new int[5];

            for (int i = 0; i < num.Length / 2; i++)
            {
                part1[i] = num[i];
                part2[i] = num[i + num.Length / 2];
            }

            Array.Reverse(part1);
            Array.Reverse(part2);

            int[] result = new int[part1.Length + part2.Length];
            part1.CopyTo(result, 0);
            part2.CopyTo(result, part1.Length);
            Console.WriteLine();

            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i] + " ");
            }
        }
    }
}