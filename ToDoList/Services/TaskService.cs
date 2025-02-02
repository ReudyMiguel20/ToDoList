using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToDoList.Models;

namespace ToDoList.Services
{
    internal class TaskService
    {
        private readonly List<Models.Task> tasks;

        public TaskService()
        {
            tasks = new List<Models.Task>();
        }

        public void AddTask(Models.Task task)
        {
            tasks.Add(task);
        }

        public void PrintAllTasks()
        {
            foreach (Models.Task task in tasks)
            {
                Console.WriteLine("\n" + task.ToString());
            }
        }

        public String DeleteTaskByID(int taskId)
        {
            for (int i = 0; i < tasks.Count; i++)
            {
                if (tasks[i].Id == taskId)
                {
                    tasks.RemoveAt(i);
                    return $"Task with ID: {taskId} has been deleted successfully";
                }
            }

            return "Task not found";
        }

        public String FindTaskByID(int taskId)
        {
            for (int i = 0; i < tasks.Count; i++)
            {
                if (tasks[i].Id == taskId)
                {
                    return tasks[i].ToString();
                }
            }

            return "Task not found";
        }

        public void DeleteAllTasks()
        {
            Console.WriteLine("Do you really want to delete all tasks? Y/N?\n");
            string input = Console.ReadLine();

            if (input.Equals("Y") && input.Count() >= 1)
            {
                tasks.Clear();
            }
        }
    }
}
