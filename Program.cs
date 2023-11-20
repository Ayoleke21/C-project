using System;

namespace TaskManagerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskManager taskManager = new TaskManager();

            while (true)
            {
                Console.WriteLine("Task Manager Menu:");
                Console.WriteLine("1. Add Task");
                Console.WriteLine("2. View Tasks");
                Console.WriteLine("3. Exit");

                Console.Write("Enter your choice: ");
                string? choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter task description: ");
                        string? description = Console.ReadLine();
                        if (description == null) {
                            break;
                        }
                        taskManager.AddTask(description);
                        Console.WriteLine("Task added!");
                        break;

                    case "2":
                        Console.WriteLine("Tasks:");
                        taskManager.DisplayTasks();
                        break;

                    case "3":
                        Console.WriteLine("Exiting Task Manager...");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}
