using System;
using Xunit;
using TaskManagerApp; // Import the appropriate namespace

namespace TaskManagerApp.Tests
{
    public class TaskManagerTests
    {
        [Fact]
        public void AddTask_Should_AddTaskToList()
        {
            // Arrange
            TaskManager taskManager = new TaskManager();

            // Act
            taskManager.AddTask("Sample Task");

            // Assert
            Assert.Single(taskManager.Tasks); // Assuming Tasks property in TaskManager is public
            // Add more assertions as needed
        }
    }
}
