using System;
using System.Collections.Generic;

namespace HostelManagement
{
    public class Dormitory
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public long Capacity { get; set; }
        public DormitoryManager DormitoryManager { get; set; }
        public List<Block> Blocks { get; set; }

        public Dormitory()
        {
            Blocks = new List<Block>();
        }

        public Dormitory(string name, string address, long capacity, DormitoryManager dormitoryManager)
        {
            Name = name;
            Address = address;
            Capacity = capacity;
            DormitoryManager = dormitoryManager;
            Blocks = new List<Block>();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
