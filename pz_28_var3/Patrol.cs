using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_28_var3
{
    internal class Patrol
    {
        public event Delegate num;
        public void ActiveateEvent(int now)
        {

            if (now == 80)
            {
                num = Speed80;
            }
            else if (now == 120)
            {
                num = Speed120;
            }
            else if(now == 220)
            {
                num = Speed220;
            }
            else num = null;
            if (num != null) num();
        }
        void Speed80()
        {
            Console.WriteLine("Ваша скорость свыше 80км/ч, снизте скорость пожалуйста!");
        }
        void Speed120()
        {
            Console.WriteLine("Ваша скорость 120 км/ч!!! Остановитесь, вы задержаны!!!");
            Console.WriteLine("За вами началась погоня!!!");
        }
        void Speed220()
        {
            Console.WriteLine("Ваша машина достигла максимальной скорости, вы не справились с управлением и сьехали с обочены. Вы умерли!!! Начните игру заново.");
        }
    }
}
