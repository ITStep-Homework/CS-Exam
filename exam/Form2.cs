using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using exam.Models;
using exam.Storage;

namespace exam
{
    public partial class Form2 : Form
    {
        private User currentUser;
        private List<User> users;
        private List<Quiz> quizzes;
        private List<Result> results;
        private bool isLoggingOut = false;
        private Quiz currentEditingQuiz;

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(User user) : this()
        {
            currentUser = user;
            users = DataStorage.LoadUsers();
            quizzes = DataStorage.LoadQuizzes();
            results = DataStorage.LoadResults();
            InitializeProfile();
            InitializeQuizTab();
            InitializeRatingTab();
            InitializeEditorTab();
            SetupEventHandlers();
        }

        private void InitializeProfile()
        {
            loginLabel.Text = currentUser.Login;
            
            if (DateTime.TryParseExact(currentUser.BirthDate, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime birthDate))
            {
                birthDateLabel.Text = birthDate.ToString("dd.MM.yyyy");
                birthChangeCalendar.SetDate(birthDate);
            }
            else
            {
                birthDateLabel.Text = currentUser.BirthDate;
            }
        }

        private void InitializeQuizTab()
        {
            quizCombo.Items.Clear();
            foreach (var quiz in quizzes)
            {
                quizCombo.Items.Add(quiz.Title);
            }
            
            if (quizCombo.Items.Count > 0)
            {
                quizCombo.SelectedIndex = 0;
            }
        }

        private void InitializeRatingTab()
        {
            categoryCombo.Items.Clear();
            categoryCombo.Items.Add("Общий рейтинг");
            categoryCombo.Items.Add("Общая викторина");
            
            foreach (var quiz in quizzes)
            {
                categoryCombo.Items.Add(quiz.Title);
            }
            
            if (categoryCombo.Items.Count > 0)
            {
                categoryCombo.SelectedIndex = 0;
            }
        }

        private void InitializeEditorTab()
        {
            editQuizCombo.Items.Clear();
            foreach (var quiz in quizzes)
            {
                editQuizCombo.Items.Add(quiz.Title);
            }
        }

        private void SetupEventHandlers()
        {
            changeProfileButton.Click += ChangeProfileButton_Click;
            showStats.Click += ShowStats_Click;
            
            startComboQuiz.Click += StartComboQuiz_Click;
            startRandomQuiz.Click += StartRandomQuiz_Click;
            startGeneralQuiz.Click += StartGeneralQuiz_Click;
            
            categoryCombo.SelectedIndexChanged += CategoryCombo_SelectedIndexChanged;
            quizRankingsListBox.DoubleClick += QuizRankingsListBox_DoubleClick;
            
            editQuizCombo.SelectedIndexChanged += EditQuizCombo_SelectedIndexChanged;
            editNewQuizButton.Click += EditNewQuizButton_Click;
            editSaveButton.Click += EditSaveButton_Click;
            editDeleteQuizButton.Click += EditDeleteQuizButton_Click;
            
            mainTabControl.SelectedIndexChanged += MainTabControl_SelectedIndexChanged;
        }

        private void EditQuizCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (editQuizCombo.SelectedIndex == -1) return;
            
            string selectedTitle = editQuizCombo.SelectedItem.ToString();
            currentEditingQuiz = quizzes.FirstOrDefault(q => q.Title == selectedTitle);
            
            if (currentEditingQuiz != null)
            {
                editQuizTitleTextBox.Text = currentEditingQuiz.Title;
                LoadQuestions();
            }
        }

        private void EditNewQuizButton_Click(object sender, EventArgs e)
        {
            currentEditingQuiz = new Quiz
            {
                Id = Guid.NewGuid().ToString(),
                Title = "Новая викторина",
                Questions = new List<Question>()
            };
            
            editQuizTitleTextBox.Text = currentEditingQuiz.Title;
            editQuizCombo.SelectedIndex = -1;
            LoadQuestions();
        }

