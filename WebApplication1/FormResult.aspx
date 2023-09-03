<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormResult.aspx.cs" Inherits="WebApplication1.WebFormResult" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>View Result</title>
</head>
<body>
    <%
        Response.Write("<h1>Personal Information</h1>");
        Response.Write("<br>Name: " + Request["name"]);
        Response.Write("<br>City: " + Request["city"]);
        Response.Write("<br>Gender: " + Request["gender"]);
    %>
</body>
</html>
