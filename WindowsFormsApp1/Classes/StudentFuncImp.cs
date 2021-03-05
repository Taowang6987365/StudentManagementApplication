using StudentManagerApp.Classes;
using StudentManagerApp.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace StudentManagerApp
{
    public class StudentFuncImp : IStudent
    {
        private static StudentFuncImp sfi;
        private StudentFuncImp() { }

        public static StudentFuncImp GetInstance()
        {
            if (sfi == null)
            {
                sfi = new StudentFuncImp();
            }
            return sfi;
        }

        public MenuForm menu = null;

        FileStream fs = null;
        StreamWriter sw = null;
        StreamReader sr = null;

        public Student deleteById(string id)
        {
            closeInfo();
            Student stu = null;
            int lineNum = 0;
            DelStuForm dsf = new DelStuForm();

            try
            {
                sr = new StreamReader(Constant.file);
                string hasRead = null;
                while((hasRead = sr.ReadLine())!=null)
                {
                    lineNum++;
                    if (hasRead.Split(Constant.spartor)[0] == Util.fillZero(id,Constant.ID_LENGTH))
                    {
                        stu = PackInfo(hasRead);
                        break;
                    }
                }
                
                closeInfo();
            }
            catch(Exception e)
            {
                dsf.ShowMsg(e.Message);
            }

            if(stu != null)
            {
                try
                {
                    List<string> lines = new List<string>(File.ReadAllLines(Constant.file));
                    lines.RemoveAt(lineNum-1);
                    File.WriteAllLines(Constant.file, lines.ToArray());
                }
                catch(IOException e)
                {
                    dsf.ShowMsg(e.Message);
                }
            }
            return stu;
        }

        public List<Student> queryAll()
        {
            DisplayAllStuForm das = new DisplayAllStuForm();
            List<Student> list = new List<Student>();
            List<string> newdata = new List<string>();
            try
            {
                Student stu = null;
                sr = new StreamReader(Constant.file);
                string hasRead = null;
                while((hasRead = sr.ReadLine()) != null)
                {
                    newdata.Clear();
                    string[] data = hasRead.Split(Constant.spartor);
                    for(int i = 0; i < data.Length;i++)
                    {
                        newdata.Add(data[i]);
                    }
                    stu = Util.packToStudent(newdata);
                    list.Add(stu);
                }
            }
            catch(Exception e)
            {
                das.ShowMsg(e.Message);
            }
            closeInfo();
            return list;
        }

        public Student queryById(string id)
        {
            closeInfo();
            Student stu = null;
            try
            {
                sr = new StreamReader(Constant.file);
                string hasRead = "";
                while((hasRead = sr.ReadLine())!=null)
                {
                    if(hasRead.Split(Constant.spartor)[0] == Util.fillZero(id,Constant.ID_LENGTH))
                    {
                        stu = PackInfo(hasRead);
                        break;
                    }
                }
                closeInfo();
                return stu;
            }
            catch(Exception e)
            {
                SearchStuForm ssf = new SearchStuForm();
                return null;
            }
        }

        public bool removeAll()
        {
            closeInfo();
            sw = new StreamWriter(Constant.file);
            closeInfo();
            return true;
        }

        public bool save(Student student)
        {
            closeInfo();
            string info = Util.packToString(student);
            try
            {
                sw = new StreamWriter(Constant.file, true);
                sw.WriteLine(info);
                closeInfo();
                return true;
            }
            catch(IOException e)
            {
                AddStuForm add = new AddStuForm();
                add.ShowMsg(e.Message);
                return false;
            }
        }

        private void closeInfo()
        {
            if(sw != null)
            {
                sw.Close();
            }
            if(sr != null)
            {
                sr.Close();
            }
            if(fs != null)
            {
                fs.Close();
            }
        }
        private static Student PackInfo(string hasRead)
        {
            Student stu;
            List<string> data = new List<string>();
            for (int i = 0; i < hasRead.Split(Constant.spartor).Length; i++)
            {
                data.Add(hasRead.Split(Constant.spartor)[i]);
            }
            stu = Util.packToStudent(data);
            return stu;
        }

       
    }
}
