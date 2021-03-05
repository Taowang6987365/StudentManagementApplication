using StudentManagerApp.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StudentManagerApp.Forms
{
    public partial class ModifyStuForm : Form
    {
        ShowMenu sm = ShowMenu.GetInstance();
        private StudentFuncImp sfi = StudentFuncImp.GetInstance();

        public ModifyStuForm()
        {
            InitializeComponent();
        }

        private void ModifyStuForm_Load(object sender, EventArgs e)
        {
            FormEnable(false);
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            sm.menu.Enabled = true;
            this.Close();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string data = studentIDTextBox.Text;
            if (data == null || data.Trim().Equals(""))
            {
                MessageBox.Show("Please Enter Correct ID");
            }
            Student stu = sfi.queryById(data);
            FormEnable(true);
            studentNameTextBox.Text = stu.Name;
            GenderTextBox.Text = stu.Gender;
            MajorTextBox.Text = stu.Major;
        }

        private void FormEnable(bool val)
        {
            studentNameTextBox.Enabled = val;
            GenderTextBox.Enabled = val;
            MajorTextBox.Enabled = val;
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            string data = studentIDTextBox.Text;
            if (data == null || data.Trim().Equals(""))
            {
                MessageBox.Show("Please Enter Correct ID");
            }
            Student stu = sfi.deleteById(data);

            List<string> str = new List<string>();
            str.Add(Util.fillZero(studentIDTextBox.Text, Constant.ID_LENGTH));
            str.Add(Util.fillSpace(studentNameTextBox.Text, Constant.NAME_LENGTH));
            str.Add(Util.fillSpace(GenderTextBox.Text, Constant.GENDER_LENGTH));
            str.Add(Util.fillSpace(MajorTextBox.Text, Constant.MAJOR_LENGTH));

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < str.Count - 1; i++)
            {
                sb.Append(str[i]);
                sb.Append(Constant.spartor);
            }
            sb.Append(str[str.Count - 1]);

            if (sfi.queryById(studentIDTextBox.Text) == null)
            {
                Student student = Util.packToStudent(str);
                if (!validInformation(sb.ToString()))
                {
                    MessageBox.Show("Invalid Input !");
                }
                else
                {
                    if (sfi.save(student))
                    {
                        MessageBox.Show("Updated Successfully !");
                    }
                }
            }
            else
            {
                MessageBox.Show("Student ID exsisted!");
            }
        }

        private bool validInformation(string data)
        {
            String[] newData = data.Split(Constant.spartor);
            if (newData.Length != 4
                || newData[0].Length > Constant.ID_LENGTH
                || newData[1].Length > Constant.NAME_LENGTH
                || newData[2].Length > Constant.GENDER_LENGTH
                || newData[3].Length > Constant.MAJOR_LENGTH)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
