using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPChilectra
{
    public class Calculo
    {
        String rut, direccion, comuna, tipificacion, nombre;
        int lecturaanterior, lecturaactual;
       public const double valorKW = 0.09;



        public int ConsumoActual() {
            return this.Lecturaactual - this.Lecturaanterior;
        }


        public int ConsumoAnterior(String Tipificacion) {
            int consumo=0;
            switch (Tipificacion) {
                case "1a":
                        consumo = 2;
                        break;
                case "1d": 
                    consumo = 200;
                    break;
                case "1c":
                    consumo = 5;
                    break;


            }


            return consumo;
        }



        public String fechapago(String Tipificacion)
        {
            String fecha = "";
            switch (Tipificacion)
            {
                case "1a":

                    fecha="15-03-2011";
                    break;
                case "1d":

                    fecha = "22-04-2011";
                    break;
                case "1c":

                    fecha = "29-05-2011";
                    break;


            }


            return fecha;
        }



        public int mes(String Tipificacion)
        {
            int mes=0;
            switch (Tipificacion)
            {
                case "1a":

                    mes = 3;
                    break;
                case "1d":

                    mes = 4;
                    break;
                case "1c":

                    mes = 5;
                    break;


            }
            return mes;
        }

        public double valorUF(String fechapago) {
            double uf=0.0;
            switch (fechapago) {
                case "15-03-2011":
                    uf = 21603.25;
                    break;
                case "22-04-2011":
                    uf = 21610.11;
                    break;
                case "29-05-2011":
                    uf = 21616.97;
                    break;


            }


            return uf;
        }
        public double factorclimatico(int mes) {
            double factor = 0;
            switch (mes)
            {
                case 1:
                    factor = 2.00;
                    break;
                case 2:
                    factor = 2.01;
                    break;
                case 3:
                    factor = 2.02;
                    break;

                case 4:
                    factor = 2.04;
                    break;
                case 5:
                    factor = 2.10;
                    break;
                case 6:
                    factor = 2.00;
                    break;
                case 7:
                    factor = 1.04;
                    break;
                case 8:
                    factor = 1.04;
                    break;
                case 9:
                    factor = 1.02;
                    break;
                case 10:
                    factor = 1.02;
                    break;
                case 11:
                    factor = 1.01;
                    break;
                case 12:
                    factor = 1.00;
                    break;
            }
                    return factor;
        }





        public Calculo(string rut, string direccion, string comuna, string tipificacion, string nombre, int lecturaanterior, int lecturaactual)
        {
            this.Rut = rut;
            this.Direccion = direccion;
            this.Comuna = comuna;
            this.Tipificacion = tipificacion;
            this.Nombre = nombre;
            this.Lecturaanterior = lecturaanterior;
            this.Lecturaactual = lecturaactual;
        }

        public string Rut { get => rut; set => rut = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Comuna { get => comuna; set => comuna = value; }
        public string Tipificacion { get => tipificacion; set => tipificacion = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Lecturaanterior { get => lecturaanterior; set => lecturaanterior = value; }
        public int Lecturaactual { get => lecturaactual; set => lecturaactual = value; }

        public double ValorKW => valorKW;
    }

}