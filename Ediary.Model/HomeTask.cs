using System;
using System.ComponentModel.DataAnnotations;

namespace Ediary.Model
{
    public class HomeTask
    {
        public long Id {get; set;}

        [Required]
        public DateTime Assigned {get;set;}

        [Required]
        public DateTime Due { get; set; }

        [Required]
        public int SubjectId {get; set; }

        public virtual Subject Subject {get; set;}
    }
}