using System;

namespace MiniProject_AspNetCoreTaskManager.Models
{
    public class TaskItem
    {
        public int Id { get; set; }               // Unique ID
        public string Title { get; set; } = String.Empty;        // Task Title
        public string Description { get; set; } = String.Empty;   // Task Description
        public bool IsCompleted { get; set; }     // Status

        // New Properties
        public DateTime CreatedAt { get; set; } = DateTime.Now; // Auto set
        public DateTime? DueDate { get; set; }    // Nullable → not mandatory
        public string Priority { get; set; }  =String.Empty;     // Low / Medium / High
    }
}
