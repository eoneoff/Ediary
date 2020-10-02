using System.ComponentModel.DataAnnotations;

namespace Ediary.Model
{
    public class Mark
    {
        public long Id {get; set;}

        [Required]
        public long LessonId {get;set;}

        [Required]
        public long StudentId {get; set;}

        [Required]
        [Range(1,12)]
        public int Points{get;set;}

        public virtual Lesson Lesson {get; set;}
        public virtual Student Student {get; set;}
    }
}