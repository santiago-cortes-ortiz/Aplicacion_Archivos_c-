using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AplicacionArchivoEmpleado.Mundo;

namespace AplicacionArchivoEmpleado.GUIInterfaz
{
    public partial class GUIAgregarEmpleado : Form
    {
        public GUIAgregarEmpleado()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            int cedula;
            Double telefono;
            
            try {
                
                    cedula = Convert.ToInt32(txtCedula.Text);
            } 
            catch(Exception ec)
            {
                MessageBox.Show(ec.Message, "Error Cedula");
                return; 
            }

            try
            {
                telefono = Convert.ToDouble(txtTelefono.Text);
            }
            catch(Exception ec)
            {
                MessageBox.Show(ec.Message,"Error Telefono");
                return;

            }
            String nombre = txtNombre.Text.Trim();
            String estado = ServicioArchivoEmpleado.AC;
            
            String direccion = txtDireccion.Text;
            Mundo.Empleado nuevo = new Mundo.Empleado(cedula, nombre, telefono, direccion,estado);
            try
            {
                ServicioArchivoEmpleado.agregarArchivo(nuevo);
                MessageBox.Show("Se agrego el empleado", "Empleado");
            }
            catch(Exception ec)
            {
                MessageBox.Show("No ha seleccionado la ruta del archivo."+"\n"+ec.Message,"Error");
            }
           

        }

      
    }
}
