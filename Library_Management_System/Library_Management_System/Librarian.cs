using System;
using System.Collections.Generic;
using System.Text;

namespace Library_Management_System
{
    class Librarian
    {
        public int id;
        public string name;
        public string email;
        public string password;
        public string city;
        public int salary;
        public Librarian (int id, string name, string email, string password, string city, int salary)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.password = password;
            this.city = city;
            this.salary = salary;
        }
    }
}
