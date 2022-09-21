using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
     internal class AccionesComunes
    {
        public static  void Mensaje(string mensaje)
        {
            MessageBox.Show(mensaje,"¡¡AVISO!!",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }
        public static void LlenarCombo(string consulta, ComboBox combo, string id, string nombre)
        {
            DataTable dt;
            combo.Items.Clear();
            dt =CargarDatos.EjecutarSeleccion(consulta);
            if (dt==null)
            {
                return;
            }
            //Tarea
            DataRow dr = dt.NewRow();
            //Definimos la fila 
            dr[0] = 0; dr[1] = "TODOS";
            //Insertamos la fila en el registro 0
            dt.Rows.InsertAt(dr, 0);


            combo.DataSource = dt; 
            combo.DisplayMember = nombre;
            combo.ValueMember = id;
            
            


        }

}
 }