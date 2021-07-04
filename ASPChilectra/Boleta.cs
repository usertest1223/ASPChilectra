using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;


namespace ASPChilectra
{
    public class Boleta : conexion
    {
        string tabla = "BOLETAPRINCIPAL";
        protected string rut;
        protected DateTime fecha_pago;
        protected double valor_uf;
        protected double consumo_actual, consumo_anterior, total_a_pagar;


        public Boleta(string rut, DateTime fecha_pago, double valor_uf, double consumo_actual, double comsumo_anterior, double total_a_pagar)
        {
            this.rut = rut;
            this.fecha_pago = fecha_pago;
            this.valor_uf = valor_uf;
            this.consumo_actual = consumo_actual;
            this.consumo_anterior = comsumo_anterior;
            this.total_a_pagar = total_a_pagar;

        }

        public string Rut { get => rut; set => rut = value; }
        public DateTime Fecha { get => fecha_pago; set => fecha_pago = value; }
        public double ValorUf { get => valor_uf; set => valor_uf = value; }
        public double ConsumoActual { get => consumo_actual; set => consumo_actual = value;}
        public double ConsumoAnterior { get => consumo_anterior; set => consumo_anterior = value; }
        public double TotalaApagar { get => total_a_pagar; set => total_a_pagar = value; }



        public void agregar()
        {
            conectar(tabla);
            DataRow fila;
            fila = Data.Tables[tabla].NewRow();
            fila["rut"] = Rut;
            fila["fecha_pago"] = fecha_pago;
            fila["valor_uf"] = valor_uf;
            fila["consumo_actual"] = consumo_actual;
            fila["consumo_anterior"] = consumo_anterior;
            fila["total_a_pagar"] = total_a_pagar;

            Data.Tables[tabla].Rows.Add(fila);
            AdaptadorDatos.Update(Data, tabla);


        }
    }
}