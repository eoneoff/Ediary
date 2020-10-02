using System;
using System.Collections.Generic;
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

        public long ScheduleRecordId {get; set;}

        [Required]
        public DateTime DateAndTime {get; set;}

        public virtual Subject Subject {get; set;}
        public virtual Teacher Teacher {get; set;}
        public virtual ScheduleRecord ScheduleRecord {get; set;}
        public virtual ICollection<DiaryRecord> DiaryRecords {get; set;}
        public virtual ICollection<Mark> Marks {get; set;}
    }
}