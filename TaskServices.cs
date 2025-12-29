using System;
using TaskList.Models;
using Newtonsoft.Json;
using System.IO;

namespace TaskList.Services
{
    public class TaskService
    {
        private static string m_homePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        private static string m_folderPath = Path.Combine(m_homePath, ".config", "tasklist");
        private static string m_filePath = Path.Combine(m_folderPath, "task.json");
        
        public void AddTask()
        {
            TaskModel taskModel = new TaskModel
            {
                Id = 12,
                Description = "NONE",
                IsComplete = true,
                CreatedAt = DateTime.Now
            };

            string json = JsonConvert.SerializeObject(taskModel, Formatting.Indented);
            Console.WriteLine(json);
            if (!Directory.Exists(m_folderPath)) Directory.CreateDirectory(m_folderPath);
            File.WriteAllText(m_filePath, json);
        }
    }
}