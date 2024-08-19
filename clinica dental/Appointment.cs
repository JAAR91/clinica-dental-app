using Microsoft.VisualBasic;
using System;
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
    public partial class Appointment : Form
    {
        public Appointment()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        void populate()
        {
            DbConecction Pat = new DbConecction();
            string query = "Select * from ApointmentTbl";
            DataSet ds = Pat.ShowTableData(query);
            AppDGV.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "insert into ApointmentTbl values('" + AppPacient.Text + "','" + AppTreatment.Text + "','" + AppDate.Value.Date + "','" + AppTime.Value.TimeOfDay + "')";
            DbConecction Pat = new DbConecction();

            try
            {
                Pat.SendStringRequest(query);
                MessageBox.Show("Cita Agredada Exitosamente");
                populate();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        ConnectionString MyCon = new ConnectionString();
        private void fillPatient()
        {
            SqlConnection Con = MyCon.GetCon();
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select PatName from PatientTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("PatName", typeof(string));
            dt.Load(rdr);
            AppPacient.ValueMember = "PatName";
            AppPacient.DataSource = dt;
            Con.Close();
        }

        private void fillTreatment()
        {
            SqlConnection Con = MyCon.GetCon();
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select TreatName from TreatmentTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("TreatName", typeof(string));
            dt.Load(rdr);
            AppTreatment.ValueMember = "TreatName";
            AppTreatment.DataSource = dt;
            Con.Close();
        }

        private void Appointment_Load(object sender, EventArgs e)
        {
            fillPatient();
            fillTreatment();
            populate();
        }

        int key = 0;

        private void button3_Click(object sender, EventArgs e)
        {
            DbConecction Pat = new DbConecction();
            if (key == 0)
            {
                MessageBox.Show("Seleccion una Cita!");
            }
            else
            {
                try
                {
                    string query = "Update ApointmentTbl set Patient='" + AppPacient.Text + "',Treatment='" + AppTreatment.Text + "',ApDate='" + AppDate.Value.Date + "',ApTime='" + AppTime.Value.TimeOfDay + "' where ApId=" + key + ";";
                    Pat.SendStringRequest(query);
                    MessageBox.Show("Cita Actualizada");
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void AppDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AppPacient.Text = AppDGV.SelectedRows[0].Cells[1].Value.ToString();
            AppTreatment.Text = AppDGV.SelectedRows[0].Cells[2].Value.ToString();
            AppDate.Text = AppDGV.SelectedRows[0].Cells[3].Value.ToString();
            AppTime.Text = AppDGV.SelectedRows[0].Cells[4].Value.ToString();

            if (AppPacient.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(AppDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DbConecction Pat = new DbConecction();
            if (key == 0)
            {
                MessageBox.Show("Seleccion una cita!");
            }
            else
            {
                try
                {
                    string query = "Delete from ApointmentTbl where ApId=" + key + "";
                    Pat.SendStringRequest(query);
                    MessageBox.Show("Cita Borrada");
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
            string query = "Select * from ApointmentTbl where Patient like '%" + FilterTb.Text + "'";
            DataSet ds = Pat.ShowTableData(query);
            AppDGV.DataSource = ds.Tables[0];
        }

        private void FilterTb_TextChanged(object sender, EventArgs e)
        {
            filter();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Patient pat = new Patient();
            pat.Show();
            this.Hide();
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
    }
}
