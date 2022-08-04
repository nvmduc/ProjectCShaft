﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectCShaft
{
    public partial class frmLogin : MetroFramework.Forms.MetroForm
    {
        ProjectCShaftDataContext db = new ProjectCShaftDataContext();
        public frmLogin()
        {
            InitializeComponent();
        }




        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private bool Login(string username,string password)
        {
            var q = from p in db.Accounts where p.username == txtUserName.Text && p.password == txtPassword.Text select p;

            if (q.Any())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            #region remember
                if (checkBoxRemember.Checked)
                {
                    ProjectCShaft.Properties.Settings.Default.username = txtUserName.Text;
                    ProjectCShaft.Properties.Settings.Default.password = txtPassword.Text;
                    ProjectCShaft.Properties.Settings.Default.Save();
                }
            #endregion
            if (Login(txtUserName.Text,txtPassword.Text))
            {
                
                frmMain frmMain = new frmMain();
                this.Hide();
                frmMain.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai thông tin tài khoản");
            }
            
        }

        
    }
}
