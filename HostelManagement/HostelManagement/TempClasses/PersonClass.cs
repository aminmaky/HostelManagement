using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelManagement
{
    public class Person
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string IdNum { get; set; }
        public string TelNum { get; set; }
        public string Address { get; set; }

        public Person()
        {
        }

        public Person(string firstname, string lastname, string idNum, string telNum, string address)
        {
            Firstname = firstname;
            Lastname = lastname;
            IdNum = idNum;
            TelNum = telNum;
            Address = address;
        }
    }
}
