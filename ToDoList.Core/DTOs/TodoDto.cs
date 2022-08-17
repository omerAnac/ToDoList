using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Core.DTOs
{
    public class TodoDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }     
        public string Title { get; set; }       
        public string Content { get; set; }
        public bool IsDone { get; set; }      
        public DateTime AddedDate { get; set; }        
        public DateTime DuetoDateTime { get; set; }
    }
}
