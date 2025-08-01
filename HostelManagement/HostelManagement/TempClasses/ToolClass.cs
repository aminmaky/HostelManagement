using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelManagement// .TempClasses
{
    public enum status
    {
        Healty,
        Defective,
        UnderRepair
    }
    public enum Asset
    {
        bed,
        desk,
        commode,
        chair,
        fridge
    }
    public class Tool
    {
        public Asset Type;
        public string PartNum;
        public string PropertyNum;
        public status Status;
        public int RoomNum;
        public Person OwnerName;

        public Tool(Asset type, string partNum, string propertyNum, status status/*, int roomNum, string ownerName*/)
        {
            Type = type;
            PartNum = partNum;
            PropertyNum = propertyNum;
            Status = status;
            // RoomNum = roomNum;
            // OwnerName = ownerName;
        }

        public override string ToString()
        {
            return $"{Type} - {PropertyNum}";
        }
    }
}
