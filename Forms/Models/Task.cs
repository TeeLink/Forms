using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Forms.Controllers;

namespace Forms.Models
{
    public class Task
    {
        public Task(int id, string name, string description, bool isDone)
        {
            Id = id;
            Name = name;
            Description = description;
            IsDone = isDone;
        }

        public Task()
        {
        }

        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Display (Name = "Completed?")]
        public bool IsDone { get; set; }
    }
}