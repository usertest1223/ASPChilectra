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
        }
    }
   
}