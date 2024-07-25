using System.ComponentModel.DataAnnotations;

namespace Run_AC_Identity.Models
{
    
    public class Member
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string IdNumber { get; set; }
        public string Gender { get; set; }
        public string Occupation { get; set; }
    }
}