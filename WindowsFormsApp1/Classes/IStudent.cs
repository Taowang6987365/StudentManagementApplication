using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagerApp
{
    interface IStudent
    {
        public bool save(Student student);
        public Student queryById(String id);
        public Student deleteById(String id);
        public List<Student> queryAll();
        public bool removeAll();
    }
}
