<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="controlrut.ascx.cs" Inherits="ASPChilectra.WebUserControl1" %>
<asp:TextBox ID="txtrut" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtrut" Display="Dynamic" ErrorMessage="*Ingrese Rut" ForeColor="Red">*Favor ingrese Rut</asp:RequiredFieldValidator>
&nbsp;
<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtrut" Display="Dynamic" ErrorMessage="*Ingrese un numero de rut Valido" ForeColor="Red" ValidationExpression="^(\d{2}\.\d{3}\.\d{3}-)([a-zA-Z]{1}$|\d{1}$)">*Ingrese Rut Valido(puntos y guion)</asp:RegularExpressionValidator>


