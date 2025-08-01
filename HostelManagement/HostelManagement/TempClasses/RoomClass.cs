using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelManagement
{
    public class Room
    {
        public double RoomNum { get; set; }
        public int Floor { get; set; }
        public int Capacity { get; set; }
        public Block BlockName { get; set; }
        public List<Student> Daneshgo { get; set; }
        public List<Tool> Tool { get; set; }

        public Room()
        {
            Daneshgo = new List<Student>();
            Tool = new List<Tool>();
        }

        public Room(double roomNum, int floor, Block block)
        {
            RoomNum = roomNum;
            Floor = floor;
            Capacity = 6;
            BlockName = block;
            Daneshgo = new List<Student>();
            Tool = new List<Tool>();
        }

        public bool IsFull()
        {
            return Daneshgo.Count >= Capacity;
        }

        public override string ToString()
        {
            return $"Room {(int)RoomNum} - Floor {Floor} - Capacity {Capacity}";
        }
    }
}
