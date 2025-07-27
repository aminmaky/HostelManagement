using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelManagement
{
    public class Block
    {
        public Block()
        {
            Name = string.Empty;
            FloresCount = 0;
            RoomCount = 0;
        }

        
        public Block(string name, int floresCount, int roomCount)
        {
            Name = name;
            FloresCount = floresCount;
            RoomCount = roomCount;
        }

        public Block(string name, int floresCount, int roomCount, BlocksManager supervisor, Dormitory dormitoryName)
        {
            Name = name;
            FloresCount = floresCount;
            RoomCount = roomCount;
            this.supervisor = supervisor;
            this.DormitoryName = dormitoryName;
        }
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public int FloresCount { get; set; }
        public int RoomCount { get; set; }

        public virtual BlocksManager supervisor { get; set; }
        public string SupervisorId { get; set; }

        public virtual Dormitory DormitoryName { get; set; }
        public int? DormitoryId { get; set; }

        public override string ToString()
        {
            return $"{Name} ({FloresCount} floors, {RoomCount} rooms)";
        }
    }
}
