namespace pz_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream file = new FileStream(@"D:\t.txt", FileMode.Open, FileAccess.ReadWrite);
            Console.WriteLine("Enter the data line by line (the end of the line is an empty line:)");

            using (StreamWriter sr = new StreamWriter(file))
            {
                string line = "";
                while (line != " ")
                {

                    line = Console.ReadLine();
                    sr.WriteLine(line);

                }
            }
        }
    }
}