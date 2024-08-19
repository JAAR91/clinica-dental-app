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
    public partial class Patient : Form
    {
        public Patient()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string query = "insert into PatientTbl values('" + PatNameTb.Text + "','" + PatPhoneTb.Text + "','" + AddressTb.Text + "','" + DOBDate.Value.Date + "','" + GenCb.Text + "','" + AllergyTb.Text + " ')";
            DbConecction Pat = new DbConecction();

            try
            {
                Pat.SendStringRequest(query);
                MessageBox.Show("Paciente Agredado Exitosamente");
                populate();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }
        void populate()
        {
            DbConecction Pat = new DbConecction();
            string query = "Select * from PatientTbl";
            DataSet ds = Pat.ShowTableData(query);
            PatientDGV.DataSource = ds.Tables[0];
        }

        private void Patient_Load(object sender, EventArgs e)
        {
            populate();
        }
        int key = 0;
        private void PatientDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PatNameTb.Text = PatientDGV.SelectedRows[0].Cells[1].Value.ToString();
            PatPhoneTb.Text = PatientDGV.SelectedRows[0].Cells[2].Value.ToString();
            AddressTb.Text = PatientDGV.SelectedRows[0].Cells[3].Value.ToString();
            GenCb.SelectedItem = PatientDGV.SelectedRows[0].Cells[5].Value.ToString();
            AllergyTb.Text = PatientDGV.SelectedRows[0].Cells[6].Value.ToString();
            if (PatNameTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(PatientDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            DbConecction Pat = new DbConecction();
            if (key == 0)
            {
                MessageBox.Show("Seleccion un paciente!");
            }
            else
            {
                try
                {
                    string query = "Delete from PatientTbl where PatId=" + key + "";
                    Pat.SendStringRequest(query);
                    MessageBox.Show("Paciente Borrado");
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DbConecction Pat = new DbConecction();
            if (key == 0)
            {
                MessageBox.Show("Seleccion un paciente!");
            }
            else
            {
                try
                {
                    string query = "Update PatientTbl set PatName='" + PatNameTb.Text + "',PatPhone='" + PatPhoneTb.Text + "',PatAdd='" + AddressTb.Text + "',PatDOB='" + DOBDate.Value.Date + "',PatGender='" + GenCb.Text + "',PatAllergies='" + AllergyTb.Text + "' where PatId=" + key + ";";
                    Pat.SendStringRequest(query);
                    MessageBox.Show("Paciente Actualizado");
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }


        void filter()
        {
            DbConecction Pat = new DbConecction();
            string query = "Select * from PatientTbl where PatName like '%" + FilterTb.Text + "'";
            DataSet ds = Pat.ShowTableData(query);
            PatientDGV.DataSource = ds.Tables[0];
        }

        private void FilterTb_TextChanged(object sender, EventArgs e)
        {
            filter();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Treatment treatment = new Treatment();
            treatment.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Prescription pat = new Prescription();
            pat.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }
    }
}
    