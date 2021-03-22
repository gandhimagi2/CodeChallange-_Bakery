<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CodeChallange__Bakery.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Bakery</title>
    <link href="style.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div id="order-details-booking" >

        <table align="center" class="auto-style1">
            <tr>
                <td class="auto-style2" colspan="2"><strong>Bakery</strong></td>
            </tr>
            <tr>
                <td class="auto-style4">Select Item</td>
                <td class="auto-style3">
                    <asp:DropDownList ID="DropDownListID" AppendDataBoundItems="true" runat="server">
                     <asp:ListItem Text="Vegemite Scroll" Value="VS5" />
                     <asp:ListItem Text="Blueberry Muffin" Value="MB11" />
                     <asp:ListItem Text="Croissant" Value="CF" />
                </asp:DropDownList>
                </td>
            </tr>
            <tr></tr>
            <tr></tr>
            <tr>
                <td class="auto-style4">Enter Quntity</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </td>
            </tr>
            
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style3" colspan="2">
                    <asp:Button ID="Button1" runat="server" Height="24px" Text="Submit" Width="93px" BackColor="Lightgray" BorderStyle="Solid" OnClick="Button1_Click" />
                &nbsp;
                   <%-- <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>--%>
                &nbsp;&nbsp;&nbsp;
                    <%--<asp:Button ID="Button2" runat="server" BackColor="#CC00FF" BorderColor="Black" BorderStyle="Solid" Text="Login" />--%>
                </td>
            </tr>
        </table>

    </div>
        <div class="auto-style2" runat="server" id="divError" visible="true">
            <div class="alert alert-danger" role="alert">
                    <asp:Label runat="server" ID="Label1"> Result</asp:Label>
                </div>
            <br />
                <div class="alert alert-danger" role="alert">
                    <asp:Label runat="server" ID="lblError"></asp:Label>
                </div>
            </div>
    </form>
</body>
</html>
