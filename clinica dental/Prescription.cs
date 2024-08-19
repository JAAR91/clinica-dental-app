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
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace clinica_dental
{
    public partial class Prescription : Form
    {
        public Prescription()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "insert into PresciptionTbl values('" + Ppatient.Text + "','" + Ptreatment.Text + "','" + Pcost.Text + "','" + Pmeds.Text + "','" + Pquantity.Text + "')";
            DbConecction Pat = new DbConecction();

            try
            {
                Pat.SendStringRequest(query);
                MessageBox.Show("Prescripcion Agredada Exitosamente");
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
            Ppatient.Text = PrescriptionDGV.SelectedRows[0].Cells[1].Value.ToString();
            Ptreatment.Text = PrescriptionDGV.SelectedRows[0].Cells[2].Value.ToString();
            Pcost.Text = PrescriptionDGV.SelectedRows[0].Cells[3].Value.ToString();
            Pmeds.Text = PrescriptionDGV.SelectedRows[0].Cells[4].Value.ToString();
            Pquantity.Text = PrescriptionDGV.SelectedRows[0].Cells[5].Value.ToString();

            if (Ppatient.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(PrescriptionDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        void populate()
        {
            DbConecction Pat = new DbConecction();
            string query = "Select * from PresciptionTbl";
            DataSet ds = Pat.ShowTableData(query);
            PrescriptionDGV.DataSource = ds.Tables[0];
        }

        void filter()
        {
            DbConecction Pat = new DbConecction();
            string query = "Select * from PresciptionTbl where PatName like '%" + FilterTb.Text + "'";
            DataSet ds = Pat.ShowTableData(query);
            PrescriptionDGV.DataSource = ds.Tables[0];
        }

        ConnectionString MyCon = new ConnectionString();
        private void fillPatient()
        {
            SqlConnection Con = MyCon.GetCon();
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select Patient from ApointmentTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Patient", typeof(string));
            dt.Load(rdr);
            Ppatient.ValueMember = "Patient";
            Ppatient.DataSource = dt;
            Con.Close();
        }

        private void getTreatment()
        {
            SqlConnection Con = MyCon.GetCon();
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select * from ApointmentTbl where Patient='" + Ppatient.Text + "'", Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                Ptreatment.Text = dr["Treatment"].ToString();
            }
            Con.Close();
        }

        private void getPrice()
        {
            SqlConnection Con = MyCon.GetCon();
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select * from TreatmentTbl where TreatName='" + Ptreatment.Text + "'", Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                Pcost.Text = dr["TreatCost"].ToString();
            }
            Con.Close();
        }

        private void Prescription_Load(object sender, EventArgs e)
        {
            fillPatient();
            populate();
        }

        private void Ppatient_SelectedIndexChanged(object sender, EventArgs e)
        {
            getTreatment();
        }

        private void Ptreatment_TextChanged(object sender, EventArgs e)
        {
            getPrice();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DbConecction Pat = new DbConecction();
            if (key == 0)
            {
                MessageBox.Show("Seleccion una prescipcion!");
            }
            else
            {
                try
                {
                    string query = "Update PresciptionTbl set PatName='" + Ppatient.Text + "',TreatName='" + Ptreatment.Text + "',TreatCost='" + Pcost.Text + "',Medicines='" + Pmeds.Text + "',MedQty='" + Pquantity.Text + "' where PrescId=" + key + ";";
                    Pat.SendStringRequest(query);
                    MessageBox.Show("Prescipcion Actualizada");
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
                MessageBox.Show("Seleccion una prescipcion!");
            }
            else
            {
                try
                {
                    string query = "Delete from PresciptionTbl where PrescId=" + key + "";
                    Pat.SendStringRequest(query);
                    MessageBox.Show("Prescipcion Borrada");
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
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
