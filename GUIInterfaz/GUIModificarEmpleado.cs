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
    public partial class GUIModificarEmpleado : Form
    {
        public GUIModificarEmpleado()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                buscarEmpleado();
                txtTelefono.Enabled = true;
            }
            catch(Exception )
            {
                MessageBox.Show("No se ha podido encontrar"+"\n"+"El empleado","Aviso");
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Double telefono;
            int cedula;
            telefono = Convert.ToDouble(txtTelefono.Text);
            cedula = Convert.ToInt32(txtInfoBuscar.Text);
            ServicioArchivoEmpleado.modificarEmpleado(cedula, telefono);
            MessageBox.Show("Se modifico el telefono","Aviso");
        }

        public void buscarEmpleado()
        {
            int cedula;
            cedula = Convert.ToInt32(txtInfoBuscar.Text);
            Empleado em = ServicioArchivoEmpleado.buscarPorCedula(cedula);

            if (em == null)
            {
                MessageBox.Show("No esta el registro solicitado");
            }
            else
            {
                txtCedula.Text = em.getCedula().ToString();
                txtNombre.Text = em.getNombre();
                txtTelefono.Text = em.getTelefono().ToString();
                txtDireccion.Text = em.getDireccion();
            }

           
        }

        
    }
}
