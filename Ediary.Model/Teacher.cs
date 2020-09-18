using System.ComponentModel.DataAnnotations;

namespace Ediary.Model
{
    public class Teacher
    {
        public long Id { get; set;}

        [Required]
        public virtual Person Person {get; set;}

        public virtual Class Class {get; set;}
    }
}