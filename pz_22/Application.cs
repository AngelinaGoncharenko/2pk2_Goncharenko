using System;
using System.Collections.Generic;
using System.Text;

namespace pz_22
{
    class Application
    {
        public int ID { get; set; }
        public string Customer { get; set; } = "ClientName";
        public string Vendor { get; set; } = "vendor";
        public string Model { get; set; } = "printer";
        public int Toner { get; set; } = 5;
      

        public Application(int id, string customer = "ClientName", string model = "printer", string vendor = "vendor", int toner = 5) //конструктор
        {
            ID = id;
            Customer = customer;
            Vendor = vendor;
            Model = model;
            Toner = toner;
        }

        public int toner   //автосвойство
        {
            get { return Toner; }
            set
            {
                if (value > 5 && value < 50)
                    Toner = value;
           
            }
        }

        public void GetApplicationInfo()
        {
            Console.WriteLine($"ID: {ID}\n Рrinter model: {Model}\n Vendor: {Vendor}\n Customer: {Customer}\n The amount of toner used: {Toner} gram");

        }
    }
}
