using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace pz_23
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
    }
}
