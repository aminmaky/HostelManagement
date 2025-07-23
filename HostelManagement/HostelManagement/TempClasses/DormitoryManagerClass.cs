using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelManagement//.TempClasses
{
    public class DormitoryManager : Person
    {
        public string position;
        public Dormitory controledDormitory;

        public DormitoryManager(string firstname, string lastname, string idNum, string telNum, string address, string position/*, int controledDormitory*/)
            : base(firstname, lastname, idNum, telNum, address)
        {
            this.position = position;
            // this.controledDormitory = controledDormitory;
        }
        public override string ToString()
        {
            return $"{Firstname}-{Lastname}";
        }
    }
}
