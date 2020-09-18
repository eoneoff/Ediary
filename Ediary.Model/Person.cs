using System;
using System.ComponentModel.DataAnnotations;

namespace Ediary.Model
{
    public class Person
    {
        public long Id {get;set;}

        [Required]
        public string FirstName {get; set;}

        [Required]
        public string FamilyName {get; set;}

        public string Patronimic {get;set;}

        [Required]
        public DateTime DateOfBirth {get; set;}

        public virtual Student Student {get; set;}
        public virtual Teacher Teacher {get; set;}
    }
}