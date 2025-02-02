using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Models;
using ToDoList.Services;

namespace ToDoList
{
    internal class MenuService
    {
        private readonly TaskService _taskService;
        private readonly TaskInputService _taskInputService;

        public MenuService(TaskService taskService, TaskInputService taskInputService)
        {
            _taskService = taskService;
            _taskInputService = taskInputService;
        }

        public void greetingsInput()
        {
            Console.WriteLine("Welcome to To Do Task List v1.324\n");
            Console.WriteLine("The year is 2024, the month is february, tasks will only work for this month");
            Console.WriteLine("Please input the Day of february:");

            _taskInputService.InitialDateInput();
        }

        public void DisplayMenu()
        {
            while (true)
            {
                string input;

                Console.WriteLine("---Menu---\n");
                Console.WriteLine("1 - Add New Task");
                Console.WriteLine("2 - Find Task by Specific ID");
                Console.WriteLine("3 - Delete Task by Specific ID");
                Console.WriteLine("4 - Print All Tasks");
                Console.WriteLine("5 - Delete All Tasks");
                Console.WriteLine("exit - Exit the program");

                input = Console.ReadLine();

                switch (input.ToLower())
                {
                    case "1":
                        {
                            _taskInputService.TaskCreation();
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("Write the ID of the desired task to show");
                            int taskIdNumber = int.Parse(Console.ReadLine());

                            Console.WriteLine(_taskService.FindTaskByID(taskIdNumber));
                            break;
                        }
                    case "3":
                        {
                            Console.WriteLine("Write the ID of the desired task to delete");
                            int taskIdNumber = int.Parse(Console.ReadLine());

                            Console.WriteLine(_taskService.DeleteTaskByID(taskIdNumber));
                            break;
                        }
                    case "4":
                        {
                            _taskService.PrintAllTasks();
                            break;
                        }
                    case "5":
                        {
                            _taskService.DeleteAllTasks();
                            break;
                        }
                    case "exit":
                        {
                            break;
                        }
                    default:
                        {
                            Console.Write("Input not valid, try again.");
                            break;
                        }

                }

                if (input == "exit")
                {
                    break;
                }
            }
        }
    }
}
