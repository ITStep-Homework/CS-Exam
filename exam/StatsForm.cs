using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using exam.Models;

namespace exam
{
    public partial class StatsForm : Form
    {
        private User user;
        private List<Result> allResults;
        private List<Quiz> quizzes;
        private List<Result> userResults;

        public StatsForm(User user, List<Result> results, List<Quiz> quizzes)
        {
            this.user = user;
            this.allResults = results;
            this.quizzes = quizzes;
            this.userResults = results.Where(r => r.Login.Equals(user.Login, StringComparison.OrdinalIgnoreCase)).ToList();
            
            InitializeComponent();
            SetupForm();
            LoadStatistics();
        }

        private void SetupForm()
        {
            this.Text = $"Статистика игрока: {user.Login}";
            titleLabel.Text = $"Детальная статистика: {user.Login}";
            
            closeButton.Click += (s, e) => this.Close();
        }

        private void LoadStatistics()
        {
            LoadUserInfo();
            LoadGeneralStats();
            LoadCategoryStats();
            LoadGameHistory();
        }

        private void LoadUserInfo()
        {
            var info = new System.Text.StringBuilder();
            info.AppendLine($"Логин: {user.Login}");
            
            if (DateTime.TryParseExact(user.BirthDate, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime birthDate))
            {
                info.AppendLine($"Дата рождения: {birthDate:dd.MM.yyyy}");
                var age = DateTime.Now.Year - birthDate.Year;
                if (DateTime.Now.DayOfYear < birthDate.DayOfYear) age--;
                info.AppendLine($"Возраст: {age} лет");
            }
            
            if (userResults.Any())
            {
                info.AppendLine($"Дата регистрации в викторинах: {userResults.Min(r => r.Date):dd.MM.yyyy}");
            }

            userInfoLabel.Text = info.ToString();
        }

        private void LoadGeneralStats()
        {
            if (!userResults.Any())
            {
                generalStatsLabel.Text = "Пользователь еще не играл в викторины.";
                return;
            }

            var stats = new System.Text.StringBuilder();
            stats.AppendLine("=== ОБЩАЯ СТАТИСТИКА ===");
            stats.AppendLine($"Всего игр сыграно: {userResults.Count}");
            stats.AppendLine($"Первая игра: {userResults.Min(r => r.Date):dd.MM.yyyy HH:mm}");
            stats.AppendLine($"Последняя игра: {userResults.Max(r => r.Date):dd.MM.yyyy HH:mm}");
            
            double totalQuestions = 0;
            double totalCorrect = 0;
            
            foreach (var result in userResults)
            {
                var questionsCount = GetQuestionsCountByQuizId(result.QuizId);
                totalQuestions += questionsCount;
                totalCorrect += result.CorrectCount;
            }
            
            if (totalQuestions > 0)
            {
                var overallPercentage = (totalCorrect / totalQuestions) * 100;
                stats.AppendLine($"Общий процент правильных ответов: {overallPercentage:F1}%");
            }

            generalStatsLabel.Text = stats.ToString();
        }

        private void LoadCategoryStats()
        {
            if (!userResults.Any())
            {
                categoryStatsLabel.Text = "";
                return;
            }

            var stats = new System.Text.StringBuilder();
            stats.AppendLine("=== СТАТИСТИКА ПО КАТЕГОРИЯМ ===");
            
            var categoryGroups = userResults.GroupBy(r => GetCategoryNameByQuizId(r.QuizId));
            
            foreach (var group in categoryGroups.OrderBy(g => g.Key))
            {
                var categoryName = group.Key;
                var categoryResults = group.ToList();
                var questionsPerGame = GetQuestionsCountByCategory(categoryName);
                
                stats.AppendLine($"\n📚 {categoryName}:");
                stats.AppendLine($"   Игр сыграно: {categoryResults.Count}");
                
                if (questionsPerGame > 0)
                {
                    var avgCorrect = categoryResults.Average(r => r.CorrectCount);
                    var avgPercentage = (avgCorrect / questionsPerGame) * 100;
                    var bestResult = categoryResults.Max(r => r.CorrectCount);
                    var bestPercentage = (bestResult / (double)questionsPerGame) * 100;
                    var worstResult = categoryResults.Min(r => r.CorrectCount);
                    var worstPercentage = (worstResult / (double)questionsPerGame) * 100;
                    
                    stats.AppendLine($"   Средний результат: {avgCorrect:F1}/{questionsPerGame} ({avgPercentage:F1}%)");
                    stats.AppendLine($"   Лучший результат: {bestResult}/{questionsPerGame} ({bestPercentage:F1}%)");
                    stats.AppendLine($"   Худший результат: {worstResult}/{questionsPerGame} ({worstPercentage:F1}%)");
                }
            }

            categoryStatsLabel.Text = stats.ToString();
        }

        private void LoadGameHistory()
        {
            historyListBox.Items.Clear();
            
            var recentGames = userResults.OrderByDescending(r => r.Date).Take(10);
            
            foreach (var game in recentGames)
            {
                var categoryName = GetCategoryNameByQuizId(game.QuizId);
                var questionsCount = GetQuestionsCountByQuizId(game.QuizId);
                var percentage = questionsCount > 0 ? (game.CorrectCount / (double)questionsCount) * 100 : 0;
                
                var gameInfo = $"{game.Date:dd.MM.yyyy HH:mm} | {categoryName} | {game.CorrectCount}/{questionsCount} ({percentage:F1}%)";
                historyListBox.Items.Add(gameInfo);
            }
            
            if (!recentGames.Any())
            {
                historyListBox.Items.Add("История игр пуста");
            }
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

        private void historyLabel_Click(object sender, EventArgs e)
        {

        }

        private void categoryStatsLabel_Click(object sender, EventArgs e)
        {

        }
    }
}