using System.Collections.Generic;
using System;

namespace ToDoList.Models
{
    public class Task
    {
        public string Description;
        private int _id;
        public bool Completed = false;
        private static List<Task> _instances = new List<Task>();
        public DateTime DueDate;
        public string Name;

        private static int IDTracker = 0;

        public Task(string name, string description, DateTime due)
        {
            Description = description;
            Name = name;
            DueDate = due;
            _id = IDTracker++;
            _instances.Add(this);
        }

        public int GetID()
        {
            return _id;
        }

        public static List<Task> GetInstances()
        {
            return new List<Task>(_instances);
        }

        //Returns the task with the specified id {id}, or null if no such task exists
        public static Task GetByID(int id)
        {
            Task result = null;
            foreach (Task item in _instances)
            {
                if (item.GetID() == id)
                {
                    result = item;
                }
            }
            return result;
        }
    }
}
