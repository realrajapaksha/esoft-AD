<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="WebApplication1.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 76px;
        }
        .auto-style2 {
            width: 217px;
        }
        .auto-style3 {
            width: 1010px;
        }
        .auto-style4 {
            width: 1152px;
            height: 53px;
        }
    </style>
</head>
<body> 
    <form id="form1" runat="server" method="post">
        <div>
            <table>
                <tr>
                    <td colspan="2" class="auto-style1">
                        <h1 style="text-align: center;" class="auto-style4">Registration Form</h1>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Enter user Name : </td>
                     <td class="auto-style3">
                         <asp:TextBox ID="username" runat="server" Width="376px"></asp:TextBox>
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="username" ErrorMessage="User Name cant be empty" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                 <tr>
                    <td class="auto-style2">Email :</td>
                     <td class="auto-style3">
                         <asp:TextBox ID="email" runat="server" TextMode="Email" Width="374px"></asp:TextBox>
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="email" ErrorMessage="Email can't be empty" ForeColor="Red"></asp:RequiredFieldValidator>
                         <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Invalid Email" ForeColor="#CC0000" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="email"></asp:RegularExpressionValidator>
                     </td>
                </tr>
                 <tr>
                    <td class="auto-style2">Enter Password : </td>
                     <td class="auto-style3">
                         <asp:TextBox ID="pwd" runat="server" TextMode="Password" Width="374px"></asp:TextBox>
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="pwd" ErrorMessage="Password can't be empty" ForeColor="Red"></asp:RequiredFieldValidator>
                     </td>
                </tr>
                 <tr>
                    <td class="auto-style2">Confirm Password: </td>
                     <td class="auto-style3">
                         <asp:TextBox ID="confirmpwd" runat="server" TextMode="Password" Width="371px"></asp:TextBox>
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="confirmpwd" ErrorMessage="Confirm password can't be empty" ForeColor="Red"></asp:RequiredFieldValidator>
                         <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="pwd" ErrorMessage="Confirm password not equal password" ForeColor="Red" ControlToValidate="confirmpwd"></asp:CompareValidator>
                     </td>
                </tr>
                <%-- <tr>
                    <td class="auto-style2">Country : </td>
                     <td>
                         <asp:TextBox ID="TextBox5" runat="server" OnTextChanged="TextBox4_TextChanged" TextMode="Password" Width="371px"></asp:TextBox>
                     </td>
                </tr>--%>
                <tr>
                    <td></td>
                    <td class="auto-style3">

                        <asp:Button ID="BtnSubmit" runat="server" Text="SUBMIT" OnClick="BtnSubmit_Click" />
                        <asp:Button ID="Button2" runat="server" Text="RESET" />

                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
