<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Staff.aspx.cs" Inherits="Staff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
        <div id="staffJobTitle">
            Staff ID
            <asp:TextBox ID="TextBoxStaffId" runat="server"></asp:TextBox>
            <br />
            Order ID
            <asp:TextBox ID="TextBoxOrderId" runat="server"></asp:TextBox>
            <br />
            Staff Full Name
            <asp:TextBox ID="TextBoxStaffFullName" runat="server"></asp:TextBox>
            <br />
            Staff Joined
            <asp:TextBox ID="TextBoxStaffJoined" runat="server"></asp:TextBox>
            <br />
            Staff Address <asp:TextBox ID="TextBoxStaffAddress" runat="server"></asp:TextBox>
            <br />
            Staff Job Title
            <asp:TextBox ID="TextBoxStaffJobTitle" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:CheckBox ID="StaffAdminRights" runat="server" />
            <br />
            <br />
            <asp:Button ID="ok" runat="server" Text="Ok" OnClick="ok_Click" />
&nbsp;<asp:Button ID="cancel" runat="server" Text="Cancel" />
        </div>
    </form>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
</html>
