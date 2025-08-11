using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace exam.Models
{
    public class User
    {
        public string Login { get; set; }
        public string PasswordHash { get; set; }
        public string BirthDate { get; set; }

        public void SetPassword(string password)
        {
            PasswordHash = HashPassword(password);
        }

        public bool VerifyPassword(string password)
        {
            return string.Equals(HashPassword(password), PasswordHash, StringComparison.OrdinalIgnoreCase);
        }

        private static string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }

    public class Quiz
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public List<Question> Questions { get; set; }
    }

    public class Question
    {
        public string Text { get; set; }
        public List<Answer> Answers { get; set; }
    }

    public class Answer
    {
        public string Text { get; set; }
        public bool IsCorrect { get; set; }
    }

    public class Result
    {
        public string Login { get; set; }
        public string QuizId { get; set; }
        public DateTime Date { get; set; }
        public int CorrectCount { get; set; }
    }
}
