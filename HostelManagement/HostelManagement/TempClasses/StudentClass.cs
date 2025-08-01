using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Newtonsoft.Json;

namespace HostelManagement
{
    public class Student : Person
    {
        public string StudentId { get; set; }
        public Room Room { get; set; }
        public Block Block { get; set; }
        public Dormitory Dormitory { get; set; }
        public List<Tool> Tools { get; set; } = new List<Tool>();
        public List<HousingRecord> HousingHistory { get; set; } = new List<HousingRecord>();

        public Student() : base()
        {
        }

        public Student(string firstname, string lastname, string idNum, string telNum,
                       string address, string studentId)
            : base(firstname, lastname, idNum, telNum, address)
        {
            StudentId = studentId;
        }

        public string GetFullDetails()
        {
            return $"Name: {Firstname} {Lastname}\n" +
                   $"Student ID: {StudentId}\n" +
                   $"Tel: {TelNum}\n" +
                   $"Dormitory: {Dormitory?.Name}\n" +
                   $"Block: {Block?.Name}\n" +
                   $"Room: {Room}";
        }

        public override string ToString()
        {
            return $"{Firstname} {Lastname} - {StudentId}";
        }
    }
    public class HousingRecord
    {
        public string Room { get; set; }
        public string Dormitory { get; set; }
        public string Block { get; set; }

        public HousingRecord() { }

        public HousingRecord(string room, string dormitory, string block)
        {
            Room = room;
            Dormitory = dormitory;
            Block = block;
        }
    }
}
