<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentForm.aspx.cs" Inherits="DatabaseHandling.StudentForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 164px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table style="width: 100%;">
            <tr>
                <td class="auto-style1">Name</td>
                <td>
                    <asp:TextBox ID="txtName" runat="server" Width="317px"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="auto-style1">ID</td>
                <td>
                    <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtID" ErrorMessage="ID can't be empty" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Address</td>
                <td>
                    <asp:TextBox ID="txtAddress" runat="server" Width="312px" Height="49px"></asp:TextBox></td>
                <td>&nbsp;</td>
            </tr>

        </table>
        <tr>
            <td>
                <asp:Button ID="AddBtn" runat="server" Text="ADD" OnClick="AddBtn_Click" />
            </td>
            <td>
                 <asp:Button ID="UpdateBtn" runat="server" Text="Update" OnClick="UpdateBtn_Click" />
            <td>
                <asp:Button ID="FindBtn" runat="server" Text="Find" OnClick="FindBtn_Click" />
            <td>
                <asp:Button ID="DeleteBtn" runat="server" Text="Delete" OnClick="DeleteBtn_Click" />
            <td>
               <asp:Button ID="ClearBtn" runat="server" Text="Clear" OnClick="ClearBtn_Click" />
        </tr>
        <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1">
        </asp:GridView>
    </form>
</body>
</html>
