using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelManagement
{
    public class DormitoryManager : Person
    {
        public string Position { get; set; }
        public Dormitory ControledDormitory { get; set; }

        public DormitoryManager()
            : base()
        {
        }

        public DormitoryManager(string firstname, string lastname, string idNum, string telNum, string address, string position)
            : base(firstname, lastname, idNum, telNum, address)
        {
            Position = position;
        }

        public override string ToString()
        {
            return $"{Firstname} {Lastname}";
        }
    }
}
