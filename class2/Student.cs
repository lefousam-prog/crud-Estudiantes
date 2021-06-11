using System;
using System.Collections.Generic;
using System.Text;

namespace class2
{

    public class Student
    {
        private string name;
        private string lastname;
        private int age;
        private int id;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public Student()
        {

        }


    }
}
