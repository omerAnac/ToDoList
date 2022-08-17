using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Core.Models
{
    public class Todo : BaseEntity
    {
        public int UserId { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(50)]
        public string Title { get; set; }

        [MaxLength(200)]
        [MinLength(15)]
        [DataType(DataType.MultilineText)]
        public string Content { get; set; }
        public bool IsDone { get; set; }

        [DataType(DataType.DateTime)]
        [Column("Added")]
        public DateTime AddedDate { get; set; }=DateTime.Now;

        [DataType(DataType.DateTime)]
        [Column("DueTo")]
        public DateTime DuetoDateTime { get; set; }

        public User User { get; set; }

    }
}
