using System.ComponentModel.DataAnnotations;

namespace SchoolProject.Model
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required] 
        public string Name { get; set; }

        public string Address { get; set; }

        [Range(1000000000, 9999999999, ErrorMessage = "Invalid phone number.")]
        public int PhoneNumber { get; set; }
    }
}
