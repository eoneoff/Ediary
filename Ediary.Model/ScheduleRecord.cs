using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Ediary.Model
{
    public class ScheduleRecord
    {
        public long Id {get; set;}

        [Required]
        public int SubjectId{get;set;}

        public long? AssignedTeacherId {get; set;}

        public DateTime DateAndTime {get; set;}

        [Range(0,6)]
        public int? WeekDay {get; set;}

        public int? RepeatWeeks{get;set;}

        public int? RepeatMonths{get;set;}

        public virtual Subject Subject {get; set;}
        public virtual Teacher AssignedTeacher {get; set;}
        public virtual ICollection<Lesson> Lessons {get; set;}
    }
}