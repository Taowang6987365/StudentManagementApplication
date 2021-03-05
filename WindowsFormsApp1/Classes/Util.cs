using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagerApp.Classes
{
    public class Util
    {
        public static Student packToStudent(List<string> data)
        {
            Student stu = null;
            if (data == null)
            {
                return null;
            }
            string id = data[0];
            string name = data[1];
            string gender = data[2];
            string major = data[3];

            stu = new Student(id, name, gender, major);
            return stu;
        }

        public static string packToString(Student student)
        {
            string info = null;

            string id = fillZero(student.Id, Constant.ID_LENGTH);
            string name = fillSpace(student.Name, Constant.NAME_LENGTH);
            string gender = fillSpace(student.Gender, Constant.GENDER_LENGTH);
            string major = fillSpace(student.Major, Constant.MAJOR_LENGTH);

            StringBuilder sb = new StringBuilder();
            sb.Append(id);
            sb.Append(Constant.spartor);
            sb.Append(name);
            sb.Append(Constant.spartor);
            sb.Append(gender);
            sb.Append(Constant.spartor);
            sb.Append(major);

            info = sb.ToString();
            return info;
        }

        public static string fillZero(string id, int length)
        {
            if(id.Length == length)
            {
                return id;
            }
            while(id.Length < length)
            {
                id = "0" + id;
            }
            return id;
        }

        public static string fillSpace(String data, int length)
        {
            if (data.Length == length)
            {
                return data;
            }
            while(data.Length < length)
            {
                data += " ";
            }
            return data;
        }
    }
}
