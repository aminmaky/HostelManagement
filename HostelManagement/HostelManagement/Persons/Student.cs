using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Newtonsoft.Json;


namespace HostelManagement.Persons
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StudentID { get; set; }
        public string NationalID { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        public override string ToString()
        {
            return $"{StudentID} - {FirstName} {LastName}";
        }
    }

    public static class StudentRepository
    {
        private static readonly string filePath = "students.json";

        public static void AddStudent(Student student)
        {
            var students = LoadStudents();
            students.Add(student);
            SaveStudents(students);
        }

        public static List<Student> GetAllStudents()
        {
            return LoadStudents();
        }

        public static Student FindById(string studentId)
        {
            var students = LoadStudents();
            return students.Find(s => s.StudentID == studentId);
        }

        public static void RemoveStudent(string studentId)
        {
            var students = LoadStudents();
            var student = students.Find(s => s.StudentID == studentId);
            if (student != null)
            {
                students.Remove(student);
                SaveStudents(students);
            }
        }

        private static List<Student> LoadStudents()
        {
            if (!File.Exists(filePath))
                return new List<Student>();

            var json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<List<Student>>(json) ?? new List<Student>();
        }

        private static void SaveStudents(List<Student> students)
        {
            var json = JsonConvert.SerializeObject(students, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(filePath, json);
        }
    }
}
