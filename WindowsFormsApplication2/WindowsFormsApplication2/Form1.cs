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
           
            int registrosafectados = 0;
            registrosafectados = CargarDatos.EjecturaConsulta(txt_Consulta.Text);
            AccionesComunes.Mensaje("Registros Afectados" + registrosafectados);
            AccionesComunes.LlenarCombo(txt_Consulta.Text, comboBox1, "id_Articulos", "nombre");
            lbl_ID.Text = "0";

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_ID.Text = comboBox1.SelectedValue.ToString();
        }
    }
}
