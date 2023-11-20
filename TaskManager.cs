// TaskManager.cs
using System;
using System.Collections.Generic;

namespace TaskManagerApp
{
    public class TaskManager
    {
        private List<Task> tasks;

        public TaskManager()
        {
            tasks = new List<Task>();
        }

        public void AddTask(string description)
        {
            Task newTask = new Task(description);
            tasks.Add(newTask);
        }

        public void DisplayTasks()
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks found.");
                return;
            }

            int count = 1;
            foreach (var task in tasks)
            {
                Console.WriteLine($"{count}. {task.Description}");
                count++;
            }
        }
    }
}