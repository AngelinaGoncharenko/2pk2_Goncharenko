namespace pz_18._1
{
    internal class Program
    {
        enum Marks { veryBad = 1, unsatisfactory, satisfactorily, good, great }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter rating: ");
            int num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 1:
                    Console.WriteLine($"Mark characteristic 1: {Marks.veryBad}");
                    break;

                case 2:
                    Console.WriteLine($"Mark characteristic 2: {Marks.unsatisfactory}");
                    break;

                case 3:
                    Console.WriteLine($"Mark characteristic 3: {Marks.satisfactorily}");
                    break;

                case 4:
                    Console.WriteLine($"Mark characteristic 4: {Marks.good}");
                    break;

                case 5:
                    Console.WriteLine($"Mark characteristic 1: {Marks.great}");
                    break;

                default: Console.WriteLine("ncorrect value!"); break;


            }
        }
    }
}