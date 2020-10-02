using System.Collections.Generic;
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
        public virtual ICollection<Diary> Diaries {get; set;}
        public virtual ICollection<DiaryRecord> DiaryRecords {get; set;}
        public virtual ICollection<Mark> Marks { get; set;}
    }
}