using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Forms.Controllers;

namespace Forms.Models
{
    public class Task
    {
        public Task(string name, string description, bool isDone)
        {
            Name = name;
            Description = description;
            IsDone = isDone;
        }

        public Task()
        {
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsDone { get; set; }
    }
}