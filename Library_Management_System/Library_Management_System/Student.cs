using System;
using System.Collections.Generic;
using System.Text;

namespace Library_Management_System
{
    class Student
    {
        public int id;
        public string name; 
        public string email; 
        public string password; 
        public string department; 
        public string semester;
        public string city;
        public Student(int id, string name, string email, string password, string department, string semester, string city)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.password = password;
            this.department = department;
            this.semester = semester;
            this.city = city;
        }
    }
}
