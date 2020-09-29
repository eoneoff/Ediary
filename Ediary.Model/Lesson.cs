using System.ComponentModel.DataAnnotations;

namespace Ediary.Model
{
    public class Lesson
    {
        public long Id {get; set;}

        [Required]
        public int SubjectId {get;set;}

        [Required]
        public long TeacherId {get; set;}

        public virtual Subject Subject {get; set;}
        public virtual Teacher Teacher {get; set;}
    }
}