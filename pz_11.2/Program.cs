namespace pz_11._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку разделенную пробелами: ");
            string str = Console.ReadLine();
            string[] words = str.Split(' ');
            foreach (string s in words)
            {
                Console.Write($"\"{s}\"");   // Задание: Вывести предложение, в котором каждое слово заключено в кавычки
            }
        }
    }
}