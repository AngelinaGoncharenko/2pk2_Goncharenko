namespace pz_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            char[][] nums1 = new char[4][];
            char[] nums2 = new char[4];
            int count = 0;
            char often;
            Console.WriteLine("Задание 1 и 2: ");
            for (int i = 0; i < 4; i++)
            {
                nums1[i] = new char[rnd.Next(5, 16)];
                for (int j = 0; j < nums1[i].Length; j++)
                {
                    nums1[i][j] = GetRandomChar();
                    //often += nums1[i][j];
                    Console.Write(nums1[i][j] + " ");

                    if (j == nums1[i].Length - 1)
                    {
                        nums2[count] = nums1[i][j];    // заполнение последней строки массива из задания 3
                        count++;
                    }

                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("Задание 3: ");
            foreach (char i in nums2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();


            Console.WriteLine("Задание 4: ");
            char[] maxValue = new char[4];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < nums1[i].Length; j++)
                {
                    if (nums1[i][j] > count)
                    {
                        count = nums1[i][j];

                    }
                }
                maxValue[i] = (char)count;
                count = 0;
            }
            foreach (char i in maxValue)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Задание 6: ");
            count = 0;
            int val = 0;

            for (int a = 0; a < 4; a++)
            {
                for (int b = 0, j = nums1[a].Length - 1; b < j; b++, j--)
                {
                    val = nums1[a][b];
                    nums1[a][b] = nums1[a][j];
                    nums1[a][j] = (char)val;
                }
            }

            for (int b = 0; b < 4; b++)
            {
                for (int j = 0; j < nums1[b].Length; j++)
                {
                    Console.Write(nums1[b][j] + " ");
                }
                Console.WriteLine();
            }
            count = 0;

            static char GetRandomChar()
            {
                Random rnd = new Random();

                char x = 'a';
                int sdvig = rnd.Next(0, 34);
                for (int i = 0; i < sdvig; i++)
                {
                    x++;
                }
                return x;
            }

            Console.WriteLine("Задание 5: ");
            count = 0;
            int max = 0;
            int first = 0;
            for (int i = 0; i < 4; i++)
            {
                max = maxValue[i];
                first = nums1[i][0];
                for (int j = 0; j < nums1[i].Length; j++)
                {
                    if (nums1[i][j] == max)
                    {
                        nums1[i][0] = (char)max;
                        nums1[i][j] = (char)first;
                    }
                }
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < nums1[i].Length; j++)
                {
                    Console.Write(nums1[i][j] + " ");
                }
                Console.WriteLine();

            }
            Console.WriteLine();
        }
    }
}