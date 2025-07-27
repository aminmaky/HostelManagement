using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public Tools()
        {
            Number = string.Empty;
            OwnerName = string.Empty;
            PartNum2 = new string[0];
        }

        public Tools(Asset type, string partNum, string number, status status, int roomNum, string ownerName)
        {
            Type = type;
            PartNum = partNum;
            Number = number;
            Status = status;
            RoomNum = roomNum;
            OwnerName = ownerName;
        }

        [Key]
        public int Id { get; set; }

        public Asset Type { get; set; }
        public string PartNum { get; set; }  
        public string[] PartNum2
        {
            get => PartNum?.Split(',') ?? new string[0];  
            set => PartNum = string.Join(',', value);  
        }
        public string Number { get; set; }
        public status Status { get; set; }
        public int RoomNum { get; set; }
        public string OwnerName { get; set; }

        // کلید خارجی برای رابطه با Student
        public string StudentId { get; set; }
    }
}
