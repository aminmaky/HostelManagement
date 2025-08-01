using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelManagement// .TempClasses
{
    public class BlocksManager : Student
    {
        public string Position;
        public Block controledBlock;

        public BlocksManager(string firstname, string lastname, string idNum, string telNum, string address, string StudentId, Room Room, Block Block,
            Dormitory dormitory, List<Tool> tool, string position, Block controledBlock)
            : base(firstname, lastname, idNum, telNum, address, StudentId/* , Room, Block, dormitory, tool*/ )
        {
            this.Position = position;
            this.controledBlock = controledBlock;
        }
        public override string ToString()
        {
            return $"{Firstname} {Lastname} - Block: {(controledBlock != null ? controledBlock.Name : "None")}";
        }

    }

}
