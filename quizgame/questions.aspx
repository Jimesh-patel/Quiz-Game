<%@ Page Language="C#" AutoEventWireup="true" 
    MasterPageFile="~/quizgame/header.master"
    CodeBehind="questions.aspx.cs" 
    Inherits="quizgame.quizgame.questions" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <h2 style="padding-top: 30px; padding-bottom: 20px" class="text-center">let's start ... </h2>
        <div class="row justify-content-center">
            <asp:Repeater ID="RepeaterQuestions" runat="server">
                <ItemTemplate>
                    <div class="col-md-2 col-sm-4 col-6 mb-4">
                        <a href="questiondetails.aspx?questionId=<%# Eval("Id") %>" class="text-decoration-none">
                            <div class="card text-center shadow-lg">
                                <div class="card-body">
                                    <h5 class="card-title display-4"><%# Container.ItemIndex + 1 %></h5>
                                </div>
                            </div>
                        </a>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>
</asp:Content>