using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Forms.Models;

namespace Forms.Controllers
{
    public class TaskController : Controller
    {
        // GET: Task
        public ActionResult Index()
        {
            var tasks = new List<Task>();
            {
                tasks.Add(new Task() { Name = "Nick Nemeth", Description = "Initiate Forms", IsDone = false});
                tasks.Add(new Task() { Name = "April Lee", Description = "Update Database", IsDone = true});
                tasks.Add(new Task() { Name = "Thaddeus Bullard", Description = "Add Help File", IsDone = true});
                tasks.Add(new Task() { Name = "Mercedes Kaestner-Varnado", Description = "Site Mantenance", IsDone = false});
                tasks.Add(new Task() { Name = "Christopher Lindsey", Description = "End Heartache", IsDone = true});
                tasks.Add(new Task() { Name = "Candice Dawson", Description = "Refactor Index", IsDone = false});
                tasks.Add(new Task() { Name = "Fred Yehi", Description = "Update Database", IsDone = true});
                tasks.Add(new Task() { Name = "Bruno Laurer", Description = "Westman API", IsDone = true});
            }
            return View(tasks);
        }
    }
}