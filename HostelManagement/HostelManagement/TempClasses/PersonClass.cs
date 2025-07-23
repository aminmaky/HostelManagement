using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelManagement// .TempClasses
{
    public class Person
    {
        public string Firstname;
        public string Lastname;
        public string IdNum;
        public string TelNum;
        public string Address;

        public Person(string Firstname, string Lastname, string IdNum, string TelNum, string Address)
        {
            this.Firstname = Firstname;
            this.Lastname = Lastname;
            this.IdNum = IdNum;
            this.TelNum = TelNum;
            this.Address = Address;
        }
    }
}
