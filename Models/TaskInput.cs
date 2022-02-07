using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6.Models
{
    public class TaskInput
    {
        [Key]
        [Required]
        public int TaskID { get; set; }
        [Required (ErrorMessage ="You must enter a task.")]
        public string Task { get; set; }
        public DateTime DueDate { get; set; }
        [Required (ErrorMessage ="You must specify a Quadrant")]
        public int Quadrant { get; set; }
        
        //foreign Key Relationship
        public int CategoryID { get; set; }
        public Category Category { get; set; }
        
        public bool Completed { get; set; }

    }
}
