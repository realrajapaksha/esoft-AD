<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Hello.aspx.cs" Inherits="WebApplication1.Hello" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <h1>Welcome to ASP.net</h1>
            <% Response.Write("<h2>Welcome ASP</h2>"); %>
            <a href="PageTwo.aspx">Page Two</a>
        </div>
    </form>
    
</body>
</html>
