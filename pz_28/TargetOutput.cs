using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_28
{
    public class TargetOutput   //вывод цели
    {
        public event Delegate num;
        public void ActiveateEvent(int now)
        {

            if (now == 200)
            {
                num = Wait200;
            }
            else if (now == 800)
            {
                num = Wait800;
            }
            else num = null;
            if (num != null) num();
        }
        void Wait200()
        {
            Console.WriteLine("Вы перешли отметку в 200 единиц");
        }
        void Wait800()
        {
            Console.WriteLine("вы перешли отметку в 800 единиц");
        }
    }
}
