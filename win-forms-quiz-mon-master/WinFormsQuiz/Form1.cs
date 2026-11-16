using System.CodeDom;

namespace WinFormsQuiz
{
    public partial class Form1 : Form
    {
        // array of questions and answers
        string[,] questions = new string[6, 2];

        // track current question
        int currentQuestion = 0;

        // track correct answers
        int correct = 0;
        bool isDark = false;

        // startup method that runs automatically when this form loads
        public Form1()
        {
            InitializeComponent();

            LoadQuestions();

            Restart.Enabled = false;
            Restart.Visible = false;
        }

        /// <summary>
        /// populate question
        /// </summary>
        /// <author>Lucian</author>
        private void LoadQuestions()
        {
            // populate array
            questions[0, 0] = "What's the capital of Japan?";
            questions[0, 1] = "Tokyo";
            questions[1, 0] = "What colour is the sky?";
            questions[1, 1] = "Blue";
            questions[2, 0] = "Which came first, the chicken or the egg?";
            questions[2, 1] = "Chicken";
            questions[3, 0] = "What is 9+10?";
            questions[3, 1] = "21";
            questions[4, 0] = "What is the course code?";
            questions[4, 1] = "COMP1115";
            questions[5, 0] = "What time does the class start?";
            questions[5, 1] = "2:00pm";

            // show 1st question on question label
            lblQuestion.Text = questions[0, 0];

        }

        /// <summary>
        /// give feedback on answer
        /// </summary>
        /// <param name="text"></param>
        /// <param name="colour"></param>
        private void ShowFeedback(string text, Color colour)
        {
            lblMessage .Text = text;
            lblMessage.ForeColor = colour;
        }

        /// <summary>
        /// user has finished
        /// </summary>
        private void FinishQuiz()
        {
            btnSubmit.Enabled = false;
            lblQuestion.Text = $"You got {correct} correct answers out of {questions.GetLength(0)} questions.";
            
        }
        
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // if user has entered correct answer in the textbox
            if (txtAnswer.Text == questions[currentQuestion, 1])
            {
                ShowFeedback("Correct", Color.Green);

                // add 1 to correct answer count
                correct++;
            }
            else
            {
                ShowFeedback("Incorrect", Color.Red);
            }

            // increment current question 
            currentQuestion++;

            // are there more questions?
            if (currentQuestion < questions.GetLength(0))
            {
                //  move to next question                
                lblQuestion.Text = questions[currentQuestion, 0];
            }
            else
            {
                FinishQuiz();
                Restart.Enabled = true;
                Restart.Visible = true;
                btnSubmit.Visible = false;
            }

            // clear last answer
            txtAnswer.Text = "";

        }
        /// <summary>
        /// gets percentage of correct answers
        /// </summary>
        /// <param name="correct"></param>
        /// <param name="total"></param>
        /// <returns>percentage</returns>
        private int GetPercentScore(int correct, int total)
        {
            int percent = (correct * 100) / total;
        }
        private void Restart_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "Restarting the Quiz";
            lblMessage.ForeColor = Color.Black;
            lblQuestion.Text = questions[0, 0];
            correct = 0;
            currentQuestion = 0;
            btnSubmit.Enabled = true;
            Restart.Visible = false;

        }

        private void Theme_Click(object sender, EventArgs e)
        {
            if(isDark == false)
            {
                isDark = true;
                BackColor = Color.Black;
                FormCaptionTextColor = Color.White;
                lblMessage.ForeColor = Color.White;
                lblQuestion.ForeColor = Color.White;
                btnSubmit.BackColor = Color.DarkGray;
                btnSubmit.ForeColor = Color.White;
                txtAnswer.BackColor = Color.DarkGray;
                txtAnswer.ForeColor = Color.White;
                Restart.BackColor = Color.DarkGray;
                Restart.ForeColor = Color.White;
            }
            else
            {
                isDark = false;
                BackColor = Color.White;
                FormCaptionTextColor = Color.Black;
                lblMessage.ForeColor = Color.Black;
                lblQuestion.ForeColor = Color.Black;
                btnSubmit.BackColor = Color.WhiteSmoke;
                btnSubmit.ForeColor = Color.Black;
                txtAnswer.BackColor = Color.WhiteSmoke;
                txtAnswer.ForeColor = Color.Black;
                Restart.BackColor = Color.WhiteSmoke;
                Restart.ForeColor = Color.Black;
            }
        }
    }
}
