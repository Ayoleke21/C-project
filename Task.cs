// Task.cs
namespace TaskManagerApp
{
    public class Task(string description)
    {
        public string Description { get; set; } = description;
    }
}