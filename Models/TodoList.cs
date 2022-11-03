using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ToDoListMVC.Models
{
    public class TodoList
    {
        public int id { get; set; }
        [Required]
        public string Content { get; set; }
    }
}
