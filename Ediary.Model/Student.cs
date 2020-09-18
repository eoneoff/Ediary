using System.ComponentModel.DataAnnotations;

namespace Ediary.Model
{
    public class Student
    {
        public long Id {get; set;}

        [Required]
        public int ClassId{get;set;}

        public virtual Person Person { get; set;}
        public virtual Class Class {get; set;}
    }
}