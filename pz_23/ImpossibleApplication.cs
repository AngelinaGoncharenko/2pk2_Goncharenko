using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace pz_23
{
    internal class ImpossibleApplication : Application
    {
        public int Reason
        {
            get { return _reason; }
            set
            {
                if (value > 5 && value < 50)
                    _reason = value;
                else
                    Console.WriteLine("Error! The printer is not responding! Check for faults! There might be an error in the amount of toner!");
            }
        }

        public ImpossibleApplication(int id, string customer, string model, string vendor, int toner, int reason)
        {
            ID = id;
            Customer = customer;
            Vendor = vendor;
            Model = model;
            Toner = toner;
            Reason = reason;
        }

        public ImpossibleApplication(int reason)
        {
            Reason = reason;
        }

        public override void GetApplicationInfo()
        {
            Console.WriteLine(Reason);

        }
    }
}
