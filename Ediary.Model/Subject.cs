using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Ediary.Model
{
    public class Subject
    {
        public int Id {get; set;}

        [Required]
        public string Name {get; set;}

        public virtual ICollection<ScheduleRecord> ScheduleRecords {get; set;}
        public virtual ICollection<Lesson> Lessons {get; set;}
        public virtual ICollection<HomeTask> HomeTasks {get; set;}
    }
}