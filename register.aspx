<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="quizgame.register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblSignupPage" runat="server" Text="Sign up Page"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lblUsername" runat="server" Text="Username :"></asp:Label>
        <asp:TextBox ID="txtUsername" runat="server" required="required"></asp:TextBox><br />
        <br />
        <asp:Label ID="lblEmail" runat="server" Text="Email : "></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server" required="required"></asp:TextBox><br />
        <br />
        <asp:Label ID="lblPassword" runat="server" Text="Password : "></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" required="required"></asp:TextBox><br />
        <br />
        <asp:Label ID="lblConformPassword" runat="server" Text="Conform Password : "></asp:Label>
        <asp:TextBox ID="txtConformPassword" runat="server" TextMode="Password" required="required"></asp:TextBox><br />
        <br />
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btn_submit" runat="server" OnClick="btn_submit_click" Text="Submit" /><br />
        <br />
        <asp:Label ID="lblSignup" runat="server" Text="Already have an account ? "></asp:Label>
        <asp:HyperLink  ID="hl_login" runat="server" NavigateUrl="~/login.aspx" Text="Login" ForeColor="Red"></asp:HyperLink>

    </form>
</body>
</html>
