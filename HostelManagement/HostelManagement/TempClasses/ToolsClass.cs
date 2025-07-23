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
    public class Tools
    {
        private Asset Type;
        private string[] PartNum;
        private string Number;
        private status Status;
        private int RoomNum;
        private string OwnerName;

        public Tools(Asset type, string[] partNum, string number, status status, int roomNum, string ownerName)
        {
            Type = type;
            PartNum = partNum;
            Number = number;
            Status = status;
            RoomNum = roomNum;
            OwnerName = ownerName;
        }
    }
}
