using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace pz_24
{
    public interface ICLoneable
    {
        object Clone();
    }
    internal class Application : ICLoneable
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

        public void UsedToner()
        {
            Console.WriteLine($" Total toner used {count}");
        }

        public virtual void GetApplicationInfo()
        {
            Console.WriteLine($"ID: {ID}\n Рrinter model: {Model}\n Vendor: {Vendor}\n Customer: {Customer}\n The amount of toner used: {Toner} gram");
        }

        public object Clone()
        {
            return new Application(ID, Customer, Model, Vendor, Toner);
        }
    }
}
