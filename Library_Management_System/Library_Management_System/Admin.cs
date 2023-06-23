using System;
using System.Collections.Generic;
using System.Text;

namespace Library_Management_System
{
    class Admin
    {
        public int id;
        public string name;
        public string email;
        public string password;
        public string designation;
        public string hiredate;
        public string retiredate;

        public static Admin instance;
        public static readonly object lockObject = new object();

        public Admin(int id, string name, string email, string password, string designation, string hiredate, string retiredate)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.password = password;
            this.designation = designation;
            this.hiredate = hiredate;
            this.retiredate = retiredate;
        }
        public static void DestroyInstance()
        {
            lock (lockObject)
            {
                instance = null;
            }
        }

        public static Admin GetInstance(int id, string name, string email, string password, string designation, string hiredate, string retiredate)
        {
            if (instance == null)
            {
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        instance = new Admin(id, name, email, password, designation, hiredate, retiredate);
                    }
                }
            }

            return instance;
        }
    }

}
