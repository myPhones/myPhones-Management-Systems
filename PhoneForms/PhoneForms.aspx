<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PhoneForms.aspx.cs" Inherits="PhoneForms" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            width: 1130px;
            height: 565px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <p>
        Phone ID&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtPhoneId" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        </p>
        <p>
            Phone Make&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtPhoneMake" runat="server" style="margin-bottom: 5px"></asp:TextBox>
        </p>
        <p>
            Phone Model&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtPhoneModel" runat="server"></asp:TextBox>
        </p>
        <p>
            Phone Description&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtPhoneDescription" runat="server"></asp:TextBox>
        </p>
        <p>
            Phone Weight&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtPhoneWeight" runat="server"></asp:TextBox>
        </p>
        <p>
            Phone Colour&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtPhoneColour" runat="server"></asp:TextBox>
        </p>
        <p>
            Date Phone Added&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtDatePhoneAdded" runat="server"></asp:TextBox>
        </p>
        <p>
            Price&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
        </p>
        <p>
            In Stock&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtInStock" runat="server"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <asp:Button ID="ButtonOK" runat="server" Text="OK" Height="26px" OnClick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" Text="Cancel" />
    </form>
</body>
</html>
