<%@ Page Language="C#" AutoEventWireup="true" 
    MasterPageFile="~/quizgame/header.master"
    CodeBehind="questiondetails.aspx.cs" 
    Inherits="quizgame.quizgame.questiondetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container mt-5">
        <div class="row justify-content-center">
            <div class="col-md-8">
                <div class="card">
                    <div class="card-body">
                        <h4 class="card-title text-center">Question</h4>
                        <h5 class="card-text text-center" style="padding-top: 20px; padding-bottom: 10px">
                            <asp:Label ID="lblquestion" runat="server" ></asp:Label>
                        </h5>

                        <div class="form-group">
                            <asp:TextBox ID="txtAnswer" runat="server" CssClass="form-control" placeholder="Your Answer..." required></asp:TextBox>
                        </div>

                        <div class="text-center mt-3">
                            <asp:Button ID="btnSubmit" runat="server" Text="Submit" CssClass="btn btn-primary" OnClick="btn_submit_click" />
                        </div>

                        <asp:Label ID="lblMessage" runat="server" CssClass="text-danger text-center d-block"></asp:Label>
                    </div>
                </div>

                <div class="text-center mt-4">
                    <asp:Button ID="btnNextQuestion" runat="server" Text="Next Question" CssClass="btn btn-success" OnClick="btn_next_question_click" Visible="false" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
