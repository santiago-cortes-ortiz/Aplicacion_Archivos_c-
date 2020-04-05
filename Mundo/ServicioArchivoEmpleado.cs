using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionArchivoEmpleado.Mundo
{
    public class ServicioArchivoEmpleado
    {

        private static Empleado empleado;

        private static String archivo;

        public static String AC = "AC        ";
        public static String NA = "NA        ";



        public static String getArchivo()
        {
            return archivo;
        }

        public static void setArchivo(String pArchivo)
        {
            archivo = pArchivo;
        }

        public static String formatearCadena(String cad)
        {
            if (cad.Length > 10)
            {
                return cad.Substring(0, 10);
            }
            while (cad.Length < 10)
            {
                cad += " ";
            }
            return cad;
        }

        public static void agregarArchivo(Empleado empleado)
        {
            FileStream fs;
            BinaryWriter br;

            fs = new FileStream(archivo,FileMode.Append);
            br = new BinaryWriter(fs, Encoding.UTF8);

            br.Write(empleado.getCedula());
            br.Write(formatearCadena(empleado.getNombre()));         
            br.Write(empleado.getTelefono());          
            br.Write(formatearCadena(empleado.getDireccion()));
            br.Write(formatearCadena(empleado.getEstado()));

            br.Close();
            fs.Close();

        }

        public static ArrayList leerTodoGrilla()
        {
            FileStream fs;
            BinaryReader br;          
            ArrayList empleados = new ArrayList();           
            int cedula;
            String nombre;
            Double telefono;
            String direccion;
            String estado;

            
            
            if ((fs = new FileStream(archivo, FileMode.Open))==null)
            {
                throw new IOException("No ha seleccionado la ubicacion");
            }
            br = new BinaryReader(fs, Encoding.UTF8);
            while (br.BaseStream.Position != br.BaseStream.Length )
            {
                cedula = br.ReadInt32();
                nombre = br.ReadString();
                telefono = br.ReadDouble();
                direccion = br.ReadString();
                estado = br.ReadString();

                if (estado.Equals(AC))
                {
                    empleados.Add(new Empleado(cedula, nombre, telefono, direccion, estado));
                }
            }
            br.Close();
            fs.Close();
            return empleados;     
        }

        

        public static Empleado buscarPorNumeroRegistro(int N_Registro)
        {

            Empleado em;         
            FileStream fs;
            BinaryReader br;

            int cedula;
            String nombre;
            Double telefono;
            String direccion;
            String estado;
            // formula n = n -1

            N_Registro = N_Registro - 1;

            fs = new FileStream(archivo, FileMode.Open);
            br = new BinaryReader(fs, Encoding.UTF8);
           
            if ((N_Registro * 45) > fs.Length)
            {
                br.Close();
                fs.Close();

                throw new IOException("F");
               
            }
            else
            {
                fs.Seek(N_Registro * 45, SeekOrigin.Begin);

                cedula = br.ReadInt32();
                nombre = br.ReadString();
                telefono = br.ReadDouble();
                direccion = br.ReadString();
                estado = br.ReadString();

                if (estado.Equals(NA))
                {
                    em = null;
                }
                else
                {
                    em = new Empleado(cedula, nombre, telefono, direccion, estado);
                }
               
                br.Close();
                fs.Close();
            }

            
            return em;

         
        }

        public static Empleado buscarPorCedula(int cedulaBuscar)
        {
            Empleado encontrado = null;
            FileStream fs;
            BinaryReader br;
            bool centinela = false;

            int cedula;
            String nombre;
            Double telefono;
            String direccion;
            String estado;

            fs = new FileStream(archivo, FileMode.Open);
            br = new BinaryReader(fs,Encoding.UTF8);

            while (br.BaseStream.Length != br.BaseStream.Position && !centinela)
            {
                cedula = br.ReadInt32();
                nombre = br.ReadString();
                telefono = br.ReadDouble();
                direccion = br.ReadString();
                estado = br.ReadString();

                if (estado == NA)
                {

                    encontrado = null;                   
                }

                if (cedula == cedulaBuscar)
                {
                    centinela = true;
                    encontrado = new Empleado(cedula, nombre, telefono, direccion,estado);
                }
                
            }


            br.Close();
            fs.Close();

            return encontrado;
        }

       
        public static void eliminarEmpleado(int N_Registro)
        {


            FileStream fs;
            BinaryReader br;
            BinaryWriter bwr;



            N_Registro = N_Registro - 1;

            fs = new FileStream(archivo, FileMode.Open);
            br = new BinaryReader(fs, Encoding.UTF8);
            bwr = new BinaryWriter(fs, Encoding.UTF8);

            
            fs.Seek((N_Registro * 45) + 34, SeekOrigin.Begin);
            
            

            bwr.Write(NA);

   
            br.Close();
            bwr.Close();
            fs.Close();


        }

        public static void modificarEmpleado(int cedulaBuscar, double telefonoNuevo)
        {

            FileStream fs;
            BinaryReader br;
            BinaryWriter bwr;

            bool centinela = false;
            int cedula;
            String nombre;
            Double telefono;
            String direccion;
            String estado;

            fs = new FileStream(archivo, FileMode.Open);
            br = new BinaryReader(fs, Encoding.UTF8);
            bwr = new BinaryWriter(fs, Encoding.UTF8);
            int N_Registro = 0;
            while (br.BaseStream.Length != br.BaseStream.Position && !centinela)
            {
                
                cedula = br.ReadInt32();
                nombre = br.ReadString();
                telefono = br.ReadDouble();
                direccion = br.ReadString();
                estado = br.ReadString();
 

                if (cedula == cedulaBuscar)
                {
                    centinela = true;
                    fs.Seek((N_Registro * 45) + 15, SeekOrigin.Begin);
                    bwr.Write(telefonoNuevo);

                }

                N_Registro++;

            }


            br.Close();
            bwr.Close();
            fs.Close();

        }

























        /** public static String leerTodo()
        {
            FileStream fs;
            BinaryReader br;
            String cadena;

            int cedula;
            String nombre;
            Double telefono;
            String direccion;
            cadena = "";

            fs = new FileStream(archivo,FileMode.Open);
            br = new BinaryReader(fs,Encoding.UTF8);

            

            while (br.BaseStream.Position != br.BaseStream.Length)
            {
                cedula = br.ReadInt32();              
                nombre = br.ReadString();             
                telefono = br.ReadDouble();               
                direccion = br.ReadString();
                cadena += Environment.NewLine + cedula +   nombre +   telefono + direccion;
            }

              

            br.Close();
            fs.Close();

            return cadena;

        }
    */





    }
}
