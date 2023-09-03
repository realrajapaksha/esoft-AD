<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Form.aspx.cs" Inherits="WebApplication1.Form" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Form</title>
</head>
<body>
   <form id="form1" runat="server" method="post" action="FormResult.aspx">
        <h1>My Data</h1>
        <div style="white-space: nowrap;">
            <p style="display: inline-block;">Enter Name</p>
            <input style="display: inline-block;" type="text" name="name" />

        </div>
        <div style="white-space: nowrap;">
            <p style="display: inline-block;">City</p>
            <select style="display: inline-block;" name="city">
                <option value="Colombo">Colombo</option>
                <option value="Matara">Matara</option>
                <option value="Kaluthara">Kaluthara</option>
            </select>

        </div>
        <div style="white-space: nowrap;">
            <p style="display: inline-block;">Gender</p>
            <div style="display: inline-block;">
                <input type="radio" id="contactChoice1" name="gender" value="Male" checked>
                <label for="Choice1">Male</label>
                <input type="radio" id="contactChoice2" name="gender" value="Female">
                <label for="Choice1">female</label>
            </div>
        </div>
        <button type="submit">Submit</button>
    </form>
</body>
</html>
