using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelManagement
{
    public class BlocksManager : Student
    {
        public BlocksManager() : base()
        {
            Position = string.Empty;
        }
        public BlocksManager(string firstname, string lastname, string idNum, string telNum, string address, string studentId, string position)
            : base(firstname, lastname, idNum, telNum, address, studentId)
        {
            Position = position;
        }

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
        public string Position { get; set; }
        public virtual Block controledBlock { get; set; }
        public int? BlockId { get; set; }

        public override string ToString()
        {
            return $"{Firstname} {Lastname} - Block: {(controledBlock != null ? controledBlock.Name : "None")}";
        }
    }
}
