using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace quizgame.quizgame
{
    public partial class questiondetails : System.Web.UI.Page
    {
        model.dataconnection con;
        protected string question_text;
        protected int question_id;

        protected void Page_Load(object sender, EventArgs e)
        {
            con = new model.dataconnection();
            question_id = Convert.ToInt32(Request.QueryString["questionId"]);
            if (question_id == null)
            {
                Response.Redirect("home.aspx");
            }
            lblMessage.Text = "";

            if (!IsPostBack)
            {
                LoadQuestion();
            }
        }

        private void LoadQuestion()
        {
            string query = $"SELECT QuestionText FROM Questions WHERE Id = {question_id}";
            DataTable dt = con.getData(query);

            if (dt.Rows.Count > 0)
            {
                question_text = dt.Rows[0]["QuestionText"].ToString();
                lblquestion.Text = question_text;
            }
            else
            {
                lblMessage.Text = "No question found.";
                lblMessage.CssClass = "text-danger";
            }
        }

        protected void btn_submit_click(object sender, EventArgs e)
        {
            string user_answer = txtAnswer.Text.Trim();

            if (CheckAnswer(user_answer))
            {
                lblMessage.Text = "Correct! You can proceed to the next question.";
                lblMessage.CssClass = "text-success";
                btnNextQuestion.Visible = true;
            }
            else
            {
                lblMessage.Text = "Incorrect, please try again.";
                lblMessage.CssClass = "text-danger";
            }
        }

        private bool CheckAnswer(string user_answer)
        {
            string query = $"SELECT AnswerText FROM Answers WHERE QuestionId = {question_id}";
            DataTable dt = con.getData(query);

            if (dt.Rows.Count > 0)
            {
                string correct_answer = dt.Rows[0]["AnswerText"].ToString();

                // Perform case-insensitive comparison
                return string.Equals(user_answer, correct_answer, StringComparison.OrdinalIgnoreCase);
            }
            else
            {
                lblMessage.Text = "No answer found.";
                lblMessage.CssClass = "text-danger";
                return false;
            }
        }

        protected void btn_next_question_click(object sender, EventArgs e)
        {
            Response.Redirect($"questiondetails.aspx?questionId={question_id + 1}");
        }
    }
}