        private void EditSaveButton_Click(object sender, EventArgs e)
        {
            if (currentEditingQuiz == null) return;
            
            if (string.IsNullOrWhiteSpace(editQuizTitleTextBox.Text))
            {
                MessageBox.Show("Введите название викторины!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            currentEditingQuiz.Title = editQuizTitleTextBox.Text.Trim();
            SaveQuestionsFromPanels();
            
            var existingQuiz = quizzes.FirstOrDefault(q => q.Id == currentEditingQuiz.Id);
            if (existingQuiz != null)
            {
                int index = quizzes.IndexOf(existingQuiz);
                quizzes[index] = currentEditingQuiz;
            }
            else
            {
                quizzes.Add(currentEditingQuiz);
            }
            
            DataStorage.SaveQuizzes(quizzes);
            
            InitializeQuizTab();
            InitializeRatingTab();
            InitializeEditorTab();
            
            MessageBox.Show("Викторина сохранена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void EditDeleteQuizButton_Click(object sender, EventArgs e)
        {
            if (currentEditingQuiz == null || editQuizCombo.SelectedIndex == -1) return;
            
            DialogResult result = MessageBox.Show($"Удалить викторину '{currentEditingQuiz.Title}'?", 
                "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (result == DialogResult.Yes)
            {
                quizzes.RemoveAll(q => q.Id == currentEditingQuiz.Id);
                DataStorage.SaveQuizzes(quizzes);
                
                currentEditingQuiz = null;
                editQuizTitleTextBox.Clear();
                editQuestionsPanel.Controls.Clear();
                
                InitializeQuizTab();
                InitializeRatingTab();
                InitializeEditorTab();
                
                MessageBox.Show("Викторина удалена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LoadQuestions()
        {
            editQuestionsPanel.Controls.Clear();
            
            if (currentEditingQuiz?.Questions == null) return;
            
            int yPos = 10;
            for (int i = 0; i < currentEditingQuiz.Questions.Count; i++)
            {
                var questionPanel = CreateQuestionPanel(currentEditingQuiz.Questions[i], i, yPos);
                editQuestionsPanel.Controls.Add(questionPanel);
                yPos += questionPanel.Height + 10;
            }
            
            var addButton = new Button
            {
                Text = "Добавить вопрос",
                Size = new Size(150, 30),
                Location = new Point(10, yPos),
                Font = new Font("Microsoft Sans Serif", 10F)
            };
            addButton.Click += (s, e) => AddNewQuestion();
            editQuestionsPanel.Controls.Add(addButton);
        }

        private Panel CreateQuestionPanel(Question question, int questionIndex, int yPos)
        {
            var panel = new Panel
            {
                Size = new Size(700, 200),
                Location = new Point(10, yPos),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.White
            };

            var questionLabel = new Label
            {
                Text = $"Вопрос {questionIndex + 1}:",
                Location = new Point(5, 5),
                Size = new Size(100, 20),
                Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold)
            };
            panel.Controls.Add(questionLabel);

            var deleteQuestionButton = new Button
            {
                Text = "Удалить",
                Size = new Size(60, 25),
                Location = new Point(630, 5),
                Font = new Font("Microsoft Sans Serif", 8F)
            };
            deleteQuestionButton.Click += (s, e) => DeleteQuestion(questionIndex);
            panel.Controls.Add(deleteQuestionButton);

            var questionTextBox = new TextBox
            {
                Text = question.Text,
                Location = new Point(5, 30),
                Size = new Size(685, 20),
                Name = $"question_{questionIndex}",
                Font = new Font("Microsoft Sans Serif", 10F)
            };
            panel.Controls.Add(questionTextBox);

            for (int i = 0; i < 4; i++)
            {
                var answerPanel = new Panel
                {
                    Location = new Point(5, 60 + i * 30),
                    Size = new Size(685, 25)
                };

                var checkBox = new CheckBox
                {
                    Location = new Point(0, 3),
                    Size = new Size(15, 15),
                    Name = $"answer_{questionIndex}_{i}_correct",
                    Checked = i < question.Answers.Count && question.Answers[i].IsCorrect
                };
                answerPanel.Controls.Add(checkBox);

                var answerTextBox = new TextBox
                {
                    Location = new Point(20, 0),
                    Size = new Size(660, 20),
                    Name = $"answer_{questionIndex}_{i}_text",
                    Text = i < question.Answers.Count ? question.Answers[i].Text : "",
                    Font = new Font("Microsoft Sans Serif", 9F)
                };
                answerPanel.Controls.Add(answerTextBox);

                panel.Controls.Add(answerPanel);
            }

            return panel;
        }

        private void AddNewQuestion()
        {
            if (currentEditingQuiz == null)
            {
                currentEditingQuiz = new Quiz
                {
                    Id = Guid.NewGuid().ToString(),
                    Title = "Новая викторина",
                    Questions = new List<Question>()
                };
            }

            if (currentEditingQuiz.Questions == null)
                currentEditingQuiz.Questions = new List<Question>();

            var newQuestion = new Question
            {
                Text = "Новый вопрос",
                Answers = new List<Answer>
                {
                    new Answer { Text = "Вариант 1", IsCorrect = true },
                    new Answer { Text = "Вариант 2", IsCorrect = false },
                    new Answer { Text = "Вариант 3", IsCorrect = false },
                    new Answer { Text = "Вариант 4", IsCorrect = false }
                }
            };

            currentEditingQuiz.Questions.Add(newQuestion);
            LoadQuestions();
        }

        private void DeleteQuestion(int questionIndex)
        {
            if (currentEditingQuiz?.Questions != null && questionIndex < currentEditingQuiz.Questions.Count)
            {
                currentEditingQuiz.Questions.RemoveAt(questionIndex);
                LoadQuestions();
            }
        }

        private void SaveQuestionsFromPanels()
        {
            if (currentEditingQuiz == null) return;

            currentEditingQuiz.Questions = new List<Question>();

            foreach (Control control in editQuestionsPanel.Controls)
            {
                if (control is Panel panel && panel.Controls.Cast<Control>().Any(c => c.Name?.StartsWith("question_") == true))
                {
                    var questionTextBox = panel.Controls.Cast<Control>().FirstOrDefault(c => c.Name?.StartsWith("question_") == true) as TextBox;
                    if (questionTextBox == null || string.IsNullOrWhiteSpace(questionTextBox.Text)) continue;

                    var question = new Question
                    {
                        Text = questionTextBox.Text.Trim(),
                        Answers = new List<Answer>()
                    };

                    for (int i = 0; i < 4; i++)
                    {
                        var answerTextBox = panel.Controls.Cast<Control>()
                            .FirstOrDefault(c => c.Name == $"answer_{currentEditingQuiz.Questions.Count}_{i}_text") as TextBox;
                        var answerCheckBox = panel.Controls.Cast<Control>()
                            .FirstOrDefault(c => c.Name == $"answer_{currentEditingQuiz.Questions.Count}_{i}_correct") as CheckBox;

                        if (answerTextBox != null && !string.IsNullOrWhiteSpace(answerTextBox.Text))
                        {
                            question.Answers.Add(new Answer
                            {
                                Text = answerTextBox.Text.Trim(),
                                IsCorrect = answerCheckBox?.Checked == true
                            });
                        }
                    }

                    if (question.Answers.Count > 0)
                    {
                        currentEditingQuiz.Questions.Add(question);
                    }
                }
            }
        }

        private void QuizRankingsListBox_DoubleClick(object sender, EventArgs e)
        {
            if (quizRankingsListBox.SelectedIndex == -1)
                return;

            string selectedItem = quizRankingsListBox.SelectedItem.ToString();
            
            string[] parts = selectedItem.Split('-');
            if (parts.Length < 2) return;
            
            string loginPart = parts[0].Trim();
            string[] loginWords = loginPart.Split(' ');
            if (loginWords.Length < 2) return;
            
            string targetLogin = loginWords[loginWords.Length - 1];
            
            targetLogin = targetLogin.Replace("←", "").Trim();
            
            ShowDetailedStats(targetLogin);
        }

        private void ShowDetailedStats(string login)
        {
            var targetUser = users.FirstOrDefault(u => u.Login.Equals(login, StringComparison.OrdinalIgnoreCase));
            if (targetUser == null)
            {
                MessageBox.Show("Пользователь не найден!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var statsForm = new StatsForm(targetUser, results, quizzes);
            statsForm.ShowDialog();
        }

        private void ShowStats_Click(object sender, EventArgs e)
        {
            ShowDetailedStats(currentUser.Login);
        }

        private void CategoryCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateRankings();
        }

        private void UpdateRankings()
        {
            quizRankingsListBox.Items.Clear();
            
            if (categoryCombo.SelectedIndex == -1)
                return;

            string selectedCategory = categoryCombo.SelectedItem.ToString();
            
            List<RankingEntry> rankings;
            
            if (selectedCategory == "Общий рейтинг")
            {
                rankings = GenerateOverallRankings();
            }
            else
            {
                rankings = GenerateCategoryRankings(selectedCategory);
            }

            for (int i = 0; i < rankings.Count; i++)
            {
                var entry = rankings[i];
                string rank = $"{i + 1}.";
                string playerInfo = $"{entry.Login} - {entry.AverageScore:F1}% (игр: {entry.GamesPlayed})";
                
                if (entry.Login.Equals(currentUser.Login, StringComparison.OrdinalIgnoreCase))
                {
                    playerInfo += " ← Вы";
                }
                
                quizRankingsListBox.Items.Add($"{rank,-4} {playerInfo}");
            }

            if (rankings.Count == 0)
            {
                quizRankingsListBox.Items.Add("Нет данных для отображения");
            }
        }

        private List<RankingEntry> GenerateOverallRankings()
        {
            var userStats = new Dictionary<string, RankingEntry>();

            foreach (var result in results)
            {
                if (!userStats.ContainsKey(result.Login))
                {
                    userStats[result.Login] = new RankingEntry { Login = result.Login };
                }

                var entry = userStats[result.Login];
                var questionsCount = GetQuestionsCountByQuizId(result.QuizId);
                
                if (questionsCount > 0)
                {
                    var percentage = (result.CorrectCount / (double)questionsCount) * 100;
                    entry.TotalScore += percentage;
                    entry.GamesPlayed++;
                }
            }

            var rankings = userStats.Values
                .Where(e => e.GamesPlayed > 0)
                .Select(e => new RankingEntry
                {
                    Login = e.Login,
                    AverageScore = e.TotalScore / e.GamesPlayed,
                    GamesPlayed = e.GamesPlayed
                })
                .OrderByDescending(e => e.AverageScore)
                .ThenByDescending(e => e.GamesPlayed)
                .ToList();

            return rankings;
        }

        private List<RankingEntry> GenerateCategoryRankings(string categoryName)
        {
            var userStats = new Dictionary<string, RankingEntry>();
            
            var categoryResults = results.Where(r => GetCategoryNameByQuizId(r.QuizId) == categoryName).ToList();

            foreach (var result in categoryResults)
            {
                if (!userStats.ContainsKey(result.Login))
                {
                    userStats[result.Login] = new RankingEntry { Login = result.Login };
                }

                var entry = userStats[result.Login];
                var questionsCount = GetQuestionsCountByCategory(categoryName);
                
                if (questionsCount > 0)
                {
                    var percentage = (result.CorrectCount / (double)questionsCount) * 100;
                    entry.TotalScore += percentage;
                    entry.GamesPlayed++;
                }
            }

            var rankings = userStats.Values
                .Where(e => e.GamesPlayed > 0)
                .Select(e => new RankingEntry
                {
                    Login = e.Login,
                    AverageScore = e.TotalScore / e.GamesPlayed,
                    GamesPlayed = e.GamesPlayed
                })
                .OrderByDescending(e => e.AverageScore)
                .ThenByDescending(e => e.GamesPlayed)
                .ToList();

            return rankings;
        }

        private string GetCategoryNameByQuizId(string quizId)
        {
            if (quizId == "mixed")
                return "Общая викторина";
                
            var quiz = quizzes.FirstOrDefault(q => q.Id == quizId);
            return quiz?.Title ?? "Неизвестная категория";
        }

        private int GetQuestionsCountByCategory(string categoryName)
        {
            if (categoryName == "Общая викторина")
                return 20;
                
            var quiz = quizzes.FirstOrDefault(q => q.Title == categoryName);
            return quiz?.Questions?.Count ?? 0;
        }

        private int GetQuestionsCountByQuizId(string quizId)
        {
            if (quizId == "mixed")
                return 20;
                
            var quiz = quizzes.FirstOrDefault(q => q.Id == quizId);
            return quiz?.Questions?.Count ?? 0;
        }

        private void StartComboQuiz_Click(object sender, EventArgs e)
        {
            if (quizCombo.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите викторину из списка!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedQuizTitle = quizCombo.SelectedItem.ToString();
            var selectedQuiz = quizzes.FirstOrDefault(q => q.Title == selectedQuizTitle);
            
            if (selectedQuiz != null)
            {
                StartQuiz(selectedQuiz.Questions, selectedQuiz.Title, selectedQuiz.Id);
            }
        }

        private void StartRandomQuiz_Click(object sender, EventArgs e)
        {
            if (quizzes.Count == 0)
            {
                MessageBox.Show("Нет доступных викторин!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Random random = new Random();
            var randomQuiz = quizzes[random.Next(quizzes.Count)];
            StartQuiz(randomQuiz.Questions, $"Случайная викторина: {randomQuiz.Title}", randomQuiz.Id);
        }

        private void StartGeneralQuiz_Click(object sender, EventArgs e)
        {
            if (quizzes.Count == 0)
            {
                MessageBox.Show("Нет доступных викторин!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var allQuestions = new List<Question>();
            foreach (var quiz in quizzes)
            {
                allQuestions.AddRange(quiz.Questions);
            }

            if (allQuestions.Count == 0)
            {
                MessageBox.Show("Нет доступных вопросов!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var shuffledQuestions = ShuffleQuestions(allQuestions);
            int questionsCount = Math.Min(20, shuffledQuestions.Count);
            var selectedQuestions = shuffledQuestions.Take(questionsCount).ToList();
            
            StartQuiz(selectedQuestions, $"Общая викторина ({questionsCount} вопросов)", "mixed");
        }

        private List<Question> ShuffleQuestions(List<Question> questions)
        {
            Random random = new Random();
            var shuffled = new List<Question>(questions);
            
            for (int i = shuffled.Count - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                var temp = shuffled[i];
                shuffled[i] = shuffled[j];
                shuffled[j] = temp;
            }
            
            return shuffled;
        }

        private void StartQuiz(List<Question> questions, string quizTitle, string quizId)
        {
            QuizForm quizForm = new QuizForm(questions, quizTitle, quizId, currentUser);
            quizForm.ShowDialog();
            
            results = DataStorage.LoadResults();
            UpdateRankings();
        }

        private void ChangeProfileButton_Click(object sender, EventArgs e)
        {
            string oldPassword = oldPasswordTextBox.Text.Trim();
            string newPassword = newPasswordTextBox.Text.Trim();
            DateTime selectedBirthDate = birthChangeCalendar.SelectionStart;

            if (!string.IsNullOrEmpty(oldPassword) && !currentUser.VerifyPassword(oldPassword))
            {
                MessageBox.Show("Неверный старый пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var userToUpdate = users.FirstOrDefault(u => u.Login.Equals(currentUser.Login, StringComparison.OrdinalIgnoreCase));
            if (userToUpdate == null)
            {
                MessageBox.Show("Пользователь не найден!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool wasUpdated = false;

            if (!string.IsNullOrEmpty(oldPassword) && !string.IsNullOrEmpty(newPassword))
            {
                userToUpdate.SetPassword(newPassword);
                currentUser.SetPassword(newPassword);
                wasUpdated = true;
            }

            string newBirthDateString = selectedBirthDate.ToString("yyyy-MM-dd");
            if (newBirthDateString != currentUser.BirthDate)
            {
                userToUpdate.BirthDate = newBirthDateString;
                currentUser.BirthDate = newBirthDateString;
                birthDateLabel.Text = selectedBirthDate.ToString("dd.MM.yyyy");
                wasUpdated = true;
            }

            if (wasUpdated)
            {
                DataStorage.SaveUsers(users);
                MessageBox.Show("Профиль успешно обновлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                oldPasswordTextBox.Clear();
                newPasswordTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Нет изменений для сохранения.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void MainTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mainTabControl.SelectedIndex == 4)
            {
                DialogResult result = MessageBox.Show("Вы действительно хотите выйти?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
                if (result == DialogResult.Yes)
                {
                    isLoggingOut = true;
                    Form1 form1 = new Form1();
                    form1.Show();
                    this.Close();
                }
                else
                {
                    mainTabControl.SelectedIndex = 0;
                }
            }
            else if (mainTabControl.SelectedIndex == 2)
            {
                UpdateRankings();
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            
            if (!isLoggingOut)
            {
                Application.Exit();
            }
        }
    }

    public class RankingEntry
    {
        public string Login { get; set; }
        public double AverageScore { get; set; }
        public double TotalScore { get; set; }
        public int GamesPlayed { get; set; }
    }
}
