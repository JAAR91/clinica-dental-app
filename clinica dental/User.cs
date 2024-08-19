using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clinica_dental
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        void populate()
        {
            DbConecction Pat = new DbConecction();
            string query = "Select * from UserTbl";
            DataSet ds = Pat.ShowTableData(query);
            UserDGV.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "insert into UserTbl values('" + Username.Text + "','" + Password.Text + "','" + Number.Text + "')";
            DbConecction Pat = new DbConecction();

            try
            {
                Pat.SendStringRequest(query);
                MessageBox.Show("Usuario Agredado Exitosamente");
                populate();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        int key = 0;

        private void UserDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Username.Text = UserDGV.SelectedRows[0].Cells[1].Value.ToString();
            Password.Text = UserDGV.SelectedRows[0].Cells[2].Value.ToString();
            Number.Text = UserDGV.SelectedRows[0].Cells[3].Value.ToString();

            if (Username.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(UserDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DbConecction Pat = new DbConecction();
            if (key == 0)
            {
                MessageBox.Show("Seleccion un usuario!");
            }
            else
            {
                try
                {
                    string query = "Update UserTbl set Uname='" + Username.Text + "',Upass='" + Password.Text + "',Phone='" + Number.Text + "' where Uid=" + key + ";";
                    Pat.SendStringRequest(query);
                    MessageBox.Show("Usuario Actualizado");
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DbConecction Pat = new DbConecction();
            if (key == 0)
            {
                MessageBox.Show("Seleccion un Usuario!");
            }
            else
            {
                try
                {
                    string query = "Delete from UserTbl where Uid=" + key + "";
                    Pat.SendStringRequest(query);
                    MessageBox.Show("Usuario Borrado");
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void User_Load(object sender, EventArgs e)
        {
            populate();
        }


        void filter()
        {
            DbConecction Pat = new DbConecction();
            string query = "Select * from UserTbl where Uname like '%" + FilterTb.Text + "'";
            DataSet ds = Pat.ShowTableData(query);
            UserDGV.DataSource = ds.Tables[0];
        }

        private void FilterTb_TextChanged(object sender, EventArgs e)
        {
            filter();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
