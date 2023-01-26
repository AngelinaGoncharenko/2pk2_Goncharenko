using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_ageEmployee
{
    internal class Employee : Person
    {
     public override int Age
        {
            get => base.Age;
            set { if(value > 18 && value < 65) base.Age = value; }
        }
        
        public Employee ( string name, int age ):base( name, age )
        {
            Age = age;
            base.Age = 18; //возраст для работников по умолчанию
        }

    }
}
