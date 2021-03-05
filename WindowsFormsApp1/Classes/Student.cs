using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagerApp
{
    public class Student
    {
        private string id;
        private string name;
        private string gender;
        private string major;

        public Student(string id, string name, string gender, string major)
        {
            this.id = id;
            this.name = name;
            this.gender = gender;
            this.major = major;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Major { get => major; set => major = value; }

    }
}
