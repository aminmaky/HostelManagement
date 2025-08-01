using System;
using System.Collections.Generic;

namespace HostelManagement
{
    public class Block
    {
        public string Name { get; set; }
        public int FloresCount { get; set; }
        public int RoomCount { get; set; }
        public BlocksManager Supervisor { get; set; }
        public List<Room> Rooms { get; set; } = new();
        public Dormitory DormitoryName { get; set; }

        public Block() { }  // ← مهم برای deserialization

        public Block(string name, int floresCount, int roomCount, BlocksManager supervisor, Dormitory dormitoryName)
        {
            Name = name;
            FloresCount = floresCount;
            RoomCount = roomCount;
            Supervisor = supervisor;
            DormitoryName = dormitoryName;

            Rooms = new List<Room>();
            GenerateRooms();
        }

        private void GenerateRooms()
        {
            int roomsPerFloor = RoomCount / FloresCount;
            for (int i = 0; i < RoomCount; i++)
            {
                int floor = (i / roomsPerFloor) + 1;
                double roomNum = i + 1;
                Room room = new Room(roomNum, floor, this);
                Rooms.Add(room);
            }
        }

        public override string ToString()
        {
            return $"{Name} ({FloresCount} floors, {RoomCount} rooms)";
        }
    }
}
