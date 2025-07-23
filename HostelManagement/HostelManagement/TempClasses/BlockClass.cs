using HostelManagement.TempClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelManagement// .TempClasses
{
    public class Block
    {
        public string Name;
        public int FloresCount;
        public int RoomCount;
        public BlocksManager supervisor;
        // private List<Rooms> room; (R V needed??)
        public Dormitory DormitoryName;
        public Block(string Name, int FloresCount, int RoomCount, BlocksManager supervisor, Dormitory DormitoryName)
        {
            this.Name = Name;
            this.FloresCount = FloresCount;
            this.RoomCount = RoomCount;
            this.supervisor = supervisor;
            this.DormitoryName = DormitoryName;
        }
        public override string ToString()
        {
            return $"{Name} ({FloresCount} floors, {RoomCount} rooms)";
        }
    }
}
