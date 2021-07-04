using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

//Clase de Conexion del proyecto

namespace ASPChilectra
{
    public class conexion

    {
        protected SqlDataReader reader;
        protected SqlDataAdapter AdaptadorDatos;
        protected DataSet data;
        protected SqlConnection oconection = new SqlConnection();
        
        public conexion()
        {

        }

        public void conectar(string tabla)
        {
            string strConexion = ConfigurationManager.ConnectionStrings["chilectraConnectionString1"].ConnectionString;
            oconection.ConnectionString = strConexion;

            oconection.Open();
            AdaptadorDatos = new SqlDataAdapter("select * from "+tabla, strConexion);
            SqlCommandBuilder ejecutaComandos = new SqlCommandBuilder(AdaptadorDatos);
            Data = new DataSet();
            AdaptadorDatos.Fill(Data, tabla);
            oconection.Close();
        }

        public DataSet Data
        {
            set { data = value; }
            get { return data; }
        }
        public SqlDataReader DataReader
        {
            set { reader = value; }
            get { return reader; }
        }
    }
}



   
