using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagerApp
{
    public class Constant
    {
        public static readonly string file = "stu.txt";
        public static readonly string spartor = ",";
        public static readonly int ID_LENGTH = 6;
        public static readonly int NAME_LENGTH = 10;
        public static readonly int GENDER_LENGTH = 6;
        public static readonly int MAJOR_LENGTH = 20;
        public static readonly int LINE_LENGTH = ID_LENGTH + NAME_LENGTH + GENDER_LENGTH + MAJOR_LENGTH;
    }
}
