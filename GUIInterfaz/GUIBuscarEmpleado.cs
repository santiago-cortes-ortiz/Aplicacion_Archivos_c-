using System;
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
    public partial class GUIBuscarEmpleado : Form
    {
        public GUIBuscarEmpleado()
        {
            InitializeComponent();
        }

        private void button2Buscar_Click(object sender, EventArgs e)
        {

            try
            {
                buscar();
            } catch (IOException ex)
            {

                MessageBox.Show("No esta el registro solicitado", ex.Message);
                return;
            }
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void buscar()
        {
            int numero_registro;
            numero_registro = Convert.ToInt32(txtNumeroDeRegistro.Text);
            
            Empleado em;
            em = ServicioArchivoEmpleado.buscarPorNumeroRegistro(numero_registro);
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

        private void button2_Click(object sender, EventArgs e)
        {
            FileStream fs;
            String archivo = ServicioArchivoEmpleado.getArchivo();
            if ((fs = new FileStream(archivo, FileMode.Open)) == null)
            {
                throw new IOException("No se puede abrir o leer el archivo.");
            }

            MessageBox.Show("Val =" + fs.Length);
            fs.Close();

        }
    }
}
