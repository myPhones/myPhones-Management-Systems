<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderForm.aspx.cs" Inherits="OrderForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Order ID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBoxOrderID" runat="server" Width="125px"></asp:TextBox>
            <br />
            <br />
            OrderLine ID&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBoxOrdlineID" runat="server" Height="16px" Width="125px"></asp:TextBox>
            <br />
            <br />
            Customer ID&nbsp;&nbsp; &nbsp;&nbsp;
            <asp:TextBox ID="TextBoxCustomerID" runat="server" Width="125px"></asp:TextBox>
            <br />
            <br />
            Staff ID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBoxStaffID" runat="server" Width="125px"></asp:TextBox>
            <br />
            <br />
            Price&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBoxPrice" runat="server" OnTextChanged="TextBox5_TextChanged" Width="125px"></asp:TextBox>
            <br />
            <br />
            Order Date&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBoxDate" runat="server" Width="125px"></asp:TextBox>
            <br />
            <br />
            Order Price&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox7" runat="server" Width="125px"></asp:TextBox>
            <br />
            <br />
            <asp:CheckBox ID="Shipped" runat="server" OnCheckedChanged="Shipped_CheckedChanged" />
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="ButtonOk" runat="server" Text="OK" OnClick="ButtonOk_Click" />
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="ButtonCancel" runat="server" Text="Cancel" />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            
        </div>
    </form>
</body>
</html>
