<%@ Page Language="C#" AutoEventWireup="true" 
    MasterPageFile="~/quizgame/header.master"
    CodeBehind="home.aspx.cs" 
    Inherits="quizgame.quizgame.home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <h2 style="padding-top: 30px; padding-bottom: 20px" class="text-center">Select a Level</h2>
        <div class="row">
            <asp:Repeater ID="RepeaterLevels" runat="server">
                <ItemTemplate>
                    <div class="col-12 mb-4">
                        <a href="questions.aspx?levelId=<%# Eval("Id") %>" class="text-decoration-none">
                            <div class="card text-center shadow-sm">
                                <div class="card-body">
                                    <h5 class="card-title"><%# Eval("Description") %></h5>
                                </div>
                            </div>
                        </a>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>
</asp:Content>
