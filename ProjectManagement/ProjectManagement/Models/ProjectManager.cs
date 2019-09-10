using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjectManagement.Models
{
    public class ProjectManager
    {
        public ProjectManager()
        {
            this.Project = new HashSet<Project>();
        }

        public int Id { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First Name is required.")]
        [RegularExpression(@"^([a-zA-Z ]{3,})$", ErrorMessage = "First Name contains only alphabets and at least 3 characters.")]
        [MaxLength(20, ErrorMessage = "First Name should contain only 20 characters.")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last Name is required.")]
        [RegularExpression(@"^([a-zA-Z ]{3,})$", ErrorMessage = "Last Name contains only alphabets and at least 3 characters.")]
        [MaxLength(20, ErrorMessage = "Last Name should contain only 20 characters.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Address is required.")]
        [RegularExpression(@"^([a-zA-Z0-9,\-. ]{10,})$", ErrorMessage = "Address contains alphabets, numbers, (,), (-)  and at least 10 characters.")]
        [MaxLength(100, ErrorMessage = "Address should contain only 100 characters.")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [RegularExpression(@"^([\w-\.]+@([\w-]+\.)+[\w-]{2,4})?$", ErrorMessage = "Email address should be in the format abc@abc.test.com.")]
        [MaxLength(30, ErrorMessage = "Email should contain only 30 characters.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Contact is required.")]
        [RegularExpression(@"^([0-9]{10,})$", ErrorMessage = "Contact contains only numbers.")]
        [MaxLength(10, ErrorMessage = "Contact should contain only 10 numbers.")]
        public string Contact { get; set; }

        [Required(ErrorMessage = "Gender is required.")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Department is required.")]
        public Department Department { get; set; }

        public virtual ICollection<Project> Project { get; set; }
    }

    public enum Department
    {
        [Display(Name = "Web")]
        Web = 1,
        [Display(Name = "Mobility")]
        Mobility = 2,
        [Display(Name = "Support")]
        Support = 3
    }
}
