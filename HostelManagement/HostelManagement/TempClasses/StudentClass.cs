using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Newtonsoft.Json;


namespace HostelManagement// .TempClasses
{
    public class Student : Person
    {
        public string StudentId;
        public int Room;
        public Block Block;
        public Dormitory dormitory;
        public List<Tools> tools;
        public Student(string firstname, string lastname, string idNum, string telNum, 
            string address, string StudentId/*, int Room, Block Block, Dormitory dormitory, List<Tools> tool*/)
            : base(firstname, lastname, idNum, telNum, address)
        {
            this.StudentId = StudentId;
            // this.Room = Room;
            // his.Block = Block;
            // this.dormitory = dormitory;
            // this.tools = tool;
        }

        public string GetFullDetails()
        {
            return $"Name: {Firstname} {Lastname}\n" +
                   $"Student ID: {StudentId}\n" +
                   $"Tel: {TelNum}\n" +
                   $"Dormitory: {dormitory?.Name}\n" +
                   $"Block: {Block?.Name}\n" +
                   $"Room: {Room}";
        }


        /*
        public string StudentID
        {
            get { return StudentId; }
            set { StudentId = value; }
        }
        public int RoomNumber
        {
            get { return Room; }
            set { Room = value; }
        }
        public int BlockNumber
        {
            get { return Block; }
            set { Block = value; }
        }
        public int DormitoryNumber
        {
            get { return dormitory; }
            set { dormitory = value; }
        }
        */
    }


    //public static class StudentRepository
    //{
    //    private static readonly string filePath = "students.json";

    //    public static void AddStudent(StudentClass student)
    //    {
    //        var students = LoadStudents();
    //        students.Add(student);
    //        SaveStudents(students);
    //    }

    //    public static List<StudentClass> GetAllStudents()
    //    {
    //        return LoadStudents();
    //    }

    //    public static StudentClass FindById(string studentId)
    //    {
    //        var students = LoadStudents();
    //        return students.Find(s => s.StudentID == studentId);
    //    }

    //    public static void RemoveStudent(string studentId)
    //    {
    //        var students = LoadStudents();
    //        var student = students.Find(s => s.StudentID == studentId);
    //        if (student != null)
    //        {
    //            students.Remove(student);
    //            SaveStudents(students);
    //        }
    //    }

    //    private static List<StudentClass> LoadStudents()
    //    {
    //        if (!File.Exists(filePath))
    //            return new List<StudentClass>();

    //        var json = File.ReadAllText(filePath);
    //        return JsonConvert.DeserializeObject<List<StudentClass>>(json) ?? new List<StudentClass>();
    //    }

    //    private static void SaveStudents(List<StudentClass> students)
    //    {
    //        var json = JsonConvert.SerializeObject(students, Newtonsoft.Json.Formatting.Indented);
    //        File.WriteAllText(filePath, json);
    //    }
    //}
}
