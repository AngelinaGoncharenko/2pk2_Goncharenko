namespace pz_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Application C24D56 = new Application(89565743, "Niсk", "USA", "C24D56", 25);
            Application Application1 = (Application)C24D56.Clone();
            C24D56.GetApplicationInfo();
            C24D56.UsedToner();
            Console.WriteLine();
            Application C24D57 = new Application(89565744, "Niсk", "USA", "C24D57", 30);
            Application Application2 = (Application)C24D57.Clone();
            C24D57.GetApplicationInfo();
            C24D57.UsedToner();
            Console.WriteLine();
            Application C24D58 = new Application(89565744, "Niсk", "USA", "C24D57", 20);
            Application Application3 = (Application)C24D58.Clone();
            C24D58.GetApplicationInfo();
            C24D58.UsedToner();
            Console.WriteLine();
        }
    }
}