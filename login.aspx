<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="quizgame.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblLogin" runat="server" Text="Login Page"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblEmail" runat="server" Text="Email : "></asp:Label>
            <asp:TextBox ID="txtEmail" runat="server" required="required"></asp:TextBox><br />
            <br />
            <asp:Label ID="lblPassword" runat="server" Text="Password : "></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" required="required"></asp:TextBox><br />
            <br />
            <br />
            <asp:Label ID="lblError" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btn_login" runat="server" Text="Login" onclick="btn_login_click"/>
            <br />
            <br />
            <br />
            <asp:Label ID="lblSignup" runat="server" Text="Don't have an account ? "></asp:Label>
            <asp:HyperLink  ID="hl_signup" runat="server" NavigateUrl="~/register.aspx" Text="Register here" ForeColor="Red"></asp:HyperLink>
         </div>
    </form>
    
</body>
</html>
