<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FRMboletachilectra.aspx.cs" Inherits="ASPChilectra.WebForm1" %>



<%@ Register src="controlrut.ascx" tagname="controlrut" tagprefix="uc2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Boleta Chilectra</title>
     <link href="estilos.css" rel="stylesheet" type="text/css">
</head>


<body>

    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td class="titulo" colspan="2">BOLETA DE CHILECTRA</td>
                </tr>
                <tr>
                    <td class="bold">DATOS CLIENTE</td>
                    <td class="auto-style">&nbsp;</td>
                </tr>
                <tr>
                    <td class="textbox">Ingrese Rut Cliente
                        <uc2:controlrut ID="control" runat="server" />
                    </td>
                    <td class="auto-style">Tipificacion<asp:DropDownList ID="cbtipificacion" runat="server" Height="16px" style="margin-left: 40px" Width="153px">
                <asp:ListItem>1c</asp:ListItem>
                <asp:ListItem>1a</asp:ListItem>
                <asp:ListItem>1d</asp:ListItem>
            </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="textbox">Nombre del cliente<asp:TextBox ID="txtNombre" runat="server" style="margin-left: 11px" Width="121px"></asp:TextBox>
            &nbsp;&nbsp;
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*Favor ingrese el nombre" ControlToValidate="txtNombre" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style">Lectura Anterior(KW)<asp:TextBox ID="txtLecturaAnterior" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtLecturaAnterior" ErrorMessage="*Favor ingrese la lectura anterior" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
        &nbsp;&nbsp;&nbsp;
            <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtLecturaAnterior" ErrorMessage="*Favor ingrese valores entre 1 a 150" MaximumValue="150" MinimumValue="1" Display="Dynamic" ForeColor="Red" Type="Integer"></asp:RangeValidator>
        &nbsp; </td>
                </tr>
                <tr>
                    <td class="textbox">Direccion<asp:TextBox ID="txtDireccion" runat="server" style="margin-left: 64px" Width="126px"></asp:TextBox>
            
            &nbsp;&nbsp;
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*Favor ingrese la Direccion" ControlToValidate="txtDireccion" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style">Lectura Actual(KW)<asp:TextBox ID="txtLecturaActual" runat="server" Width="125px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtLecturaActual" ErrorMessage="*Favor Ingrese la lectura actual" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RangeValidator ID="RangeValidator2" runat="server" ControlToValidate="txtLecturaActual" ErrorMessage="*La lectura actual debe ser entre 1 a 150" MaximumValue="150" MinimumValue="1" ForeColor="Red" Type="Integer"></asp:RangeValidator>
                    </td>
                </tr>
                <tr>
                    <td class="textbox">Comuna<asp:TextBox ID="txtComuna" runat="server" style="margin-left: 69px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*Favor ingrese la comuna" ControlToValidate="txtComuna" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style">&nbsp;</td>
                </tr>
                <tr>
                    <td class="textbox">&nbsp;</td>
                    <td class="auto-style">
            <asp:Button ID="btnCalculo" class="button" runat="server" OnClick="btnCalculo_Click" style="margin-left: 52px" Text="Calcular" Width="110px" />
                    </td>
                </tr>
                <tr>
                    <td class="textbox">&nbsp;</td>
                    <td class="auto-style">&nbsp;</td>
                </tr>
                <tr>
                    <td class="textbox">DETALLE BOLETA</td>
                    <td class="auto-style">&nbsp;</td>
                </tr>
                <tr>
                    <td class="textbox">
            <asp:Label ID="Label1" runat="server" Text="Fecha de pago"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtfechaPago" runat="server" Enabled="False"></asp:TextBox>
                    </td>
                    <td class="auto-style">
            <asp:Label ID="Label3" runat="server" Text="Consumo actual(KW)"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtconsumoActual" runat="server" Enabled="False"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="textbox">
            <asp:Label ID="Label2" runat="server" Text="Valor uf a la fecha"></asp:Label>
            &nbsp;<asp:TextBox ID="txtvalorUF" runat="server" Enabled="False"></asp:TextBox>
                    </td>
                    <td class="auto-style">
            <asp:Label ID="Label4" runat="server" Text="Consumo anterior(KW)"></asp:Label>
            &nbsp;<asp:TextBox ID="txtconsumoAnterior" runat="server" Enabled="False"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="textbox">&nbsp;</td>
                    <td class="auto-style">&nbsp;</td>
                </tr>
                <tr>
                    <td class="textbox">VALOR A PAGAR</td>
                    <td class="auto-style">&nbsp;</td>
                </tr>
                <tr>
                    <td class="textbox">
            <asp:Label ID="Label5" runat="server" Text="Valor a pagar"></asp:Label>
            &nbsp;<asp:TextBox ID="txtvalorPagar" runat="server" Enabled="False"></asp:TextBox>
                    </td>
                    <td class="auto-style">&nbsp;</td>
                </tr>

            </table>

        </div>

        &nbsp;&nbsp;&nbsp;
    </form>

    </body>

</html>
