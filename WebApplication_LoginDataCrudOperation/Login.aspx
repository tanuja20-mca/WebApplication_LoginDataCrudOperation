<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication_LoginDataCrudOperation.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblID" runat="server" Text="ID :"></asp:Label>
            <asp:TextBox ID="txtID" runat="server"></asp:TextBox><br />

            <asp:Label ID="lblName" runat="server" Text="Name :"></asp:Label>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox><br />

            <asp:Label ID="lblCourse" runat="server" Text="Course :"></asp:Label>
            <asp:TextBox ID="txtCourse" runat="server"></asp:TextBox><br />

            <asp:Label ID="lblAddress" runat="server" Text="Address :"></asp:Label>
            <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox><br />

            <asp:Button ID="btnInsert" runat="server" Text="Insert" Width="86px" OnClick="btnInsert_Click" />
            <asp:Button ID="btnUpdate" runat="server" Text="Update" Width="92px" OnClick="btnUpdate_Click" />
            <asp:Button ID="btnDelete" runat="server" Text="Delete" Width="77px" OnClick="btnDelete_Click" />
            <asp:Button ID="lblSelect" runat="server" Text="Select" Width="72px" OnClick="lblSelect_Click" />

            <asp:Button ID="btnSearch" runat="server" OnClick="btnSearch_Click" Text="Search" />

            <br /><br /><br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <br />


        </div>
    </form>
</body>
</html>
