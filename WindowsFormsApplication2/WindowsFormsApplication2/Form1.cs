using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }


        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (txt_Id.Text == "" & txtCampo.Text == "")
            {
                AccionesComunes.Mensaje("Llenar campos restantes");
            }
            else
            {
                AccionesComunes.LlenarCombo(txt_Consulta.Text, comboBox1, txt_Id.Text, txtCampo.Text);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            lbl_ID.Text = comboBox1.SelectedValue.ToString();
        }

        private void lvMostrar_Click(object sender, EventArgs e)
        {

            AccionesComunes.LlenarListView(txt_Consulta.Text, lv1MostrarConsulta);

        }

        private void dgvMostrar_Click(object sender, EventArgs e)
        {
            
            AccionesComunes.LlenarDataGridView(txt_Consulta.Text, dgvMostrarConsulta);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_Id.Text =="" & txtCampo.Text=="")
            {
                AccionesComunes.Mensaje("Llenar campos restantes");
            }
            else
            {
            AccionesComunes.LlenarListView(txt_Consulta.Text, lv1MostrarConsulta);
            AccionesComunes.LlenarDataGridView(txt_Consulta.Text, dgvMostrarConsulta);
            AccionesComunes.LlenarCombo(txt_Consulta.Text, comboBox1, txt_Id.Text, txtCampo.Text);
            }
           
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            int registrosafectados = 0;
            registrosafectados = CargarDatos.EjecturaConsulta(txt_Consulta.Text);
            AccionesComunes.Mensaje("Registros Afectados" + registrosafectados);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvMostrarConsulta.DataSource = "";
            lv1MostrarConsulta.Clear();
            txtCampo.Text = "";
            txt_Id.Text = "";
            comboBox1.Text = "";
            lbl_ID.Text = "";
        }

        private void dgvMostrarConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (txt_Id.Text== "")
            {
            txt_Id.Text = dgvMostrarConsulta.Columns[0].Name;
           
            }
            else
            {
                if(txtCampo.Text == "")
                {
txtCampo.Text = dgvMostrarConsulta.Columns[1].Name;
               
                }
                else
                {
                
                }
                
               
            }
            



        }

       
    }

}