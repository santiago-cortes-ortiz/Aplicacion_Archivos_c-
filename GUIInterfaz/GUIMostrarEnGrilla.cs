using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AplicacionArchivoEmpleado.Mundo;

namespace AplicacionArchivoEmpleado.GUIInterfaz
{
    public partial class GUIMostrarEnGrilla : Form
    {
        public GUIMostrarEnGrilla()
        {
            InitializeComponent();
        }

        private void button1Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {

            try
            {
                mostrarEmpleados();
            }
            catch(Exception ec)
            {
                MessageBox.Show("No ha seleccionado la ruta del archivo" +"\n"+ ec.Message,"Error");
            }

        }

        public void mostrarEmpleados()
        {
            ArrayList empleado = ServicioArchivoEmpleado.leerTodoGrilla();
            
            IEnumerator enumerador = empleado.GetEnumerator();
            grillaMostrar.Rows.Clear();

            for (int i = 0; i < empleado.Count; i++)
            {
                enumerador.MoveNext();
                Mundo.Empleado mostrar = (Empleado)enumerador.Current;
                grillaMostrar.Rows.Add();
                grillaMostrar.Rows[i].Cells[0].Value = mostrar.getCedula();
                grillaMostrar.Rows[i].Cells[1].Value = mostrar.getNombre();
                grillaMostrar.Rows[i].Cells[2].Value = mostrar.getTelefono();
                grillaMostrar.Rows[i].Cells[3].Value = mostrar.getDireccion();
            }
        }
        
    }
}
