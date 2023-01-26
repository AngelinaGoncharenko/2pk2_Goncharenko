using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_ageEmployee
{
    internal class Person
    {
        int age = 1;
        public virtual int Age
        {
            get => age; 
            set { if (value > 0 && value < 110) age = value; } 
        }
        public string Name { get; set; }
        public Person (string name, int age)
        {
            Name = name;
            Age = age;
        }

        public virtual void Print() => Console.WriteLine(Name, Age);
    }
}
