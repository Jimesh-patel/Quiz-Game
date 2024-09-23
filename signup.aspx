<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="signup.aspx.cs" Inherits="quizgame.signup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="signup_form" runat="server">
        <asp:Label ID="lblusername" runat="server" Text="Username :"></asp:Label>
        <input id="tusername" placeholder="Enter username" required="required" type="text" /></br>
        <asp:Label ID="lblemail" runat="server" Text="Email :"></asp:Label>
        <input id="temail" placeholder="enter email" required="required" type="text" /><br />
        <asp:Label ID="lblpassword" runat="server" Text="Password :"></asp:Label>
        <input id="tpassword" placeholder="enter password" required="required" type="password" /><br />
        <br />
        <input id="submit_btn" type="submit" value="submit" onclick="btn_submit_click" /><br />
    </form>
</body>
</html>
