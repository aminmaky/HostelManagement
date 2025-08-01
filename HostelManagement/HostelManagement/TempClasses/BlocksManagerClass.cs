using System;
using System.Collections.Generic;

namespace HostelManagement
{
    public class BlocksManager : Student
    {
        public string Position { get; set; }
        public Block ControledBlock { get; set; }

        public BlocksManager() : base() { }

        public BlocksManager(
            string firstname,
            string lastname,
            string idNum,
            string telNum,
            string address,
            string studentId,
            Room room,
            Block block,
            Dormitory dormitory,
            List<Tool> tools,
            string position,
            Block controledBlock
        ) : base(firstname, lastname, idNum, telNum, address, studentId)
        {
            Room = room;
            Block = block;
            this.Dormitory = dormitory;
            this.Tools = tools ?? new();
            Position = position;
            ControledBlock = controledBlock;
        }

        public override string ToString()
        {
            return $"{Firstname} {Lastname} - Block: {(ControledBlock != null ? ControledBlock.Name : "None")}";
        }
    }
}
