<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderForm.aspx.cs" Inherits="OrderForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Order ID&nbsp;
            <asp:TextBox ID="TextBoxOrderID" runat="server"></asp:TextBox>
            <br />
            OrderLine ID <asp:TextBox ID="TextBoxOrdlineID" runat="server"></asp:TextBox>
            <br />
            Customer ID&nbsp;&nbsp;
            <asp:TextBox ID="TextBoxCustomerID" runat="server"></asp:TextBox>
            <br />
            Staff ID<asp:TextBox ID="TextBoxStaffID" runat="server"></asp:TextBox>
            <br />
            Price<asp:TextBox ID="TextBoxPrice" runat="server" OnTextChanged="TextBox5_TextChanged"></asp:TextBox>
            <br />
            Order Date<asp:TextBox ID="TextBoxDate" runat="server"></asp:TextBox>
            <br />
            Order Price<asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:CheckBox ID="Shipped" runat="server" />
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
