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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient();
            patient.Show();
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
            Prescription pres = new Prescription();
            pres.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        ConnectionString MyCon = new ConnectionString();

        private void Dashboard_Load(object sender, EventArgs e)
        {
            ApointmentLoader.Value = 100;
            PatientsLoader.Value = 100;
            UserLoader.Value = 100;
            NextApp.Value = 100;
            
            SqlConnection Con = MyCon.GetCon();
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from ApointmentTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            PendingText.Text = dt.Rows[0][0].ToString();

            SqlDataAdapter sda1 = new SqlDataAdapter("Select count(*) from PatientTbl", Con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            PacientesText.Text = dt1.Rows[0][0].ToString();


            SqlDataAdapter sda2 = new SqlDataAdapter("Select count(*) from UserTbl", Con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            UserText.Text = dt2.Rows[0][0].ToString();


            SqlDataAdapter sda3 = new SqlDataAdapter("Select min(ApDate) from ApointmentTbl", Con);
            DataTable dt3 = new DataTable();
            sda3.Fill(dt3);
            ApointementLabel.Text = dt3.Rows[0][0].ToString();
            Con.Close();
        }
    }
}
