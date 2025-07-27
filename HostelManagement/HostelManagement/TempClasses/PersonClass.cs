using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HostelManagement// .TempClasses
{
    public class Person
    {
        // سازنده بدون پارامتر برای EF Core
        public Person()
        {
            Firstname = string.Empty;
            Lastname = string.Empty;
            IdNum = string.Empty;
            TelNum = string.Empty;
            Address = string.Empty;
        }

        // سازنده اصلی
        public Person(string firstname, string lastname, string idNum, string telNum, string address)
        {
            Firstname = firstname;
            Lastname = lastname;
            IdNum = idNum;
            TelNum = telNum;
            Address = address;
        }

        // کلید اصلی
        [Key]
        public string IdNum { get; set; }

        // تبدیل فیلدها به property
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string TelNum { get; set; }
        public string Address { get; set; }
    }
}

