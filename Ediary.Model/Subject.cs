using System.ComponentModel.DataAnnotations;

namespace Ediary.Model
{
    public class Subject
    {
        public int Id {get; set;}

        [Required]
        public string Name {get; set;}
    }
}