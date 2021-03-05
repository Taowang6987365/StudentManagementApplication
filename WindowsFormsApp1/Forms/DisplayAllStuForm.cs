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
    public partial class DisplayAllStuForm : Form
    {
        ShowMenu sm = ShowMenu.GetInstance();
        private StudentFuncImp sfi = StudentFuncImp.GetInstance();

        public DisplayAllStuForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sm.menu.Enabled = true;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<Student> list = sfi.queryAll();
            if(list.Count > 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    string info = "";
                    string[] infos = Util.packToString(list[i]).Split(Constant.spartor);
                    info = "student: id = " + infos[0] +
                            ", name = " + infos[1] +
                            ", gender = " + infos[2] +
                            ", major = " + infos[3];
                    listBox1.Items.Add(info);
                }
            }
            else
            {
                ShowMsg("No student");
            }
        }
        public void ShowMsg(string msg)
        {
            MessageBox.Show(msg);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
