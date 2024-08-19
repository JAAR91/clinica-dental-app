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
    public partial class Treatment : Form
    {
        public Treatment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "insert into TreatmentTbl values('" + TreatName.Text + "','" + TreatCost.Text + "','" + TreatDesc.Text + "')";
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
            string query = "Select * from TreatmentTbl";
            DataSet ds = Pat.ShowTableData(query);
            TreactmentDGV.DataSource = ds.Tables[0];
        }

        private void Treatment_Load(object sender, EventArgs e)
        {
            populate();
        }

        int key = 0;

        private void button3_Click(object sender, EventArgs e)
        {
            DbConecction Pat = new DbConecction();
            if (key == 0)
            {
                MessageBox.Show("Seleccion un tratamiento!");
            }
            else
            {
                try
                {
                    string query = "Update TreatmentTbl set TreatName='" + TreatName.Text + "',TreatCost='" + TreatCost.Text + "',TreatDesc='" + TreatDesc.Text + "' where TreatId=" + key + ";";
                    Pat.SendStringRequest(query);
                    MessageBox.Show("Tratamiento Actualizado");
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
                MessageBox.Show("Seleccion un Tratamiento!");
            }
            else
            {
                try
                {
                    string query = "Delete from TreatmentTbl where TreatId=" + key + "";
                    Pat.SendStringRequest(query);
                    MessageBox.Show("Tratamiento Borrado");
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void TreactmentDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TreatName.Text = TreactmentDGV.SelectedRows[0].Cells[1].Value.ToString();
            TreatCost.Text = TreactmentDGV.SelectedRows[0].Cells[2].Value.ToString();
            TreatDesc.Text = TreactmentDGV.SelectedRows[0].Cells[3].Value.ToString();

            if (TreatName.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(TreactmentDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        void filter()
        {
            DbConecction Pat = new DbConecction();
            string query = "Select * from TreatmentTbl where TreatName like '%" + FilterTb.Text + "'";
            DataSet ds = Pat.ShowTableData(query);
            TreactmentDGV.DataSource = ds.Tables[0];
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
