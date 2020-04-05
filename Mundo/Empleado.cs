using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionArchivoEmpleado.Mundo
{
    public class Empleado
    {
        private int cedula;

        private String nombre;

        private Double telefono;

        private String direccion;

        private String estado;

        public Empleado(int cedula, string nombre, double telefono, string direccion, String estado)
        {
            this.cedula = cedula;
            this.nombre = nombre;
            this.telefono = telefono;
            this.direccion = direccion;
            this.estado = estado;
        }

        public int getCedula()
        {
            return cedula;
        }

        public void setCedula(int cedula)
        {
            this.cedula = cedula;
        }

        public String getNombre()
        {
            return nombre;
        }

        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }

        public Double getTelefono()
        {
            return telefono;
        }
        public void setTelefono(Double telefono)
        {
            this.telefono = telefono;
        }

        public void setCedula(Double telefono)
        {
            this.telefono = telefono;
        }

        public String getDireccion()
        {
            return direccion;
        }

        public void setDireccion(String direccion)
        {
            this.direccion = direccion;
        }

        public String getEstado()
        {
            return estado;
        }

        public void setEstado(String estado)
        {
            this.estado = estado;
        }

    }
}
