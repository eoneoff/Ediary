using System;
using System.ComponentModel.DataAnnotations;

namespace Ediary.Model
{
    public class DiaryRecord
    {
        public long Id {get; set;}
        
        [Required]
        public long StudentId{get;set;}

        [Required]
        public long TeachedId {get; set;}

        [Required]
        public long DiaryId {get; set;}

        [Required]
        public long LessonId {get; set;}

        [Required]
        public DateTime Date {get; set;}
        public string Record {get; set;}
        public bool IsReprimand {get; set;} = false;
        public bool IsPraise {get; set;} = false;
        
        public virtual Student Student {get;set;}
        public virtual Teacher Teacher {get; set;}
        public virtual Diary Diary {get; set;}
        public virtual Lesson Lesson {get; set;}
    }
}