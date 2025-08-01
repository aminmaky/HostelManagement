using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelManagement
{
    public enum Status
    {
        Healty,
        Defective,
        UnderRepair
    }

    public enum Asset
    {
        Bed,
        Desk,
        Commode,
        Chair,
        Fridge
    }

    public class Tool
    {
        public Asset Type { get; set; }
        public string PartNum { get; set; }
        public string PropertyNum { get; set; }
        public Status Status { get; set; }
        public int RoomNum { get; set; }
        public Student OwnerName { get; set; }
        public Room Room { get; set; }

        public Tool()
        {
        }

        public Tool(Asset type, string partNum, string propertyNum, Status status)
        {
            Type = type;
            PartNum = partNum;
            PropertyNum = propertyNum;
            Status = status;
        }

        public override string ToString()
        {
            return $"{Type} - {PropertyNum}";
        }
    }
}
