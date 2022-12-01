using System;


namespace ClassroomProject
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Subject { get; set; }

        public Student(string firstName, string LastName, string subject)
        {
            this.FirstName = firstName;
            this.LastName = LastName;
            this.Subject = subject;
        }

        public override string ToString()
            => $"Student: First Name = {this.FirstName}, Last Name = {this.LastName}, Subject = {this.Subject}";
    }
}
