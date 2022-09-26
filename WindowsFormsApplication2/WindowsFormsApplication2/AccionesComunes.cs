using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
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
            combo.Text = "";
            DataTable dt;
            DataRow dr;
            dt =CargarDatos.EjecutarSeleccion(consulta);
            if (dt==null)
            {
                
            }
            combo.DataSource = dt; 
            combo.DisplayMember = nombre;
            combo.ValueMember = id;

            //Tarea
            dr = dt.NewRow();
            //Definimos la fila 
            dr[0] = 0; dr[1] = "Todos";
            //Insertamos la fila en el registro 0
            dt.Rows.InsertAt(dr,0);
            combo.SelectedIndex = 0;
              
        }
        public static object LlenarDataGridView(string consulta, DataGridView dgv )
        {
           DataTable dt = CargarDatos.EjecutarSeleccion(consulta);
           dgv.DataSource = dt;
           return dt;
        }


        public static object LlenarListView(String consulta,ListView lv)
        {
            DataTable dt = CargarDatos.EjecutarSeleccion(consulta);
            lv.GridLines = true;
            lv.View = View.Details;
            ListViewItem Agg;
            lv.Clear();
                  
                for (int j = 0; j< dt.Columns.Count; j++)
                { 
                    lv.Columns.Add(dt.Columns[j].ColumnName, 70);
                }

                for (int i = 0; i < dt.Rows.Count; i++)
                { 
                    DataRow dr=dt.Rows[i];
                  
                    Agg= new ListViewItem(dr[dt.Columns[0].ColumnName].ToString());
                    for (int c = 1; c < dt.Columns.Count; c++)
                    {

                        Agg.SubItems.Add(dr[dt.Columns[c].ColumnName].ToString());
                        
                    }
                    lv.Items.Add(Agg);
                }

            return dt;
        
        }
        public static object Limpiar(object objeto_a_limpiar)
        {


            return objeto_a_limpiar;
        }
     }
 }