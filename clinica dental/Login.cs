﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clinica_dental
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            AdminLogin login = new AdminLogin();
            login.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        ConnectionString MyCon = new ConnectionString();

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection Con = MyCon.GetCon();
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from UserTbl where Uname='" + Uname.Text + "' and Upass='" + Upassword.Text + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                Appointment appointment = new Appointment();
                appointment.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contrasena incorrectow");
            }

            Con.Close();
        }
    }
}
