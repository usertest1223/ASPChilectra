using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace ASPChilectra
{
    public class Consumo: conexion
    {
        string tabla = "CONSUMO";
        protected string tipificacion;
        protected double consumo_anterior;
        protected DateTime fecha_pago;
        protected int mes_pago;

        public Consumo(string tipificacion, double consumo_anterior, DateTime fecha_pago, int mes_pago)
        {
            this.tipificacion = tipificacion;
            this.consumo_anterior = consumo_anterior;
            this.fecha_pago = fecha_pago;
            this.mes_pago = mes_pago;
        }

        public string Tipificacion { get => tipificacion; set => tipificacion = value; }
        public double ConsumoAnterior { get => consumo_anterior; set => consumo_anterior = value; }
        public DateTime Fecha { get => fecha_pago; set => fecha_pago = value; }
        public int MesPago { get => mes_pago; set => mes_pago = value; }

        public void agregar()
        {
            conectar(tabla);
            DataRow fila;
            fila = Data.Tables[tabla].NewRow();
            fila["tipificacion"] = tipificacion;
            fila["consumo_anterior"] = consumo_anterior;
            fila["fecha_pago"] = fecha_pago;
            fila["mes_pago"] = mes_pago;
            Data.Tables[tabla].Rows.Add(fila);
            AdaptadorDatos.Update(Data, tabla);
        }

    }
}