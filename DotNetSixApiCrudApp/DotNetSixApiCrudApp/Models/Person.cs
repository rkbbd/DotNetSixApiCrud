using System.ComponentModel.DataAnnotations;

namespace DotNetSixApiCrudApp.Models
{
    public class Person
    {
        public int Id { get; set; }
        [Display(Name = "Full Name")]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string Phone { get; set; }
        [Range(1, 150, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public int Age { get; set; }
    }
}
