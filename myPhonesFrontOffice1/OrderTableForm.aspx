<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderTableForm.aspx.cs" Inherits="OrderTableForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 539px">
            Order ID
            <asp:TextBox ID="TextBoxOrderID" runat="server"></asp:TextBox>
            <br />
            Order Line ID&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBoxOrderLineID" runat="server"></asp:TextBox>
            <br />
            Customer ID&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBoxCustomerID" runat="server"></asp:TextBox>
            <br />
            Staff ID<asp:TextBox ID="TextBoxStaffID" runat="server"></asp:TextBox>
            <br />
            Price<asp:TextBox ID="TextBoxPrice" runat="server"></asp:TextBox>
            <br />
            Order Date<asp:TextBox ID="TextBoxOrderDate" runat="server"></asp:TextBox>
            <br />
            Order Time<asp:TextBox ID="TextBoxOrderTime" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:CheckBox ID="Shipped" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="ButtonOk" runat="server" Text="OK" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="ButtonCancel" runat="server" Text="Cancel" />
        </div>
    </form>
</body>
</html>
