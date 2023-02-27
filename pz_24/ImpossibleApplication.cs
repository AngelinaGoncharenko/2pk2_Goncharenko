using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace pz_24
{
    internal class ImpossibleApplication : Application
    {
        private int _reason;

        public int Reason
        {
            get { return _reason; }
            set
            {
                if (false)
                {
                    Console.WriteLine("the printer is defective, check with the seller for information");
                }
            }
        }

        public ImpossibleApplication(int id, string customer, string model, string vendor, int toner, int reason) : base(id, customer, model, vendor, toner)
        {
            Reason = reason;
        }

        public override void GetApplicationInfo()
        {
            base.GetApplicationInfo();
            Console.WriteLine(Reason);
        }

        public object Clone()
        {
            return new ImpossibleApplication(ID, Customer, Model, Vendor, Toner, Reason);
        }
    }
}
