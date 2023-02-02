using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_21
{
    internal class Application
    {
        public int ID { get; set; }
        public string Customer { get; set; }
        public string Vendor { get; set; }
        public string Model { get; set; }

        public Application(int id, string customer, string vendor, string model)
        {
            ID = id;
            Customer = customer;
            Vendor = vendor;
            Model = model;

        }

        public void GetApplicationInfo()
        {
            Console.WriteLine($"ID: {ID}\n Рrinter model: {Model}\n Vendor: {Vendor}\n Customer: {Customer}");
        }
    }
}
