namespace pz_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count_strings = 0;
            char[] signs = ".,!?;:".ToCharArray();
            string path = @"D:\text.txt";
            using (StreamReader sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                {
                    int count_signs = 0;
                    string line = sr.ReadLine();
                    count_strings++;
                    foreach (char i in line)
                    {
                        foreach (char s in signs)
                        {
                            if (i == s)
                            {
                                count_signs++;
                            }
                        }
                    }
                    Console.WriteLine($"В строке {count_strings} количество знаков препинания {count_signs}");
                }
                Console.WriteLine($"Общее количество строк: {count_strings}");
            }
        }
    }
}