using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_ClassWriting
{
    internal class patient
    {
        public string name = "Angelina";
        public int BirthDay = 17;
        public int BirthMonth = 05;
        public int BirthYear = 2005;
        public string area = "Vysotnaya Street";
        public string doctor = "Ivanova A.S.";

        public void Print()
        {
            Console.WriteLine($"Patient's name: {name} \nDate of birth: {BirthDay}.{BirthMonth}.{BirthYear} \nAttachment area: {area} \nTreating doctor: {doctor}");
        }
    }
}
