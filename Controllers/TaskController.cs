using Microsoft.AspNetCore.Mvc;
using MiniProject_AspNetCoreTaskManager.Models;
using System.Collections.Generic;
using System.Linq;

namespace MiniProject_AspNetCoreTaskManager.Controllers
{
    public class TaskController : Controller
    {
        private static List<TaskItem> _tasks = new List<TaskItem>();

        // Show all tasks
        public IActionResult Index()
        {
            return View(_tasks.OrderBy(t => t.DueDate)); // Show by due date
        }

        // Create Task (GET)
        public IActionResult Create()
        {
            return View();
        }

        // Create Task (POST)
        [HttpPost]
        public IActionResult Create(TaskItem task)
        {
            if (ModelState.IsValid)
            {
                task.Id = _tasks.Count + 1;
                task.CreatedAt = DateTime.Now; // Set current date
                _tasks.Add(task);
                return RedirectToAction("Index");
            }
            return View(task);
        }

        // Mark Task Complete
        public IActionResult MarkComplete(int id)
        {
            var task = _tasks.FirstOrDefault(t => t.Id == id);
            if (task != null)
            {
                task.IsCompleted = true;
            }
            return RedirectToAction("Index");
        }
    }
}
