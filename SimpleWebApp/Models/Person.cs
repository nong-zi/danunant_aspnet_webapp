using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SimpleWebApp.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }

        [Required (ErrorMessage = "Name is required.")]
        public string Name { get; set; }
        [Range(0,999)]
        public string Age { get; set; }
        [DisplayName("Birth Date")]
        public DateOnly BirthDate { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
    }
}
