using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPChilectra
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalculo_Click(object sender, EventArgs e)
        {
            this.control.ConseguirRut();
            

            Calculo Calculo = new Calculo(this.control.ConseguirRut(),txtDireccion.Text,txtComuna.Text,cbtipificacion.SelectedValue,txtNombre.Text,int.Parse(txtLecturaAnterior.Text),int.Parse(txtLecturaActual.Text));
            txtconsumoActual.Text=Calculo.ConsumoActual().ToString();
            txtconsumoAnterior.Text = Calculo.ConsumoAnterior(cbtipificacion.SelectedValue).ToString();
            txtfechaPago.Text = Calculo.fechapago(cbtipificacion.SelectedValue);
            txtvalorUF.Text = Calculo.valorUF(txtfechaPago.Text).ToString();
            txtvalorPagar.Text = (Calculo.ValorKW*Calculo.factorclimatico(Calculo.mes(cbtipificacion.SelectedValue))*Calculo.ConsumoActual()*Calculo.valorUF(txtfechaPago.Text)).ToString();

            //agregamos los datos del cliente a la BD de la tabla Cliente
            Cliente objcliente = new Cliente("", "", "", "", "", 0, 0);
            objcliente.Rut = this.control.ConseguirRut();
            objcliente.Nombre = txtNombre.Text;
            objcliente.Direccion = txtDireccion.Text;
            objcliente.Tipificacion = cbtipificacion.SelectedValue;
            objcliente.Comuna = txtComuna.Text;
            objcliente.Lecturaactual = int.Parse(txtLecturaActual.Text);
            objcliente.Lecturaanterior = int.Parse(txtLecturaAnterior.Text);

            objcliente.agregar();


            //agregaos los datos de consumo a la tabla Consumo
            Consumo con = new Consumo("", 0.0, new DateTime(), 0);
            string fechPago = this.txtfechaPago.Text;
            DateTime oDate1 = Convert.ToDateTime(fechPago);
            int mes = oDate1.Month;
            con.Fecha = oDate1;
            con.ConsumoAnterior = double.Parse(this.txtconsumoAnterior.Text);
            con.Tipificacion = cbtipificacion.SelectedValue;
            con.MesPago = mes;
            con.agregar();


            //agregamos los datos de la Boleta  a la BD de la tabla Boleta

            Boleta bol = new Boleta("", new DateTime(), 0.0, 0.0, 0.0, 0.0);
            bol.Rut = this.control.ConseguirRut();
            string iDate = this.txtfechaPago.Text;
            DateTime oDate2 = Convert.ToDateTime(iDate);
            bol.Fecha = oDate2;
            bol.ValorUf = double.Parse(this.txtvalorUF.Text);
            bol.ConsumoActual = double.Parse(this.txtconsumoActual.Text);
            bol.ConsumoAnterior = double.Parse(this.txtconsumoAnterior.Text);
            bol.TotalaApagar = double.Parse(this.txtvalorPagar.Text);

            bol.agregar();


        }
    }
   
}