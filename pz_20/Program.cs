namespace pz_20
{
    internal class Program
    {
        static string GetReverse(string txt)
        {
            string result = "";
            for (int i = 0; i < txt.Length; i++)
            {
                if (Char.IsUpper(txt[i]))
                {
                    result += Char.ToLower(txt[i]);
                }
                else if (Char.IsLower(txt[i]))
                {
                    result += Char.ToUpper(txt[i]);
                }
            }
            return result;
        }

        static void Main(string[] args)
        {
            string txt = Console.ReadLine();
           
            Console.WriteLine(GetReverse(txt));
        }
    }
}