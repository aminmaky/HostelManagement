using HostelManagement;
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
        public List<Room> rooms;
        public Dormitory DormitoryName;

        public Block(string name, int floresCount, int roomCount, BlocksManager supervisor, Dormitory dormitoryName)
        {
            Name = name;
            FloresCount = floresCount;
            RoomCount = roomCount;
            this.supervisor = supervisor;
            DormitoryName = dormitoryName;

            rooms = new List<Room>();
            GenerateRooms();
        }

        private void GenerateRooms()
        {
            int roomsPerFloor = RoomCount / FloresCount;
            for (int i = 0; i < RoomCount; i++)
            {
                int floor = (i / roomsPerFloor) + 1; // طبقه‌گذاری از 1
                double roomNum = i + 1;
                Room room = new Room(roomNum, floor, this);
                rooms.Add(room);
            }
        }

        public override string ToString()
        {
            return $"{Name} ({FloresCount} floors, {RoomCount} rooms)";
        }
    }

}
