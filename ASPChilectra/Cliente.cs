using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;


namespace ASPChilectra
{
    public class Cliente: conexion
    {
        string tabla = "CLIENTE";
        protected string rut, nombre, direccion, comuna, tipificacion;
        protected int lectura_anterior, lectura_actual;



        public Cliente(string rut, string nombre, string direccion, string comuna, string tipificacion, int lectura_anterior, int lectura_actual)
        {
            this.rut = rut;
            this.nombre = nombre;
            this.direccion = direccion;
            this.comuna = comuna;
            this.tipificacion = tipificacion;
            this.lectura_actual = lectura_actual;
            this.lectura_anterior = lectura_anterior;

        }

        public string Rut { get => rut; set => rut = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Comuna { get => comuna; set => comuna = value; }
        public string Tipificacion { get => tipificacion; set => tipificacion = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Lecturaanterior { get => lectura_anterior; set => lectura_anterior = value; }
        public int Lecturaactual { get => lectura_actual; set => lectura_actual = value; }


        public void agregar()
        {
            conectar(tabla);
            DataRow fila;
            fila = Data.Tables[tabla].NewRow();
            fila["rut"]= Rut;
            fila["nombre"] = nombre;
            fila["direccion"] = direccion;
            fila["comuna"] = comuna;
            fila["tipificacion"] = tipificacion;
            fila["lectura_actual"] = lectura_actual;
            fila["lectura_anterior"] = lectura_anterior;
            

            Data.Tables[tabla].Rows.Add(fila);
            AdaptadorDatos.Update(Data, tabla);

           
        }
    }
}