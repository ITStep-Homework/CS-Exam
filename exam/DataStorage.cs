using exam.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace exam.Storage
{
    public static class DataStorage
    {
        static string DataDir => Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");
        static string UsersFile => Path.Combine(DataDir, "users.json");
        static string QuizzesFile => Path.Combine(DataDir, "quizzes.json");
        static string ResultsFile => Path.Combine(DataDir, "results.json");

        public static List<User> LoadUsers()
        {
            EnsureDataDir();
            if (!File.Exists(UsersFile)) return new List<User>();
            var s = File.ReadAllText(UsersFile);
            return JsonConvert.DeserializeObject<List<User>>(s);
        }

        public static void SaveUsers(List<User> users)
        {
            EnsureDataDir();
            File.WriteAllText(UsersFile, JsonConvert.SerializeObject(users, Newtonsoft.Json.Formatting.Indented));
        }

        public static List<Quiz> LoadQuizzes()
        {
            EnsureDataDir();
            if (!File.Exists(QuizzesFile)) return new List<Quiz>();
            var s = File.ReadAllText(QuizzesFile);
            return JsonConvert.DeserializeObject<List<Quiz>>(s);
        }

        public static void SaveQuizzes(List<Quiz> quizzes)
        {
            EnsureDataDir();
            File.WriteAllText(QuizzesFile, JsonConvert.SerializeObject(quizzes, Newtonsoft.Json.Formatting.Indented));
        }

        public static List<Result> LoadResults()
        {
            EnsureDataDir();
            if (!File.Exists(ResultsFile)) return new List<Result>();
            var s = File.ReadAllText(ResultsFile);
            return JsonConvert.DeserializeObject<List<Result>>(s);
        }

        public static void SaveResults(List<Result> results)
        {
            EnsureDataDir();
            File.WriteAllText(ResultsFile, JsonConvert.SerializeObject(results, Newtonsoft.Json.Formatting.Indented));
        }

        static void EnsureDataDir()
        {
            if (!Directory.Exists(DataDir)) Directory.CreateDirectory(DataDir);
        }
    }
}