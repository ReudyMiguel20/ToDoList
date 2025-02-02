using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Models;
using ToDoList.Services;
using ModelsTask = ToDoList.Models.Task;

namespace ToDoList
{
    internal class TaskInputService
    {
        private readonly TaskService taskService;
        private int taskId;
        DateTime dateCreated;

        public TaskInputService(TaskService taskService)
        {
            this.taskService = taskService;
            this.taskId = 0;
        }

        public void InitialDateInput()
        {
            // Try to parse the input and it need to come out as an Int,
            // if it come out as an int then the variable of it would be day, as it is declaring it on the same line
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int day))
                {
                    Console.WriteLine($"The day is {day} of february");
                }
                else
                {
                    Console.WriteLine("Invalid Input, put a day between 1-28");
                }

                // Updating variables
                dateCreated = new DateTime(2024, 2, day);
                break;
            }
        }

        public void TaskCreation()
        {
            Console.WriteLine("Write the task Description:");
            string description = Console.ReadLine();

            // Put a logic here in the future that the due date cannot be below the current day
            Console.WriteLine("Write the day number that you want to complete said task");
            int dueDay = int.Parse(Console.ReadLine());

            Console.WriteLine("Set Priority: Low, Medium, High");
            string priority = Console.ReadLine();

            taskService.AddTask(new ModelsTask(taskId, description, new DateTime(2024, 2, dueDay), false, Priority.Low, DateTime.Now));
            taskId++;
        }
    }
}
