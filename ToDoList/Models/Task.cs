using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Models
{
    internal class Task
    {
        private int id;
        private string description;
        private DateTime dueDate;
        private bool isCompleted;
        private Priority priority;
        private DateTime createdDate;
        private DateTime completedDate;

        // Public properties

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public DateTime DueDate
        {
            get { return dueDate; }
            set { dueDate = value; }
        }

        public bool IsCompleted
        {
            get { return isCompleted; }
            set { isCompleted = value; }
        }

        public Priority Priority
        {
            get { return priority; }
            set { priority = value; }
        }

        public DateTime CreatedDate
        {
            get { return createdDate; }
            set { createdDate = value; }
        }

        // Constructor
        public Task(
            int id, 
            string description, 
            DateTime dueDate, 
            bool isCompleted, 
            Priority priority, 
            DateTime createdDate
            )
        {
            this.id = id;
            this.description = description;
            this.dueDate = dueDate;
            this.isCompleted = isCompleted;
            this.priority = priority;
            this.createdDate = createdDate;
        }

        public override string ToString()
        {
            return $"ID: {id} - Task Description: {description}. " +
                $"\nTask Creation Date: {createdDate} - Due Date: {dueDate} " +
                $"\nTask Status: {isCompleted} / Task Priority: {priority}\n";
        }

    }
}
