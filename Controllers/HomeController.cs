using Microsoft.AspNetCore.Mvc;
using System;

namespace ToDoList.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public void Home()
        {
            Response.Redirect("/tasks");
        }
    }
}
