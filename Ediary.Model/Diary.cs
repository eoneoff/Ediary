using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Ediary.Model
{
    public class Diary
    {
        public long Id {get; set;}

        [Required]
        public long StudentId {get; set;}

        [Required]
        public long ClassId {get; set;}

        public virtual Student Student {get; set;}
        public virtual Class Class {get; set;}
    }
}