using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelManagement// .TempClasses
{
    public class BlocksManager : Student
    {
        // سازنده بدون پارامتر برای EF Core
        public BlocksManager() : base()
        {
            Position = string.Empty;
        }

        // سازنده اصلی با 7 پارامتر
        public BlocksManager(string firstname, string lastname, string idNum, string telNum, string address, string studentId, string position)
            : base(firstname, lastname, idNum, telNum, address, studentId)
        {
            Position = position;
        }

        // سازنده با 12 پارامتر (برای حفظ سازگاری با کد موجود)
        public BlocksManager(string firstname, string lastname, string idNum, string telNum, string address,
                            string studentId, int room, Block block, Dormitory dormitory, List<Tools> tools,
                            string position, Block controledBlock)
            : base(firstname, lastname, idNum, telNum, address, studentId)
        {
            Room = room;
            Block = block;
            this.dormitory = dormitory;
            this.tools = tools;
            Position = position;
            this.controledBlock = controledBlock;
        }

        // تبدیل فیلد به property
        public string Position { get; set; }

        // روابط (navigation properties)
        public virtual Block controledBlock { get; set; }
        public int? BlockId { get; set; }

        public override string ToString()
        {
            return $"{Firstname} {Lastname} - Block: {(controledBlock != null ? controledBlock.Name : "None")}";
        }
    }
}
