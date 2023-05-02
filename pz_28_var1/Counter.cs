using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace pz_28
{
    internal class Counter
    {
        public int num;
        public Counter(int x)
        {
            num = x;
        }

        public void Numbers()
        {
            TargetOutput a = new TargetOutput();
            for (int i = 1; i < 1001; i++)
            {
                a.ActiveateEvent(i);
                Console.WriteLine(i);
                if (i == 800) break;
            }
        }
    }
}

