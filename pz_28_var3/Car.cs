using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_28_var3
{
    internal class Car
    {
        
        public int num;
        public Car(int x)
        {
            num = x;
        }
        public void Speed()
        {
            Patrol a = new Patrol();
            for (int i = 1; i <= 120; i++)
            {
                a.ActiveateEvent(i);
                Console.WriteLine(i);

                if (i == 120)
                {
                    Console.WriteLine("Введите 1, если хотите попытаться скрыться от патруля и введите 2, если решили остановиться");
                    int c = Convert.ToInt32(Console.ReadLine());
                    if (c == 2)
                    {
                        Console.WriteLine("Вам выписан штраф за превышение скорости.");
                        break;
                    }
                    else if (c == 1)
                    {
                        for (int j = 121; j < 221; j++)
                        {
                            a.ActiveateEvent(j);
                            Console.WriteLine(j);
                        }
                    }


                }
            }
        }
    }
}
