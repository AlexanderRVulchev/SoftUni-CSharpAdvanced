using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassroomProject
{
    public class Classroom
    {
        private readonly List<Student> students;

        public int Capacity { get; set; }
        public int Count { get { return this.students.Count; } }

        public Classroom(int capacity)
        {
            this.Capacity = capacity;
            this.students = new List<Student>();
        }

        public string RegisterStudent(Student student)
        {
            if (this.Count == this.Capacity)
                return "No seats in the classroom";
            else
            {
                this.students.Add(student);
                return $"Added student {student.FirstName} {student.LastName}";
            }
        }

        public string DismissStudent(string firstName, string lastName)
        {
            if (!this.students.Any(s => s.FirstName == firstName && s.LastName == lastName))
                return "Student not found";
            else
            {
                this.students.Remove(this.students.Find(s => s.FirstName == firstName && s.LastName == lastName));
                return $"Dismissed student {firstName} {lastName}";
            }
        }
        
        public string GetSubjectInfo(string subject)
        {
            if (!this.students.Any(s => s.Subject == subject)) 
                return "No students enrolled for the subject";

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Subject: {subject}");
            sb.AppendLine("Students:");            
            foreach (Student student in this.students.Where(s => s.Subject == subject))
            {
                sb.AppendLine($"{student.FirstName} {student.LastName}");
            }
            return sb.ToString().TrimEnd();
        }
        
        public int GetStudentsCount()
            => this.Count;
                
        public Student GetStudent(string firstName, string lastName)
            => this.students.Find(s => s.FirstName == firstName && s.LastName == lastName);
    }
}
