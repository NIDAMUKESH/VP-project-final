﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winSchoolMS
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

       

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmDashBoard obj = new frmDashBoard();
            obj.Show();
        }

        private void lblCreateanAccount_Click_1(object sender, EventArgs e)
        {
            frmSignUp obj = new frmSignUp();
            obj.Show();
        }

 
    }
}
