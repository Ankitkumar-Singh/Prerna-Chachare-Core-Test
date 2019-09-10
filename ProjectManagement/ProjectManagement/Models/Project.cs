using ProjectManagement.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjectManagement.Models
{
    public class Project
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [RegularExpression(@"^([a-zA-Z0-9 ]{3,})$", ErrorMessage = "Name contains only alphabets, numbers and at least 3 characters.")]
        [MaxLength(100, ErrorMessage = "Name should contain only 100 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Description is required.")]
        [RegularExpression(@"^([a-zA-Z0-9,\-. ]{10,})$", ErrorMessage = "Description contains alphabets, numbers, (,) and at least 10 characters.")]
        [MaxLength(500, ErrorMessage = "Description should contain only 500 characters.")]
        public string Description { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Start Date")]
        [Required(ErrorMessage = "Start Date is required.")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [ValidateDateRange("Start Date should be between 01-01-2000 and current date.")]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "Type is required.")]
        public string Type { get; set; }

        [Display(Name = "Is Active")]
        public bool IsActive { get; set; }

        [Display(Name = "Project Manager")]
        [Required(ErrorMessage = "Project Manager is required.")]
        public int ProjectManagerId { get; set; }

        public virtual ProjectManager ProjectManager { get; set; }
    }
}
