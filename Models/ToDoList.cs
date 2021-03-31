using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoList_APP.Models
{
    public class TodoList
    {
        public int Id { get; set; }
        [Required]
        public string Note { get; set; }
        public string Status { get; set; }
    }
}
