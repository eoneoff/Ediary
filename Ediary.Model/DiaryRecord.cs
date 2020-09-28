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
        public long DiaryId {get; set;}

        [Required]
        public int SubjectId {get; set;}

        [Required]
        public DateTime Date {get; set;}

        public string HomeTask {get; set;}

        public virtual Student Student {get;set;}
        public virtual Diary Diary {get; set;}
        public virtual Subject Subject {get; set;}
    }
}