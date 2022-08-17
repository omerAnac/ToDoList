using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Core.Models
{
    public class User :BaseEntity
    {
        [Required]
        [MinLength(10)]
        [MaxLength(50)]
        public string Username { get; set; }
        [Required]
        [MinLength(8)]
        [MaxLength(15)]
        public string Password { get; set; }
        public ICollection<Todo> Todos { get; set; }
    }
}
