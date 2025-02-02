using System;
using System.Runtime.CompilerServices;
using ToDoList.Models;
using ToDoList.Services;
using ModelsTask = ToDoList.Models.Task;

namespace ToDoList
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskService taskService = new TaskService();
            TaskInputService taskInputService = new TaskInputService(taskService);

            MenuService menuService = new MenuService(taskService, taskInputService);

            menuService.greetingsInput();
            menuService.DisplayMenu();
        }
    }
}
