using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelManagement// .TempClasses
{
    public class Dormitory
    {
        public string Name;
        public string Address;
        public long Capacity;
        public DormitoryManager DormitoryManager;
        public List<Block> Blocks;
        public Dormitory(string Name, string Address, long Capacity, 
            DormitoryManager dormitorymanager/*, List<Block> blocks*/)
        {
            this.Name = Name;
            this.Address = Address;
            this.Capacity = Capacity;
            this.DormitoryManager = dormitorymanager;
            // this.Blocks = blocks;
        }
        public override string ToString() 
        {
            return Name;
        }
    }
}
