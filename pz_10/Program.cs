namespace pz_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку слов(разделенную пробелами): ");
            string stroka = Console.ReadLine();
            string[] textArray = stroka.Split(' ');
            int max = 0;
            int i = 0;
            int n = 0;
            for (int j = 0; j < textArray.Length; j++)
            {
                if (textArray[j].Length > max)
                {
                    max = textArray[j].Length;
                    i = j;
                }

            }

            for (int j = 0; j < textArray.Length; j++)
            {
                if (textArray[j].Length == max)
                {
                    Console.WriteLine("Самое длинное слово в строке: " + textArray[j]);
                }
            }
        }
    }
}