using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelManagement// .TempClasses
{
    public class Dormitory
    {
        // سازنده بدون پارامتر برای EF Core
        public Dormitory()
        {
            Name = string.Empty;
            Address = string.Empty;
            Capacity = 0;
            Blocks = new List<Block>();
        }

        // سازنده اصلی
        public Dormitory(string name, string address, long capacity, DormitoryManager dormitoryManager)
        {
            Name = name;
            Address = address;
            Capacity = capacity;
            DormitoryManager = dormitoryManager;
            Blocks = new List<Block>();
        }

        // کلید اصلی
        [Key]
        public int Id { get; set; }

        // تبدیل فیلدها به property
        public string Name { get; set; }
        public string Address { get; set; }
        public long Capacity { get; set; }

        // روابط (navigation properties)
        public virtual DormitoryManager DormitoryManager { get; set; }
        public string DormitoryManagerId { get; set; }

        public virtual List<Block> Blocks { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
