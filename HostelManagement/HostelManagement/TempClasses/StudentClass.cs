using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HostelManagement // .TempClasses
{
    public class Student : Person
    {
        // سازنده بدون پارامتر برای EF Core
        public Student() : base()
        {
            StudentId = string.Empty;
            Room = 0;
            tools = new List<Tools>();
        }

        // سازنده اصلی
        public Student(string firstname, string lastname, string idNum, string telNum, string address, string studentId)
            : base(firstname, lastname, idNum, telNum, address)
        {
            StudentId = studentId;
            Room = 0;
            tools = new List<Tools>();
        }

        // تبدیل فیلدها به property
        public string StudentId { get; set; }
        public int Room { get; set; }

        // روابط (navigation properties)
        public virtual Block Block { get; set; }
        public int? BlockId { get; set; }

        public virtual Dormitory dormitory { get; set; }
        public int? DormitoryId { get; set; }

        public virtual List<Tools> tools { get; set; }

        public string GetFullDetails()
        {
            return $"Name: {Firstname} {Lastname}\n" +
                   $"Student ID: {StudentId}\n" +
                   $"Tel: {TelNum}\n" +
                   $"Dormitory: {dormitory?.Name}\n" +
                   $"Block: {Block?.Name}\n" +
                   $"Room: {Room}";
        }

        public override string ToString()
        {
            return $"{Firstname} {Lastname} - {StudentId}";
        }
    }
}
