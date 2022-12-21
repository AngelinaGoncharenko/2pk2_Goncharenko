namespace pz_18._2
{
    enum Seasons { summer, winter, spring, autumn }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter season:");
            string s = Console.ReadLine();
        }

        static void PrintSeason(Seasons season)
        {
            switch (season)
            {

                case Seasons.summer:
                    Console.WriteLine("01.06 International Children's Day in Russia", "11.06 Brewer's Day in Russia", "12.06 Day of Russia", "10.07 Fisherman's Day in Russia", "19.07 Day of pies with raspberry jam");
                    break;
                case Seasons.winter:
                    Console.WriteLine("01.01 New year", "07.07 Christmas");
                    break;
                case Seasons.autumn:
                    Console.WriteLine("01.09 knowledge day");
                    break;
                case Seasons.spring:
                    Console.WriteLine("17.05 my birthday", "09.05 Victory Day");
                    break;
            }
        }
    }
}