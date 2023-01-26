using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООП_свойства
{
    internal class Employee : Person
    {
        public string Company { get; set; }
        public Employee(string name, string company)
            :base(name)
            {
            Company = company;
        }
        public override void Print()
        {
            base.Print();
            Console.Write($" work in {Company}");
        }
    }
}
