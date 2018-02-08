using Microsoft.AspNetCore.Mvc;
using System;
using ToDoList.Models;

namespace ToDoList.Controllers
{
    public class TasksController : Controller
    {
        [HttpGet("/tasks")]
        public ActionResult Index()
        {
            return View(Task.GetInstances());
        }

        [HttpGet("/tasks/new")]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost("/tasks")]
        public ActionResult AddTask()
        {
            string[] dateStrings = Request.Form["do-by"].ToString().Split('-');
            string taskName = Request.Form["name"];
            string description = Request.Form["description"];
            DateTime dueDate = new DateTime(int.Parse(dateStrings[0]), int.Parse(dateStrings[1]), int.Parse(dateStrings[2]));

            Task task = new Task(taskName, description, dueDate);

            return View("Index", Task.GetInstances());
        }

    }
}
