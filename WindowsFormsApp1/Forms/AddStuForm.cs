using StudentManagerApp.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StudentManagerApp
{
    public partial class AddStuForm : Form
    {
        ShowMenu sm = ShowMenu.GetInstance();
        private StudentFuncImp sfi = StudentFuncImp.GetInstance();
        public AddStuForm()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            sm.menu.Enabled = true;
            this.Close();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            StuIDTextBox.Focus();
            List<string> str = new List<string>();
            str.Add(Util.fillZero(StuIDTextBox.Text, Constant.ID_LENGTH));
            str.Add(Util.fillSpace(StuNameTextBox.Text,Constant.NAME_LENGTH));
            str.Add(Util.fillSpace(GenderTextBox.Text,Constant.GENDER_LENGTH));
            str.Add(Util.fillSpace(MajorTextBox.Text,Constant.MAJOR_LENGTH));

            StringBuilder sb = new StringBuilder();
            for(int i = 0;i < str.Count-1;i++)
            {
                sb.Append(str[i]);
                sb.Append(Constant.spartor);
            }
            sb.Append(str[str.Count-1]);

            if(sfi.queryById(StuIDTextBox.Text) == null)
            {
                Student stu = Util.packToStudent(str);
                if (!validInformation(sb.ToString()))
                {
                    MessageBox.Show("Invalid Input !");
                    ResetInput();
                }
                else
                {
                    if (sfi.save(stu))
                    {
                        MessageBox.Show("Added Successfully !");
                        ResetInput();
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
        
        private void ResetInput()
        {
            StuIDTextBox.Clear();
            StuNameTextBox.Clear();
            GenderTextBox.Text = null;
            MajorTextBox.Clear();
        }

        public void ShowMsg(string msg)
        {
            MessageBox.Show(msg);
        }

    }
}
