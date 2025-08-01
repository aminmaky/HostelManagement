using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelManagement// .TempClasses
{
    public class Room
    {
        public double RoomNum;
        public int Floor;
        public int Capacity;
        public Block BlockName;
        public List<Student> daneshgo;
        public List<Tool> tool;

        public bool IsFull()
        {
            return daneshgo.Count >= Capacity;
        }

        public Room(double RoomNum, int Floor, Block Block)
        {
            this.RoomNum = RoomNum;
            this.Floor = Floor;
            this.Capacity = 6;
            this.BlockName = Block;
            // this.daneshgo = daneshgo;
            // this.tool = tool;
        }
    }
}
