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
    public partial class SearchStuForm : Form
    {
        ShowMenu sm = ShowMenu.GetInstance();
        private StudentFuncImp sfi = StudentFuncImp.GetInstance();
        public SearchStuForm()
        {
            InitializeComponent();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string data = StuIDTextBox.Text;
            if(data == null || data.Trim().Equals(""))
            {
                MessageBox.Show("Please Enter ID");
            }

            Student stu = sfi.queryById(Util.fillZero(data, Constant.ID_LENGTH));
            if(stu != null)
            {
                string info = "";
                string[] infos = Util.packToString(stu).Split(Constant.spartor);
                info = "student: id = " + infos[0] +
                        ", name = " + infos[1] +
                        ", gender = " + infos[2] +
                        ", major = " + infos[3];

                listBox1.Items.Add(info);
            }
            else
            {
                MessageBox.Show("Not Found!");
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            sm.menu.Enabled = true;
            this.Close();
        }

        public void ShowMsg(string msg)
        {
            MessageBox.Show(msg);
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
