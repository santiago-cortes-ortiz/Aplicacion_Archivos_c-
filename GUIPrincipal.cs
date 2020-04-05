using AplicacionArchivoEmpleado.GUIInterfaz;
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

namespace AplicacionArchivoEmpleado
{
    public partial class GUIPrincipal : Form
    {
        public GUIPrincipal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void registrarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUIAgregarEmpleado gui;
            gui = new GUIAgregarEmpleado();
            gui.Show();
        }

        

        private void btnDireccion_Click(object sender, EventArgs e)
        {
            ofdArchivo.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";
            ofdArchivo.FilterIndex = 1;
            ofdArchivo.Multiselect = false;
            ofdArchivo.ShowDialog();
            txtArchivo.Text = ofdArchivo.FileName;
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String archivo;
            archivo = txtArchivo.Text;
            ServicioArchivoEmpleado.setArchivo(archivo);
            MessageBox.Show("Se ha seleccionado la direccion de entrada","Aviso");
        }

        private void mostrarGrillaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUIMostrarEnGrilla gui;
            gui = new GUIMostrarEnGrilla();
            gui.Show();
        }

        private void buscarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUIBuscarEmpleado gui;
            gui = new GUIBuscarEmpleado();
            gui.Show();
        }

        private void modificarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUIModificarEmpleado gui;
            gui = new GUIModificarEmpleado();
            gui.Show();
        }

        private void eliminarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUIEliminarEmpleado gui;
            gui = new GUIEliminarEmpleado();
            gui.Show();
        }
    }
}
