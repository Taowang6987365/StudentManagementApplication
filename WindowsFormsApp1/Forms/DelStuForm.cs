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
    public partial class DelStuForm : Form
    {
        ShowMenu sm = ShowMenu.GetInstance();
        private StudentFuncImp sfi = StudentFuncImp.GetInstance();

        public DelStuForm()
        {
            InitializeComponent();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            sm.menu.Enabled = true;
            this.Close();
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string data = StuIdTextBox.Text;
            if(data == null || data.Trim().Equals(""))
            {
                MessageBox.Show("Please Enter ID");
            }
            else
            {
                Student stu = sfi.deleteById(Util.fillZero(data, Constant.ID_LENGTH));
                if (stu != null)
                {
                    string info = "";
                    string[] infos = Util.packToString(stu).Split(Constant.spartor);
                    info = "student: id = " + infos[0] +
                            ", name = " + infos[1] +
                            ", gender = " + infos[2] +
                            ", major = " + infos[3];

                    listBox1.Items.Add(info);
                    StuIdTextBox.Text = null;
                }
                else
                {
                    MessageBox.Show("Student Not Exist");
                    StuIdTextBox.Focus();
                }
            }

            
        }
        public void ShowMsg(string msg)
        {
            MessageBox.Show(msg);
        }
    }
}
