namespace WinFormsQuiz
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSubmit = new Button();
            lblMessage = new Label();
            lblQuestion = new Label();
            txtAnswer = new TextBox();
            Restart = new Button();
            Theme = new Button();
            SuspendLayout();
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(375, 455);
            btnSubmit.Margin = new Padding(4);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(118, 36);
            btnSubmit.TabIndex = 0;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Font = new Font("Segoe UI", 20F);
            lblMessage.Location = new Point(375, 76);
            lblMessage.Margin = new Padding(4, 0, 4, 0);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(458, 54);
            lblMessage.TabIndex = 1;
            lblMessage.Text = "Enter your answer below";
            // 
            // lblQuestion
            // 
            lblQuestion.Font = new Font("Segoe UI", 13F);
            lblQuestion.Location = new Point(375, 238);
            lblQuestion.Margin = new Padding(4, 0, 4, 0);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(568, 54);
            lblQuestion.TabIndex = 2;
            lblQuestion.Text = "What's the capital of Japan?";
            // 
            // txtAnswer
            // 
            txtAnswer.Location = new Point(375, 358);
            txtAnswer.Margin = new Padding(4);
            txtAnswer.Name = "txtAnswer";
            txtAnswer.Size = new Size(552, 31);
            txtAnswer.TabIndex = 3;
            // 
            // Restart
            // 
            Restart.Location = new Point(375, 540);
            Restart.Name = "Restart";
            Restart.Size = new Size(112, 34);
            Restart.TabIndex = 4;
            Restart.Text = "Try Again?";
            Restart.UseVisualStyleBackColor = true;
            Restart.Click += Restart_Click;
            // 
            // Theme
            // 
            Theme.Location = new Point(1050, 708);
            Theme.Name = "Theme";
            Theme.Size = new Size(239, 44);
            Theme.TabIndex = 5;
            Theme.Text = "Toggle Theme";
            Theme.UseVisualStyleBackColor = true;
            Theme.Click += Theme_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1301, 774);
            Controls.Add(Theme);
            Controls.Add(Restart);
            Controls.Add(txtAnswer);
            Controls.Add(lblQuestion);
            Controls.Add(lblMessage);
            Controls.Add(btnSubmit);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSubmit;
        private Label lblMessage;
        private Label lblQuestion;
        private TextBox txtAnswer;
        private Button Restart;
        private Button Theme;
    }
}
