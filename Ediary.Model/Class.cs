using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Ediary.Model
{
    public class Class
    {
        public int Id {get; set;}

        [Required]
        public int Grade {get; set;}
        public string Letter {get; set;}

        [Required]
        public int ClassMasterId {get; set;}

        public virtual ICollection<Student> Students {get; set;}
        public virtual Teacher ClassMaster {get; set;}

    }
}