using StudentManagerApp.Classes;
using StudentManagerApp.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StudentManagerApp
{
    public partial class MenuForm : Form
    {
        ShowMenu sm = ShowMenu.GetInstance();
        private StudentFuncImp sfi = StudentFuncImp.GetInstance();

        public MenuForm()
        {
            InitializeComponent();
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            RadioBtnFunc();
        }

        public void RadioBtnFunc()
        {
            if (AddStuBtn.Checked)
            {
                AddStuForm addForm = new AddStuForm();
                sm.showMainForm(this);
                addForm.Show();
            }
            else if (SearchStuBtn.Checked)
            {
                SearchStuForm searchForm = new SearchStuForm();
                sm.showMainForm(this);
                searchForm.Show();
            }
            else if (DelStuBtn.Checked)
            {
                DelStuForm delstuform = new DelStuForm();
                sm.showMainForm(this);
                delstuform.Show();
            }
            else if (ModiStuBtn.Checked)
            {
                ModifyStuForm modifystuform = new ModifyStuForm();
                sm.showMainForm(this);
                modifystuform.Show();
            }
            else if (DispAllBtn.Checked)
            {
                DisplayAllStuForm displayallstuform = new DisplayAllStuForm();
                sm.showMainForm(this);
                displayallstuform.Show();
            }
            else if (DelAllBtn.Checked)
            {
                removeAll();
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for using StudentManagerApplication");
            Application.Exit();
        }

        private void removeAll()
        {
            if (MessageBox.Show("Delete All students?", "Confirm Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                sfi.removeAll();
            }
        }
    }
}
