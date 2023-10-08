<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Reg.aspx.cs" Inherits="WebApplication1.Reg" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <%Response.Write("Hello, " + Request["uname"]); %>
            <br />
            <%Response.Write("Your Email: " + Request["email"]); %>
            <br />
            <%Response.Write("Password: " + Request["password"]); %>
            <br />
            <%Response.Write("Confirm Password: " + Request["conpwd"]); %>
        </div>
    </form>
</body>
</html>
