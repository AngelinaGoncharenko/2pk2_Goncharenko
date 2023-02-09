using System;
using System.Collections.Generic;
using System.Text;

namespace pz_22
{
    class Application
    {
        private int _toner;
        public int ID { get; set; }
        public string Customer { get; set; } = "ClientName";
        public string Vendor { get; set; } = "vendor";
        public string Model { get; set; } = "printer";

        static int count = 0;

        public int Toner
        {
            get { return _toner; }
            set
            {
                if (value > 5 && value < 50)
                    _toner = value;
                else
                    Console.WriteLine("Error! The amount of toner does not correspond to the range of permissible values.");
            }
        }

        public Application(int id, string customer, string model, string vendor, int toner) //конструктор
        {
            ID = id;
            Customer = customer;
            Vendor = vendor;
            Model = model;
            Toner = toner;
            count += toner;
        }

        public void UsedToner ()
        {
            Console.WriteLine($" Total toner used {count}");
        }

        public void GetApplicationInfo()
        {
            Console.WriteLine($"ID: {ID}\n Рrinter model: {Model}\n Vendor: {Vendor}\n Customer: {Customer}\n The amount of toner used: {Toner} gram");
 
        }
    }
}
