using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelManagement// .TempClasses
{
    public class DormitoryManager : Person
    {
        // سازنده بدون پارامتر برای EF Core
        public DormitoryManager() : base()
        {
            position = string.Empty;
        }

        // سازنده اصلی
        public DormitoryManager(string firstname, string lastname, string idNum, string telNum, string address, string position)
            : base(firstname, lastname, idNum, telNum, address)
        {
            this.position = position;
        }

        // تبدیل فیلدها به property
        public string position { get; set; }

        // روابط (navigation properties)
        public virtual Dormitory controledDormitory { get; set; }
        public int? DormitoryId { get; set; }

        public override string ToString()
        {
            return $"{Firstname}-{Lastname}";
        }
    }
}
