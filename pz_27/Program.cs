using System.Xml.Linq;

namespace pz_27
{
    struct Note
    {
        public string Name;
        public long Tele;
        public int[] Bday = new int[3];

        Note(string name, long tele, int[] BdayArr)
        {
            Name = name;
            Tele = tele;
            Bday = BdayArr;
        }

    }

    internal class Program
    {       

        static void Main(string[] args)
        {
            Random rnd = new Random();

            Note[] blocknote = new Note[3]; //ввести в консоль 8 контактов
            int[] BdayArr = new int[3];

            Console.WriteLine("Имя контакта:");
            for (int i = 1; i < blocknote.Length; i++)
            {
                Console.WriteLine($"Создать новый контакт {i}");

                Console.Write($"Имя {i}:");
                string name = Console.ReadLine();
                

                Console.Write($"Номер телефона {i}:");
                long tele = Convert.ToInt64( Console.ReadLine());
                
                Console.WriteLine($"Дата рождения {i}:");
                int x = Convert.ToInt32( Console.ReadLine() );
                int y = Convert.ToInt32(Console.ReadLine());
                int z = Convert.ToInt32(Console.ReadLine());

                BdayArr[0] = x;
                BdayArr[1] = y;
                BdayArr[2] = z;

                blocknote[i] = new Note { Name = name, Tele = tele, Bday = BdayArr };
            }

            Console.WriteLine("Введите имя: ");
            string people = Console.ReadLine();

            foreach(Note note in blocknote)
            {
                if (people == note.Name)
                    Console.WriteLine(note.Name, note.Tele, note.Bday);

                else Console.WriteLine
                ("Такого контакта не существует");
            }
        }
    }
}