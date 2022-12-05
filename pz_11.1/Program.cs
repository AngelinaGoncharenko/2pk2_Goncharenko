namespace pz_11._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // использовать метод join and reverse
            Console.WriteLine("Введите строку слов(разделенную пробелами): ");
            string text = Console.ReadLine();
            string[] words = text.Split(' ');

            //for (int i = 0; i<words.Length; i++)
            //{
            //    char[] w = words[i].ToCharArray(); 
            //    Array.Reverse(w);
            //    words[i] = new string(w);
            //}

            foreach (string str in words)
            {
                Console.WriteLine(str);
            }
        }
    }
}