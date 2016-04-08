using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Task = Forms.Models.Task;

namespace Forms.Controllers
{
    public class TaskController : Controller
    {
        // GET: Task
        public ActionResult Index()
        {
            
            List<Task> currentTask;
            currentTask = (List<Task>)Session["tasks"] ?? new List<Task>();

            return View(currentTask);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Task newTask)
        {
            var currentTask = (List<Task>)Session["tasks"];
            if (ModelState.IsValid)
            {
                if (currentTask == null)
                {
                    currentTask = new List<Task>();
                }

                currentTask.Add(newTask);
                Session["tasks"] = currentTask;
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }


        }
    }

}
