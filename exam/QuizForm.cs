using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using exam.Models;
using exam.Storage;

namespace exam
{
    public partial class QuizForm : Form
    {
        private List<Question> questions;
        private string quizTitle;
        private string quizId;
        private User currentUser;
        private int currentQuestionIndex = 0;
        private double totalScore = 0;
        private List<double> questionScores;
        private bool currentQuestionIsMultiple = false;

        public QuizForm(List<Question> questions, string quizTitle, string quizId, User user)
        {
            this.questions = questions;
            this.quizTitle = quizTitle;
            this.quizId = quizId;
            this.currentUser = user;
            this.questionScores = new List<double>();
            
            InitializeComponent();
            InitializeQuiz();
        }

        private void InitializeQuiz()
        {
            this.Text = "Викторина";
            titleLabel.Text = quizTitle;
            DisplayQuestion();
        }

        private void DisplayQuestion()
        {
            if (currentQuestionIndex >= questions.Count)
            {
                FinishQuiz();
                return;
            }

            var question = questions[currentQuestionIndex];
            
            questionNumberLabel.Text = $"Вопрос {currentQuestionIndex + 1} из {questions.Count}";

            questionLabel.Text = question.Text;

            int correctAnswersCount = question.Answers.Count(a => a.IsCorrect);
            currentQuestionIsMultiple = correctAnswersCount > 1;
            
            var radioControls = new[] { answer0Radio, answer1Radio, answer2Radio, answer3Radio };
            var checkControls = new[] { answer0Check, answer1Check, answer2Check, answer3Check };
            
            if (currentQuestionIsMultiple)
            {
                instructionLabel.Text = "Выберите все правильные варианты ответа:";
                
                for (int i = 0; i < radioControls.Length; i++)
                {
                    radioControls[i].Visible = false;
                    radioControls[i].Checked = false;
                }
                
                for (int i = 0; i < checkControls.Length && i < question.Answers.Count; i++)
                {
                    checkControls[i].Text = question.Answers[i].Text;
                    checkControls[i].Checked = false;
                    checkControls[i].Visible = true;
                    checkControls[i].Tag = question.Answers[i];
                }
                
                for (int i = question.Answers.Count; i < checkControls.Length; i++)
                {
                    checkControls[i].Visible = false;
                }
            }
            else
            {
                instructionLabel.Text = "Выберите правильный вариант ответа:";
                
                for (int i = 0; i < checkControls.Length; i++)
                {
                    checkControls[i].Visible = false;
                    checkControls[i].Checked = false;
                }
                
                for (int i = 0; i < radioControls.Length && i < question.Answers.Count; i++)
                {
                    radioControls[i].Text = question.Answers[i].Text;
                    radioControls[i].Checked = false;
                    radioControls[i].Visible = true;
                    radioControls[i].Tag = question.Answers[i];
                }
                
                for (int i = question.Answers.Count; i < radioControls.Length; i++)
                {
                    radioControls[i].Visible = false;
                }
            }

            if (currentQuestionIndex == questions.Count - 1)
            {
                nextButton.Text = "Завершить викторину";
            }
            else
            {
                nextButton.Text = "Следующий вопрос";
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            List<Answer> selectedAnswers = GetSelectedAnswers();
            
            if (!selectedAnswers.Any())
            {
                MessageBox.Show("Выберите хотя бы один ответ!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double questionScore = CalculateQuestionScore(selectedAnswers);
            questionScores.Add(questionScore);
            totalScore += questionScore;

            currentQuestionIndex++;
            
            if (currentQuestionIndex >= questions.Count)
            {
                FinishQuiz();
            }
            else
            {
                DisplayQuestion();
            }
        }

        private List<Answer> GetSelectedAnswers()
        {
            var selectedAnswers = new List<Answer>();
            
            if (currentQuestionIsMultiple)
            {
                var checkControls = new[] { answer0Check, answer1Check, answer2Check, answer3Check };
                selectedAnswers.AddRange(
                    checkControls
                        .Where(cb => cb.Checked && cb.Visible)
                        .Select(cb => cb.Tag as Answer)
                );
            }
            else
            {
                var radioControls = new[] { answer0Radio, answer1Radio, answer2Radio, answer3Radio };
                var selectedRadio = radioControls.FirstOrDefault(rb => rb.Checked && rb.Visible);
                if (selectedRadio != null)
                {
                    selectedAnswers.Add(selectedRadio.Tag as Answer);
                }
            }
            
            return selectedAnswers;
        }

        private double CalculateQuestionScore(List<Answer> selectedAnswers)
        {
            var question = questions[currentQuestionIndex];
            var correctAnswers = question.Answers.Where(a => a.IsCorrect).ToList();
            
            if (correctAnswers.Count == 1)
            {
                return selectedAnswers.Count == 1 && selectedAnswers[0].IsCorrect ? 1.0 : 0.0;
            }
            
            int correctSelected = selectedAnswers.Count(a => a.IsCorrect);
            int incorrectSelected = selectedAnswers.Count(a => !a.IsCorrect);
            int totalCorrect = correctAnswers.Count;
            
            if (correctSelected == totalCorrect && incorrectSelected == 0)
            {
                return 1.0;
            }
            
            double score = Math.Max(0, (double)(correctSelected - incorrectSelected) / totalCorrect);
            return score;
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите завершить викторину?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                FinishQuiz();
            }
        }

        private void FinishQuiz()
        {
            SaveResult();

            double percentage = (totalScore / questions.Count) * 100;
            int correctCount = (int)Math.Round(totalScore);
            
            string message = $"Викторина завершена!\n\n" +
                           $"Набрано баллов: {totalScore:F1} из {questions.Count}\n" +
                           $"Количество правильных ответов: {correctCount} из {questions.Count}\n" +
                           $"Процент: {percentage:F1}%";

            MessageBox.Show(message, "Результаты", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            this.Close();
        }

        private void SaveResult()
        {
            var results = DataStorage.LoadResults();
            
            int correctCount = (int)Math.Round(totalScore);
            
            var result = new Result
            {
                Login = currentUser.Login,
                QuizId = quizId,
                Date = DateTime.Now,
                CorrectCount = correctCount
            };

            results.Add(result);
            DataStorage.SaveResults(results);
        }
    }
}